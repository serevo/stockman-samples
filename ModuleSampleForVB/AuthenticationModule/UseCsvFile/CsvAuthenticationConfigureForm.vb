Public Class CsvAuthenticationConfigureForm
    Sub New()
        InitializeComponent()

        FilePathTextBox.Text = My.Settings.CsvUserFilePath
        IsUsedNameRadioButton.Checked = My.Settings.IsUseCsvUserId <> True
        IsUsedIdRadioButton.Checked = My.Settings.IsUseCsvUserId = True
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click

    End Sub

    Private Sub AbandonButton_Click(sender As Object, e As EventArgs) Handles AbandonButton.Click

    End Sub

    Private Sub FileSelectorButton_Click(sender As Object, e As EventArgs) Handles FileSelectorButton.Click

    End Sub
End Class