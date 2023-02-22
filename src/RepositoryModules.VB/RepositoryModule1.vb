Imports System.IO
Imports System.Text
Imports System.Threading
Imports Storex

<RepositoryModuleExport("E0B3F83A-B417-43DB-8CCF-9916A2EB63C6", "簡易ファイルシステム", Description:="モードでシンボル内容等を設定します")>
Public Class RepositoryModule1
    Implements IRepositoryModule

    Friend ReadOnly TextEncoding As Encoding = Encoding.GetEncoding("shift_jis")

    Private CurrentMode As IMode
    Private CurrentUser As IUser
    Private PrimaryLabelSpec As FixedLengthSpec
    Private SecondaryLabelCriteria As SecondaryLabelCriteria

    Public ReadOnly Property IsConfiguable As Boolean = True Implements IModule.IsConfiguable

    Public ReadOnly Property IsModeConfiguable As Boolean = True Implements IRepositoryModule.CanConfigureMode

    Public Function ConfigureAsync(cancellationToken As CancellationToken) As Task Implements IModule.ConfigureAsync

        ConfigForm1.Configure()

        Return Task.CompletedTask
    End Function

    Public Function ConfigureModeAsync(mode As IMode, cancellationToken As CancellationToken) As Task Implements IRepositoryModule.ConfigureModeAsync
        ModeConfigForm1.Configure(mode)

        Return Task.CompletedTask
    End Function

    Public Function PrepareAsync(Mode As IMode, UserInfo As IUser, cancellationToken As CancellationToken) As Task(Of Boolean) Implements IRepositoryModule.PrepareAsync
        If Not File.Exists(MySettings.Default.FilePath) Then

            Throw New RepositoryModuleException("概要データ ファイルが正しく設定されていません。")
        End If

        If Not Directory.Exists(MySettings.Default.FolderPath) Then

            Throw New RepositoryModuleException("詳細データ フォルダが正しく設定されていません。")
        End If


        If Not Mode.TryExtractProperty(FixedLengthSpec.PropertyKeyForPrimary, PrimaryLabelSpec) _
            Or Not Mode.TryExtractProperty(SecondaryLabelCriteria.PropertyKey, SecondaryLabelCriteria) Then
            Throw New RepositoryModuleException("モードが構成されていません。")
        End If

        _conditions = ReadSecondaryConditionsFile()

        CurrentMode = Mode
        CurrentUser = UserInfo

        Return Task.FromResult(True)
    End Function

    Public Async Function FindPrimaryLabelAsync(Sources() As ILabelSource, cancellationToken As CancellationToken) As Task(Of ILabel) Implements IRepositoryModule.FindPrimaryLabelAsync
        Await Task.CompletedTask

        Dim MatchSymbols = sources _
            .OfType(Of Symbol) _
            .Select(
                Function(x)

                    Dim LabelDefinition As FixedLengthSpec = Nothing
                    Dim Label As BasicLabel = Nothing
                    Dim IsMatch = PrimaryLabelSpec.TryGenerateLabel(x, Label)

                    Return New With {IsMatch, Label}
                End Function
                ) _
            .Where(Function(x) x.IsMatch) _
            .Select(Function(x) x.Label) _
            .ToArray()

        Return If(MatchSymbols.Length = 1, MatchSymbols(0), Nothing)
    End Function

    Private _conditions As IReadOnlyList(Of SecondaryCondition)

    Public Function FindSecondaryLabelsAsync(primary As ILabel, sources As ILabelSource(), cancellationToken As CancellationToken) As Task(Of ILabel()) Implements IRepositoryModule.FindSecondaryLabelsAsync
        Dim labels = New List(Of ILabel)()

        Dim validConditionValues = If(SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny, _conditions.Where(Function(o) CompareIgnoreCase(o.PrimaryLabelItemNumber, primary.ItemNumber)).[Select](Function(o) o.SecondaryItemNumber).ToArray(), Array.Empty(Of String)())

        Dim c3Labels = sources _
            .Where(Function(__) (SecondaryLabelCriteria.AcceptableTypes And SecondaryLabelTypes.C3Label) = SecondaryLabelTypes.C3Label) _
            .OfType(Of C3Label)() _
            .Where(Function(o) SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior <> SecondaryLabelBehavior.Deny AndAlso CompareIgnoreCase(o.PartNumber, primary.ItemNumber) _
                Or SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny AndAlso validConditionValues.Any(Function(p) CompareIgnoreCase(o.PartNumber, p)) _
                Or SecondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior <> SecondaryLabelBehavior.Deny AndAlso Not CompareIgnoreCase(o.PartNumber, primary.ItemNumber) And Not validConditionValues.Any(Function(p) CompareIgnoreCase(o.PartNumber, p))
                ) _
            .ToList()

        labels.AddRange(c3Labels)

        Dim label As ILabel = Nothing

        Dim singleSymbolLabels = sources _
            .Where(Function(__) (SecondaryLabelCriteria.AcceptableTypes And SecondaryLabelTypes.SingleSymbol) = SecondaryLabelTypes.SingleSymbol).OfType(Of Symbol)() _
            .Where(Function(x) Not PrimaryLabelSpec.TryGenerateLabel(x, label)) _
            .Select(Function(o) New BasicLabel(o) With {.ItemNumber = o.Value}) _
            .Where(Function(o) _
                SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior <> SecondaryLabelBehavior.Deny And CompareIgnoreCase(o.ItemNumber, primary.ItemNumber) _
                Or SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny And validConditionValues.Any(Function(p) CompareIgnoreCase(o.ItemNumber, p))
                ) _
            .ToList()

        labels.AddRange(singleSymbolLabels)

        Return Task.FromResult(labels.ToArray())
    End Function

    Public Async Function RegisterAsync(primary As ILabel, secondary As ILabel, captureDatas As CaptureData(), tags As String(), cancellationToken As CancellationToken) As Task(Of Boolean) Implements IRepositoryModule.RegisterAsync
        If Not File.Exists(MySettings.Default.FilePath) Then
            Throw New RepositoryModuleException("概要データ ファイルが存在しません。")
        End If

        If Not Directory.Exists(MySettings.Default.FolderPath) Then
            Throw New RepositoryModuleException("詳細データ フォルダが存在しません。")
        End If

        If secondary Is Nothing Then
            If SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.Warnning AndAlso Not ShowAlert("セカンダリ ラベルが必要です。無視して登録しますか。") Then
                Return False
            ElseIf SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.Deny Then
                ShowError("セカンダリ ラベルが必要です。")
                Return False
            ElseIf SecondaryLabelCriteria.NoLabelBehavior <> SecondaryNoLabelBehavior.Default Then
                Dim hasItemNumberEqualsToPrimary = tags.Any(Function(o) CompareIgnoreCase(o, primary.ItemNumber))
                Dim hasSpecifiedByConditionFile = tags.Any(Function(o) _conditions.Any(Function(p) CompareIgnoreCase(p.PrimaryLabelItemNumber, primary.ItemNumber) And CompareIgnoreCase(o, p.SecondaryItemNumber)))

                If SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.WarningWhenTagNotMatched AndAlso Not hasItemNumberEqualsToPrimary AndAlso Not hasSpecifiedByConditionFile AndAlso Not ShowAlert("セカンダリ ラベル、又は対応するタグが必要です。無視して登録しますか。") Then
                    Return False
                ElseIf SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.DenyWhenTagNotMatched AndAlso Not hasItemNumberEqualsToPrimary AndAlso Not hasSpecifiedByConditionFile Then
                    ShowError("セカンダリ ラベル、又は対応するタグが必要です。")
                    Return False
                ElseIf SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = SecondaryLabelBehavior.Warnning AndAlso hasItemNumberEqualsToPrimary AndAlso Not ShowAlert("プライマリラベルと同じ品番がタグに含まれています。登録しますか。") Then
                    Return False
                ElseIf SecondaryLabelCriteria.SpecifiedByConditionFileBehavior = SecondaryLabelBehavior.Warnning AndAlso hasSpecifiedByConditionFile AndAlso Not ShowAlert("対応表で指定されている品番がタグに含まれています。登録しますか。") Then
                    Return False
                End If
            End If
        ElseIf SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = SecondaryLabelBehavior.Warnning AndAlso CompareIgnoreCase(primary.ItemNumber, secondary.ItemNumber) AndAlso Not ShowAlert("指定された セカンダリ ラベルは、プライマリラベルと同じ品番です。登録を続行しますか。") Then
            Return False
        ElseIf SecondaryLabelCriteria.SpecifiedByConditionFileBehavior = SecondaryLabelBehavior.Warnning AndAlso _conditions.Any(Function(o) CompareIgnoreCase(o.PrimaryLabelItemNumber, primary.ItemNumber) And CompareIgnoreCase(o.SecondaryItemNumber, secondary.ItemNumber)) AndAlso Not ShowAlert("指定された セカンダリ ラベルは、プライマリ ラベルとは異なり対応表と同じ品番です。登録を続行しますか。") Then
            Return False
        ElseIf SecondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior = SecondaryLabelBehavior.Warnning AndAlso Not CompareIgnoreCase(primary.ItemNumber, secondary.ItemNumber) AndAlso Not _conditions.Any(Function(o) CompareIgnoreCase(o.PrimaryLabelItemNumber, primary.ItemNumber) And CompareIgnoreCase(o.SecondaryItemNumber, secondary.ItemNumber)) AndAlso Not ShowAlert("指定された セカンダリ ラベルは、プライマリラベルや対応表と異なる品番です。登録しますか。") Then
            Return False
        End If

        Dim timestamp = Date.Now

        Dim myFile = New FileInfo(MySettings.Default.FilePath)

        Using sw = New StreamWriter(myFile.FullName, True, TextEncoding)
            If myFile.Length = 0L Then
                Await sw.WriteLineAsync(String.Join(vbTab, New String() {"PrimaryPartNumber", "PrimarySerialNumber", "SecondaryPartNumber", "SecondarySerialNumber", "ModeId", "UserName", "Timestamp"}))
            End If

            Await sw.WriteLineAsync(String.Join(vbTab, New String() {primary.ItemNumber, primary.SerialNumber, secondary?.ItemNumber, secondary?.SerialNumber, CurrentMode.Id.ToString(), CurrentUser?.DisplayName, $"{timestamp:yyyy/MM/dd HH:mm:ss.fff}"}))
        End Using

        Dim mFolder = New DirectoryInfo(MySettings.Default.FolderPath)

        mFolder = mFolder.CreateSubdirectory($"{timestamp:yyyy-MM-dd HH-mm-ss.fff}")

        Dim i = 1, loopTo As Integer = captureDatas.Count()

        While i <= loopTo
            Dim captureData = captureDatas(i - 1)

            Dim captureDataFolder = mFolder.CreateSubdirectory($"catpure#{i}")

            WriteImage($"{captureDataFolder.FullName}\original.jpg", captureData.OriginalImage.ToArray())

            If captureData.AdornedImage IsNot Nothing Then
                WriteImage($"{captureDataFolder.FullName}\adorned.jpeg", captureData.AdornedImage.ToArray())
            End If

            If captureData.LabelSources.Count > 0 Then
                Dim symbolValues = captureData.LabelSources.SelectMany(Function(x) x.Symbols.[Select](Function(xx) xx.Value)).ToArray()

                File.WriteAllLines($"{captureDataFolder.FullName}\symbols.txt", symbolValues)
            End If

            i += 1
        End While

        If tags.Length > 0 Then
            File.WriteAllLines($"{mFolder.FullName}\tags.txt", tags)
        End If

        Return True
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub
End Class