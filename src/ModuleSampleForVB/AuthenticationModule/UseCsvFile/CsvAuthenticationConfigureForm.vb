Public Class CsvAuthenticationConfigureForm
    Sub New()
        InitializeComponent()

        FilePathTextBox.Text = My.Settings.CsvUserFilePath
        IsUsedNameRadioButton.Checked = My.Settings.IsUseCsvUserId <> True
        IsUsedIdRadioButton.Checked = My.Settings.IsUseCsvUserId = True
    End Sub

    Private Sub FileSelectorButton_Click(sender As Object, e As EventArgs) Handles FileSelectorButton.Click
        Using dialog As New OpenFileDialog

            dialog.Title = "ユーザー認証に使用するファイルを選択してください"
            dialog.FileName = My.Settings.CsvUserFilePath
            dialog.Filter = "CSVファイル|*.csv"

            If dialog.ShowDialog(Me) = DialogResult.OK Then
                FilePathTextBox.Text = dialog.FileName
            End If
        End Using
    End Sub


    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        My.Settings.CsvUserFilePath = FilePathTextBox.Text
        My.Settings.IsUseCsvUserId = IsUsedIdRadioButton.Checked
        My.Settings.Save()
    End Sub

    Private Sub AbandonButton_Click(sender As Object, e As EventArgs) Handles AbandonButton.Click
        Close()
    End Sub
End Class