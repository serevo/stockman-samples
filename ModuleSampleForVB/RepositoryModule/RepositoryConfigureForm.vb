Public Class RepositoryConfigureForm
    Sub New()
        InitializeComponent()

        FolderPathTextBox.Text = My.Settings.RepositoryFolderPath
        MasterFilePathTextBox.Text = My.Settings.SecondaryMasterFilePath

    End Sub

    Private Sub FolderSelectorButton_Click(sender As Object, e As EventArgs) Handles FolderSelectorButton.Click
        Dim dialog As New FolderBrowserDialog

        dialog.Description = "保存先フォルダを選択してください"
        dialog.SelectedPath = FolderPathTextBox.Text

        If dialog.ShowDialog(Me) = DialogResult.OK Then
            FolderPathTextBox.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub FileSelectorButton_Click(sender As Object, e As EventArgs) Handles FileSelectorButton.Click

    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click

        Dim isFolderNothing = String.IsNullOrEmpty(FolderPathTextBox.Text.TrimEnd)
        Dim isFileNothing = String.IsNullOrEmpty(MasterFilePathTextBox.Text.TrimEnd)

        If isFolderNothing Or isFileNothing Then
            If isFolderNothing Then
                ErrorProvider.SetError(FolderPathTextBox, "選択してください")
            End If

            If isFileNothing Then
                ErrorProvider.SetError(MasterFilePathTextBox, "選択してください")
            End If

            Return
        Else
            ErrorProvider.Clear()
        End If

        My.Settings.RepositoryFolderPath = FolderPathTextBox.Text
        My.Settings.SecondaryMasterFilePath = MasterFilePathTextBox.Text
        My.Settings.Save()
    End Sub

End Class