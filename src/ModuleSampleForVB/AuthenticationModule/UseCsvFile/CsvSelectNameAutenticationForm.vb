Imports System.IO
Imports System.Text
Imports Storex

Public Class CsvSelectNameAutenticationForm

    Private ReadOnly userInfos As CsvUserInfo()

    Dim selectedUser As CsvUserInfo

    Sub New()

        InitializeComponent()

        Dim filePath = My.Settings.CsvUserFilePath

        If String.IsNullOrEmpty(filePath) Then
            ErrorProvider.SetError(UserInfoComboBox, "ファイルが設定されていません")
            UserInfoComboBox.Enabled = OkButton.Enabled = False
        End If

        Dim text As String

        Try
            Using reader = New StreamReader(filePath, Encoding.GetEncoding("shift_jis"))
                text = reader.ReadToEnd
            End Using
        Catch ex As FileNotFoundException
            ErrorProvider.SetError(UserInfoComboBox, "ファイルを開けませんでした")
            UserInfoComboBox.Enabled = OkButton.Enabled = False
            Return
        End Try

        With CsvFilterControl.CsvFilterListView
            .DisplayMemberPath = NameOf(CsvFilterListItem.Display)

            AddHandler .SelectionChanged, AddressOf CsvFilterListView_SelectionChanged

            .ItemsSource =
                {
                    New CsvFilterListItem With {.Display = "あ行", .FilterType = CsvUseFilterType.AColumn, .StartWithChar = "あ"},
                    New CsvFilterListItem With {.Display = "か行", .FilterType = CsvUseFilterType.KaColumn, .StartWithChar = "か"},
                    New CsvFilterListItem With {.Display = "さ行", .FilterType = CsvUseFilterType.SaColumn, .StartWithChar = "さ"},
                    New CsvFilterListItem With {.Display = "た行", .FilterType = CsvUseFilterType.TaColumn, .StartWithChar = "た"},
                    New CsvFilterListItem With {.Display = "な行", .FilterType = CsvUseFilterType.NaColumn, .StartWithChar = "な"},
                    New CsvFilterListItem With {.Display = "は行", .FilterType = CsvUseFilterType.HaColumn, .StartWithChar = "は"},
                    New CsvFilterListItem With {.Display = "ま行", .FilterType = CsvUseFilterType.MaColumn, .StartWithChar = "ま"},
                    New CsvFilterListItem With {.Display = "や行", .FilterType = CsvUseFilterType.YaColumn, .StartWithChar = "や"},
                    New CsvFilterListItem With {.Display = "ら行", .FilterType = CsvUseFilterType.RaColumn, .StartWithChar = "ら"},
                    New CsvFilterListItem With {.Display = "わ行", .FilterType = CsvUseFilterType.WaColumn, .StartWithChar = "わ"},
                    New CsvFilterListItem With {.Display = "全て", .FilterType = CsvUseFilterType.None},
                    New CsvFilterListItem With {.Display = "頻使用", .FilterType = CsvUseFilterType.Frequently}
                }

            .SelectedValue = My.Settings.CsvUseFilterType
        End With


        Dim rows = Split(text, Environment.NewLine)

        userInfos = rows _
            .Select(Function(x) Split(x, ",")) _
            .Where(Function(x) x.Length = 3) _
            .Select(Function(x) New CsvUserInfo(x(0), x(1), x(2))) _
            .ToArray()

        UserInfoComboBox.DisplayMember = NameOf(CsvUserInfo.DisplayName)
        UserInfoComboBox.DataSource = userInfos
        UserInfoComboBox.SelectedIndex = -1
    End Sub

    Private Sub CsvFilterListView_SelectionChanged(sender As Object, e As Windows.Controls.SelectionChangedEventArgs)
        Dim selectedItem = CType(CsvFilterControl.CsvFilterListView.SelectedItem, CsvFilterListItem)

        If selectedItem.FilterType = CsvUseFilterType.Frequently Then
            UserInfoComboBox.DataSource = userInfos _
                .Select(Function(x) New With
                {
                    .info = x,
                    .count = If(My.Settings.FrequentlyUsers.ContainsKey(x), My.Settings.FrequentlyUsers(x), 0)
                }) _
                .Where(Function(x) x.count <> 0) _
                .OrderByDescending(Function(x) x.count) _
                .Take(10) _
                .ToArray()

        ElseIf selectedItem.FilterType = CsvUseFilterType.None Then
            UserInfoComboBox.DataSource = userInfos

        Else

            UserInfoComboBox.DataSource = userInfos _
               .Where(Function(x) x.Pronunciation.StartsWith(selectedItem.StartWithChar)) _
               .ToArray()
        End If

            UserInfoComboBox.SelectedIndex = -1
    End Sub

    Private Sub UserInfoComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles UserInfoComboBox.SelectionChangeCommitted
        If UserInfoComboBox.SelectedIndex = -1 Then
            ErrorProvider.SetError(UserInfoComboBox, "ユーザーが選択されていません")
            OkButton.Enabled = False
        Else
            ErrorProvider.SetError(UserInfoComboBox, Nothing)
            OkButton.Enabled = True
        End If
    End Sub

    Public Shared Function SlectUser() As CsvUserInfo

        Using dialog = New CsvSelectNameAutenticationForm
            If dialog.ShowDialog(Form.ActiveForm) = DialogResult.OK Then
                SlectUser = CType(dialog.UserInfoComboBox.SelectedItem, CsvUserInfo)

            Else
                SlectUser = Nothing

            End If
        End Using
    End Function
End Class