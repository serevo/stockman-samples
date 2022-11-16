
Friend Class AuthenticationForm1

    ReadOnly _Users As User()

    Property SelectedUser As User

    Sub New()

        InitializeComponent()

        _Users = AuthenticationModuleHelper.ReadUsersFile()

        If _Users Is Nothing Then

            ErrorProvider.SetError(NumTextBox, "ユーザーリストファイルが正しく設定されていないかまたはファイルを読み取れません。")

            OkButton.Enabled = False
        End If
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        Dim SelectedUsers = _Users _
            .Where(Function(x) x.Id = NumTextBox.Text) _
            .ToArray()

        If SelectedUsers.Length = 0 Then

            ErrorProvider.SetError(NumTextBox, "Idと一致するユーザーが見つかりませんでした")

        ElseIf SelectedUsers.Length > 1 Then

            ErrorProvider.SetError(NumTextBox, "Idと一致するユーザーが複数存在し特定できません")

        Else

            SelectedUser = SelectedUsers(0)

            DialogResult = DialogResult.OK
        End If

    End Sub

    Public Shared Function Authenticate() As User

        Using Dialog = New AuthenticationForm1

            If Dialog.ShowDialog(Form.ActiveForm) = DialogResult.OK Then

                Return Dialog.SelectedUser
            Else

                Return Nothing
            End If
        End Using
    End Function
End Class