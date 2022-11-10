Public Class RepositoryConfigureForm
    Sub New()
        InitializeComponent()

        FolderPathTextBox.Text = My.RepositorySettings.Default.RepositoryFolderPath
        MasterFilePathTextBox.Text = My.RepositorySettings.Default.SecondaryMasterFilePath

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
        Using dialog As New OpenFileDialog

            dialog.Title = "セカンダリの部材紐付けマスタに使用するファイルを選択してください"
            dialog.FileName = MasterFilePathTextBox.Text
            dialog.Filter = "CSVファイル|*.csv"

            If dialog.ShowDialog(Me) = DialogResult.OK Then
                MasterFilePathTextBox.Text = dialog.FileName
            End If
        End Using
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click

        If String.IsNullOrEmpty(FolderPathTextBox.Text.TrimEnd) Then
            ErrorProvider.SetError(FolderPathTextBox, "選択してください")
            Return
        Else
            ErrorProvider.Clear()
        End If

        My.RepositorySettings.Default.RepositoryFolderPath = FolderPathTextBox.Text
        My.RepositorySettings.Default.SecondaryMasterFilePath = MasterFilePathTextBox.Text
        My.RepositorySettings.Default.Save()
    End Sub

End Class