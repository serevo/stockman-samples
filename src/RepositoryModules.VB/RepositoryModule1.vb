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

    Private ConditionDictionary As IReadOnlyDictionary(Of String, IEnumerable(Of String))

    Public ReadOnly Property IsConfiguable As Boolean = True Implements IModule.IsConfiguable

    Public ReadOnly Property IsModeConfiguable As Boolean = True Implements IRepositoryModule.CanConfigureMode

    Public Function ConfigureAsync(cancellationToken As CancellationToken) As Task Implements IModule.ConfigureAsync

        ConfigForm1.Configure()

        Return Task.CompletedTask
    End Function

    Public Function ConfigureModeAsync(Mode As IMode, cancellationToken As CancellationToken) As Task Implements IRepositoryModule.ConfigureModeAsync

        ModeConfigForm1.Configure(Mode)

        Return Task.CompletedTask
    End Function

    Public Function PrepareAsync(Mode As IMode, UserInfo As IUser, cancellationToken As CancellationToken) As Task(Of Boolean) _
        Implements IRepositoryModule.PrepareAsync

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

        ConditionDictionary = ReadSecondaryConditionsFile()

        CurrentMode = Mode
        CurrentUser = UserInfo

        Return Task.FromResult(True)
    End Function

    Public Async Function FindPrimaryLabelAsync(Sources() As ILabelSource, cancellationToken As CancellationToken) As Task(Of ILabel) _
        Implements IRepositoryModule.FindPrimaryLabelAsync

        Await Task.CompletedTask

        Dim MatchSymbols = Sources _
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

    Public Function FindSecondaryLabelsAsync(Primary As ILabel, Sources As ILabelSource(), cancellationToken As CancellationToken) As Task(Of ILabel()) _
        Implements IRepositoryModule.FindSecondaryLabelsAsync

        Dim Labels = New List(Of ILabel)()
        Dim Strings As IEnumerable(Of String) = Nothing

        Dim ValidConditionValues = If(SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny _
            AndAlso ConditionDictionary.TryGetValue(Primary.ItemNumber, Strings), Strings, Array.Empty(Of String)())

        Dim C3Labels = Sources _
            .Where(Function(__) (SecondaryLabelCriteria.AcceptableTypes And SecondaryLabelTypes.C3Label) = SecondaryLabelTypes.C3Label) _
            .OfType(Of C3Label)() _
            .Where(Function(o) _
                SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior <> SecondaryLabelBehavior.Deny _
                    AndAlso EqualsIgnoreCase(o.PartNumber, Primary.ItemNumber) _
                Or SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny _
                    AndAlso ValidConditionValues.Any(Function(p) EqualsIgnoreCase(o.PartNumber, p)) _
                Or SecondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior <> SecondaryLabelBehavior.Deny _
                    AndAlso Not EqualsIgnoreCase(o.PartNumber, Primary.ItemNumber) And Not ValidConditionValues.Any(Function(p) EqualsIgnoreCase(o.PartNumber, p))
                ) _
            .ToList()

        Labels.AddRange(C3Labels)

        Dim Label As ILabel = Nothing

        Dim SingleSymbolLabels = Sources _
            .Where(Function(__) (SecondaryLabelCriteria.AcceptableTypes And SecondaryLabelTypes.SingleSymbol) = SecondaryLabelTypes.SingleSymbol) _
            .OfType(Of Symbol)() _
            .Where(Function(x) Not PrimaryLabelSpec.TryGenerateLabel(x, Label)) _
            .Select(Function(o) New BasicLabel(o) With {.ItemNumber = o.Value}) _
            .Where(Function(o) _
                SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior <> SecondaryLabelBehavior.Deny _
                    And EqualsIgnoreCase(o.ItemNumber, Primary.ItemNumber) _
                Or SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny _
                    And ValidConditionValues.Any(Function(p) EqualsIgnoreCase(o.ItemNumber, p))
                ) _
            .ToList()

        Labels.AddRange(SingleSymbolLabels)

        Return Task.FromResult(Labels.ToArray())
    End Function

    Public Async Function RegisterAsync(Primary As ILabel, Secondary As ILabel, CaptureDatas As CaptureData(), Tags As String(), cancellationToken As CancellationToken) As Task(Of Boolean) _
        Implements IRepositoryModule.RegisterAsync

        If Not File.Exists(MySettings.Default.FilePath) Then
            Throw New RepositoryModuleException("概要データ ファイルが存在しません。")
        End If

        If Not Directory.Exists(MySettings.Default.FolderPath) Then
            Throw New RepositoryModuleException("詳細データ フォルダが存在しません。")
        End If

        Dim Strings As IEnumerable(Of String) = Nothing
        Dim ValidConditionValues = If(SecondaryLabelCriteria.SpecifiedByConditionFileBehavior <> SecondaryLabelBehavior.Deny _
            AndAlso ConditionDictionary.TryGetValue(Primary.ItemNumber, Strings), Strings, Array.Empty(Of String)())

        If Secondary Is Nothing Then

            If SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.Warnning _
                AndAlso Not ShowAlert("セカンダリ ラベルが必要です。無視して登録しますか。") Then

                Return False

            ElseIf SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.Deny Then

                ShowError("セカンダリ ラベルが必要です。")
                Return False

            ElseIf SecondaryLabelCriteria.NoLabelBehavior <> SecondaryNoLabelBehavior.Default Then

                Dim hasItemNumberEqualsToPrimary = Tags.Any(Function(o) EqualsIgnoreCase(o, Primary.ItemNumber))
                Dim hasSpecifiedByConditionFile = Tags.Any(Function(o) ValidConditionValues.Any(Function(p) EqualsIgnoreCase(p, Primary.ItemNumber)))

                If SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.WarningWhenTagNotMatched _
                    AndAlso Not hasItemNumberEqualsToPrimary _
                    AndAlso Not hasSpecifiedByConditionFile _
                    AndAlso Not ShowAlert("セカンダリ ラベル、又は対応するタグが必要です。無視して登録しますか。") Then

                    Return False
                ElseIf SecondaryLabelCriteria.NoLabelBehavior = SecondaryNoLabelBehavior.DenyWhenTagNotMatched _
                    AndAlso Not hasItemNumberEqualsToPrimary _
                    AndAlso Not hasSpecifiedByConditionFile Then

                    ShowError("セカンダリ ラベル、又は対応するタグが必要です。")
                    Return False
                ElseIf SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = SecondaryLabelBehavior.Warnning _
                    AndAlso hasItemNumberEqualsToPrimary _
                    AndAlso Not ShowAlert("プライマリラベルと同じ品番がタグに含まれています。登録しますか。") Then

                    Return False
                ElseIf SecondaryLabelCriteria.SpecifiedByConditionFileBehavior = SecondaryLabelBehavior.Warnning _
                    AndAlso hasSpecifiedByConditionFile _
                    AndAlso Not ShowAlert("対応表で指定されている品番がタグに含まれています。登録しますか。") Then

                    Return False
                End If
            End If
        ElseIf SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = SecondaryLabelBehavior.Warnning _
            AndAlso EqualsIgnoreCase(Primary.ItemNumber, Secondary.ItemNumber) _
            AndAlso Not ShowAlert("指定された セカンダリ ラベルは、プライマリラベルと同じ品番です。登録を続行しますか。") Then

            Return False
        ElseIf SecondaryLabelCriteria.SpecifiedByConditionFileBehavior = SecondaryLabelBehavior.Warnning _
            AndAlso ValidConditionValues.Any(Function(o) EqualsIgnoreCase(o, Secondary.ItemNumber)) _
            AndAlso Not ShowAlert("指定された セカンダリ ラベルは、プライマリ ラベルとは異なり対応表と同じ品番です。登録を続行しますか。") Then

            Return False
        ElseIf SecondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior = SecondaryLabelBehavior.Warnning _
            AndAlso Not EqualsIgnoreCase(Primary.ItemNumber, Secondary.ItemNumber) _
            AndAlso Not ValidConditionValues.Any(Function(o) EqualsIgnoreCase(o, Secondary.ItemNumber)) _
            AndAlso Not ShowAlert("指定された セカンダリ ラベルは、プライマリラベルや対応表と異なる品番です。登録しますか。") Then

            Return False
        End If

        Dim Timestamp As Date = Date.Now

        Dim MyFile = New FileInfo(MySettings.Default.FilePath)

        Using SW = New StreamWriter(MyFile.FullName, True, TextEncoding)

            If MyFile.Length = 0 Then

                Await SW.WriteLineAsync(String.Join(vbTab, New String() {
                    "PrimaryPartNumber",
                    "PrimarySerialNumber",
                    "SecondaryPartNumber",
                    "SecondarySerialNumber",
                    "ModeId",
                    "UserName",
                    "Timestamp"
                    }))
            End If

            Await SW.WriteLineAsync(String.Join(vbTab, New String() {
                Primary.ItemNumber,
                Primary.SerialNumber,
                Secondary?.ItemNumber,
                Secondary?.SerialNumber,
                CurrentMode.Id.ToString(),
                CurrentUser?.DisplayName,
                $"{Timestamp:yyyy/MM/dd HH:mm:ss.fff}"
                }))
        End Using

        Dim MyFolder = New DirectoryInfo(MySettings.Default.FolderPath)

        MyFolder = MyFolder.CreateSubdirectory($"{Timestamp:yyyy-MM-dd HH-mm-ss.fff}")

        For i = 1 To CaptureDatas.Count

            Dim CaptureData As CaptureData = CaptureDatas(i - 1)

            Dim CaptureDataFolder = MyFolder.CreateSubdirectory($"catpure#{i}")

            WriteImage($"{CaptureDataFolder.FullName}\original.jpg", CaptureData.OriginalImage.ToArray())

            If CaptureData.AdornedImage IsNot Nothing Then

                WriteImage($"{CaptureDataFolder.FullName}\adorned.jpeg", CaptureData.AdornedImage.ToArray())
            End If

            If CaptureData.LabelSources.Count > 0 Then

                Dim SymbolValues() As String = CaptureData.LabelSources.SelectMany(Function(x) x.Symbols.Select(Function(xx) xx.Value)).ToArray()

                File.WriteAllLines($"{CaptureDataFolder.FullName}\symbols.txt", SymbolValues)
            End If
        Next

        If Tags.Length > 0 Then

            File.WriteAllLines($"{MyFolder.FullName}\tags.txt", Tags)
        End If

        Return True
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub
End Class