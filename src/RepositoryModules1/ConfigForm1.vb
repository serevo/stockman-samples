
Imports System.IO

Friend Class ConfigForm1

    Sub New()

        InitializeComponent()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        ErrorProvider.SetError(FileButton, Nothing)

        ErrorProvider.SetError(FolderButton, Nothing)

        If Not File.Exists(FileTextBox.Text) Then

            ErrorProvider.SetError(FileButton, "ファイルを選択してください。")

            Return
        End If

        If Not Directory.Exists(FolderTextBox.Text) Then

            ErrorProvider.SetError(FolderButton, "フォルダを選択してください。")

            Return
        End If

        DialogResult = DialogResult.OK
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click

        FileDialog.FileName = FileTextBox.Text

        If FileDialog.ShowDialog() = DialogResult.OK Then

            FileTextBox.Text = FileDialog.FileName
        End If
    End Sub

    Private Sub FolderButton_Click(sender As Object, e As EventArgs) Handles FolderButton.Click

        FolderDialog.SelectedPath = FileTextBox.Text

        If FolderDialog.ShowDialog() = DialogResult.OK Then

            FolderTextBox.Text = FolderDialog.SelectedPath
        End If
    End Sub

    Public Shared Sub Configure()

        Using Form = New ConfigForm1()

            Form.FileTextBox.Text = My.Settings.FilePath
            Form.FolderTextBox.Text = My.Settings.FolderPath

            If Form.ShowDialog() = DialogResult.OK Then

                My.Settings.FilePath = Form.FileTextBox.Text
                My.Settings.FolderPath = Form.FolderTextBox.Text
                My.Settings.Save()
            End If
        End Using
    End Sub
End Class