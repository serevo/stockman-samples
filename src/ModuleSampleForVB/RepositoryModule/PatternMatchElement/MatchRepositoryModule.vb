Imports System.ComponentModel.Composition
Imports System.Text.Json
Imports System.Threading
Imports Storex

<Export(GetType(IRepositoryModule))>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.Id), "39769087-866B-4C88-B116-BBB701631B23")>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.DisplayName), "QR内容をMatchで判定  簡易ファイルシステム")>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.Description), "先頭Pの1～10桁の部品名・先頭Sのシリアル番号のQRと先頭Qの1～5桁の入り数のQRのペアをキーに、指定されたフォルダ内にデータを保存")>
Public Class MatchRepositoryModule
    Implements IRepositoryModule

    Public ReadOnly Property IsConfiguable As Boolean Implements IModule.IsConfiguable
        Get
            Return True
        End Get
    End Property

    Public Function ConfigureAsync() As Task Implements IModule.ConfigureAsync
        Dim dialog = New RepositoryConfigureForm()
        dialog.Show(Form.ActiveForm)
        ConfigureAsync = Task.CompletedTask
    End Function

    Public Function EditModeAsync(mode As IMode) As Task Implements IRepositoryModule.EditModeAsync
        EditModeAsync = Task.CompletedTask
    End Function

    Dim RegisterMode As IMode
    Dim ModeSetting As MatchRepositoryModeSetting
    Dim RegisterUserInfo As IUserInfo

    Public Function PrepareAsync(mode As IMode, userInfo As IUserInfo) As Task Implements IRepositoryModule.PrepareAsync
        If TypeOf mode.RepositorySettings Is JsonElement Then
            Dim str = JsonSerializer.Serialize(mode.RepositorySettings)

            Try
                ModeSetting = JsonSerializer.Deserialize(Of MatchRepositoryModeSetting)(str)
            Catch ex As JsonException
            End Try
        ElseIf TypeOf mode.RepositorySettings Is MatchRepositoryModeSetting Then
            ModeSetting = CType(mode.RepositorySettings, MatchRepositoryModeSetting)

        ElseIf mode.RepositorySettings IsNot Nothing Then
            Throw New InvalidOperationException
        End If

        RegisterMode = mode
        RegisterUserInfo = userInfo

        PrepareAsync = Task.CompletedTask
    End Function

    Public Function SelectPrimaryElement(elements() As IElement) As IElement Implements IRepositoryModule.SelectPrimaryElement
        Return MatchElement.Extract(elements.OfType(Of Symbol))
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

    Public Function RegisterAsync(primaryElement As IElement, secondaryElement As IElement, captureResults() As CaptureResult, tags() As String) As Task Implements IRepositoryModule.RegisterAsync
        Throw New NotImplementedException()
    End Function

    Public Function RegisterAsync(primaryElement As IElement, secondaryElement As IElement, captureResults() As CaptureResult, tags() As String, cancellationToken As CancellationToken) As Task Implements IRepositoryModule.RegisterAsync
        Throw New NotImplementedException()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub
End Class
