Imports System.IO

Friend Class ConfigForm1
    Sub New()
        InitializeComponent()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs)
        ErrorProvider.SetError(FileButton, Nothing)

        ErrorProvider.SetError(FolderButton, Nothing)

        ErrorProvider.SetError(SecondaryConditionFileButton, Nothing)

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

    Private Sub FileButton_Click(sender As Object, e As EventArgs)
        FileDialog.FileName = FileTextBox.Text

        If FileDialog.ShowDialog() = DialogResult.OK Then
            FileTextBox.Text = FileDialog.FileName
        End If
    End Sub

    Private Sub FolderButton_Click(sender As Object, e As EventArgs)
        FolderDialog.SelectedPath = FileTextBox.Text

        If FolderDialog.ShowDialog() = DialogResult.OK Then
            FolderTextBox.Text = FolderDialog.SelectedPath
        End If
    End Sub

    Private Sub SecondaryConditionFileButton_Click(sender As Object, e As EventArgs)
        SecondaryConditionFileDialog.FileName = SecondaryConditionFileTextBox.Text

        If SecondaryConditionFileDialog.ShowDialog() = DialogResult.OK Then
            SecondaryConditionFileTextBox.Text = SecondaryConditionFileDialog.FileName
        End If
    End Sub

    Public Shared Sub Configure()
        Using Form = New ConfigForm1()
            Form.FileTextBox.Text = MySettings.Default.FilePath
            Form.FolderTextBox.Text = MySettings.Default.FolderPath
            Form.SecondaryConditionFileTextBox.Text = MySettings.Default.SecondaryConditionFilePath

            If Form.ShowDialog() = DialogResult.OK Then
                MySettings.Default.FilePath = Form.FileTextBox.Text
                MySettings.Default.FolderPath = Form.FolderTextBox.Text
                MySettings.Default.SecondaryConditionFilePath = Form.SecondaryConditionFileTextBox.Text
                MySettings.Default.Save()
            End If
        End Using
    End Sub
End Class
