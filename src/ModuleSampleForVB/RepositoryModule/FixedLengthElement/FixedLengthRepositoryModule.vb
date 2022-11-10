Imports System.ComponentModel.Composition
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports System.Text.Json
Imports System.Threading
Imports Storex
Imports Encoder = System.Drawing.Imaging.Encoder

<Export(GetType(IRepositoryModule))>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.Id), "E0B3F83A-B417-43DB-8CCF-9916A2EB63C6")>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.DisplayName), "文字数固定キーシンボル  簡易ファイルシステム")>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.Description), "モード毎にキー条件指定、指定されたフォルダ内にデータを保存")>
Public Class FixedLengthRepositoryModule
    Implements IRepositoryModule

    Public ReadOnly Property IsConfiguable As Boolean Implements IRepositoryModule.IsConfiguable
        Get
            IsConfiguable = True
        End Get
    End Property

    Public Function ConfigureAsync() As Task Implements IModule.ConfigureAsync
        Dim dialog = New RepositoryConfigureForm()
        dialog.Show(Form.ActiveForm)
        ConfigureAsync = Task.CompletedTask
    End Function

    Public Function EditModeAsync(mode As IMode) As Task Implements IRepositoryModule.EditModeAsync
        FixedLengthRepositoryModeSettingForm.Show(mode)
        EditModeAsync = Task.CompletedTask
    End Function

    Dim RegisterMode As IMode
    Dim ModeSetting As FixedLengthRepositoryModeSetting
    Dim RegisterUserInfo As IUserInfo

    Public Function PrepareAsync(mode As IMode, userInfo As IUserInfo) As Task Implements IRepositoryModule.PrepareAsync
        If TypeOf mode.RepositorySettings Is JsonElement Then
            Dim str = JsonSerializer.Serialize(mode.RepositorySettings)

            Try
                ModeSetting = JsonSerializer.Deserialize(Of FixedLengthRepositoryModeSetting)(str)
            Catch ex As JsonException
            End Try
        ElseIf TypeOf mode.RepositorySettings Is FixedLengthRepositoryModeSetting Then
            ModeSetting = CType(mode.RepositorySettings, FixedLengthRepositoryModeSetting)
        Else
            Throw New ModuleException("モードのレポジトリ設定が行われていません")
        End If

        RegisterMode = mode
        RegisterUserInfo = userInfo

        PrepareAsync = Task.CompletedTask
    End Function

    Public Function SelectPrimaryElement(elements() As IElement) As IElement Implements IRepositoryModule.SelectPrimaryElement
        Dim primaries = elements _
            .OfType(Of Symbol) _
            .Select(Function(x)
                        Dim fixedLengthSymbol As FixedLengthSymbol = Nothing
                        Dim result = FixedLengthSymbol.TryParse(x, ModeSetting, fixedLengthSymbol)

                        Return New With {result, fixedLengthSymbol}
                    End Function) _
            .Where(Function(x) x.result) _
            .Select(Function(x) x.fixedLengthSymbol) _
            .Distinct() _
            .ToArray()

        If (primaries.Length = 1) Then
            Return primaries(0)
        End If

        Return Nothing

    End Function

    Public Function SelectSecondaryElements(primaryElement As IElement, elements() As IElement) As IElement() Implements IRepositoryModule.SelectSecondaryElements
        Dim primaryPartNum = primaryElement.PartNumber

        If RegisterMode.UseSecondaryElement And String.IsNullOrEmpty(primaryPartNum) = False Then

            Dim secondaries = elements _
                .Where(Function(x) x.PartNumber = primaryElement.PartNumber) _
                .ToArray()

            If secondaries.Length > 0 Then
                Return secondaries
            End If

            Dim masterList = SecondaryMasterData.LoadSecondaryMasters

            secondaries = elements _
                .Where(Function(x) masterList.Any(Function(y) y.PartNumber = primaryPartNum And y.ValidData = x.PartNumber)) _
                .ToArray()

            If secondaries.Length > 0 Then
                Return secondaries
            End If
        End If

        Return Array.Empty(Of IElement)
    End Function

    Public Function RegisterAsync(primaryElement As IElement, secondaryElement As IElement, datas() As CaptureResult, textDatas() As String) As Task Implements IRepositoryModule.RegisterAsync
        RegisterAsync = RegisterAsync(primaryElement, secondaryElement, datas, textDatas, CancellationToken.None)
    End Function

    Public Async Function RegisterAsync(primaryElement As IElement, secondaryElement As IElement, datas() As CaptureResult, textDatas() As String, cancellationToken As CancellationToken) As Task Implements IRepositoryModule.RegisterAsync
        Dim folderPath = My.RepositorySettings.Default.RepositoryFolderPath

        If String.IsNullOrEmpty(folderPath) Then
            Throw New InvalidOperationException
        End If

        If TypeOf primaryElement IsNot Symbol Then
            Throw New FormatException()
        End If

        Dim parentDirectory = New DirectoryInfo(folderPath)

        Dim key = CType(primaryElement, Symbol)

        Dim now = DateTimeOffset.Now

        Dim yearDirectoryPath = $"{parentDirectory}\{now:yyyy}年"
        Dim yearDirectory As DirectoryInfo

        If Directory.Exists(yearDirectoryPath) Then
            yearDirectory = New DirectoryInfo(yearDirectoryPath)
        Else
            yearDirectory = parentDirectory.CreateSubdirectory($"{now:yyyy}年")
        End If

        Dim monthDirectoryPath = $"{yearDirectoryPath}\{now:MM月}"
        Dim monthDirectory As DirectoryInfo

        If Directory.Exists(monthDirectoryPath) Then
            monthDirectory = New DirectoryInfo(monthDirectoryPath)
        Else
            monthDirectory = yearDirectory.CreateSubdirectory($"{now:MM月}")
        End If

        Dim newDirectory = monthDirectory.CreateSubdirectory($"{key.Value}_{now:dd_HHmmss_ffff}")
        Await WriteDataAsync(newDirectory, datas, textDatas)

    End Function

    Sub WriteImageFile(path As String, image() As Byte)
        Using ms = New MemoryStream(image.ToArray()), bitmap = New Bitmap(ms), eps = New EncoderParameters(1), ep = New EncoderParameter(Encoder.Quality, 80)
            eps.Param(0) = ep
            bitmap.Save(path, GetEncoderInfo("image/jpeg"), eps)
        End Using
    End Sub

    Function GetEncoderInfo(mineType As String) As ImageCodecInfo
        Dim enc = ImageCodecInfo.GetImageEncoders().ToList().SingleOrDefault(Function(x) x.MimeType = mineType)
        Return enc
    End Function

    Async Function WriteDataAsync(parentDirectory As DirectoryInfo, datas() As CaptureResult, textDatas() As String) As Task
        Dim parentDirectoryPath = parentDirectory.FullName

        Dim count = 1
        For Each data As CaptureResult In datas
            Dim capDirectory = parentDirectory.CreateSubdirectory($"Capture{count}")
            Dim capDirectoryPath = capDirectory.FullName

            Dim originImagePath = $"{capDirectoryPath}\Origin.jpeg"
            WriteImageFile(originImagePath, data.OriginalImage.ToArray())

            Dim decoImagePath = $"{capDirectoryPath}\Decorated.jpeg"
            WriteImageFile(decoImagePath, data.AdornedImage.ToArray())

            If data.Elements.Count > 0 Then
                Dim filePath = $"{capDirectoryPath}\Elements.txt"

                Using sw As New StreamWriter(filePath, False, Encoding.GetEncoding("shift_jis"))
                    For Each element As IElement In data.Elements
                        If TypeOf element Is Symbol Then
                            Dim symbol = CType(element, Symbol)
                            Await sw.WriteLineAsync(symbol.Value)
                        End If
                    Next
                End Using

            End If
        Next

        If textDatas.Length > 0 Then
            Dim memoFilePath = $"{parentDirectoryPath}\Memo.txt"

            Using sw As New StreamWriter(memoFilePath, False, Encoding.GetEncoding("shift_jis"))
                For Each data As String In textDatas
                    Await sw.WriteLineAsync(data)
                Next
            End Using
        End If

        If RegisterUserInfo IsNot Nothing Then
            Dim registeredFilePath = $"{parentDirectoryPath}\登録者.txt"

            Using sw As New StreamWriter(registeredFilePath, False, Encoding.GetEncoding("shift_jis"))
                Await sw.WriteLineAsync(RegisterUserInfo.DisplayName)
            End Using
        End If
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

End Class
