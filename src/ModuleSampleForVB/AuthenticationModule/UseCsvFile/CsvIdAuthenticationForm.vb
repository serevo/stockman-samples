Imports System.IO
Imports System.Text

Public Class CsvIdAuthenticationForm
    Dim userInfos As CsvUserInfo()
    Dim selectedUser As CsvUserInfo

    Sub New()

        InitializeComponent()

        Dim filePath = My.Settings.CsvUserFilePath

        If String.IsNullOrEmpty(filePath) Then
            ErrorProvider.SetError(NumTextBox, "ファイルが設定されていません")
            OkButton.Enabled = False
        End If

        Dim text As String

        Try
            Using reader = New StreamReader(filePath, Encoding.GetEncoding("shift_jis"))
                text = reader.ReadToEnd
            End Using
        Catch ex As FileNotFoundException
            ErrorProvider.SetError(NumTextBox, "ファイルを開けませんでした")
            OkButton.Enabled = False
            Return
        End Try

        Dim rows = Split(text, Environment.NewLine)

        userInfos = rows _
            .Select(Function(x) Split(x, ",")) _
            .Where(Function(x) x.Length = 3) _
            .Select(Function(x) New CsvUserInfo(x(0), x(1), x(2))) _
            .ToArray()

    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        Dim selectedUsers = userInfos _
            .Where(Function(x) x.Id.ToString = NumTextBox.Text) _
            .ToArray()

        If selectedUsers.Length = 0 Then
            ErrorProvider.SetError(NumTextBox, "Idと一致するユーザーが見つかりませんでした")

        ElseIf selectedUsers.Length > 1 Then
            ErrorProvider.SetError(NumTextBox, "Idと一致するユーザーが複数存在し特定できません")

        Else
            selectedUser = selectedUsers(0)
            DialogResult = DialogResult.OK
        End If

    End Sub

    Public Shared Function SlectUser() As CsvUserInfo

        Using dialog = New CsvIdAuthenticationForm
            If dialog.ShowDialog(Form.ActiveForm) = DialogResult.OK Then
                SlectUser = dialog.selectedUser
            Else
                SlectUser = Nothing

            End If
        End Using
    End Function
End Class