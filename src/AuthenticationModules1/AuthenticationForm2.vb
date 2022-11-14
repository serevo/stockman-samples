
Friend Class AuthenticationForm2

    Private ReadOnly _Users As User()

    Public ReadOnly Property SelectedUser() As User
        Get
            Return CType(UserInfoComboBox.SelectedItem, User)
        End Get
    End Property

    Sub New()

        InitializeComponent()

        _Users = AuthenticationModuleHelper.ReadUsersFile()

        UserInfoComboBox.DisplayMember = NameOf(User.DisplayName)
        UserInfoComboBox.DataSource = _Users
        UserInfoComboBox.SelectedIndex = -1
    End Sub

    Private Sub UserInfoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserInfoComboBox.SelectedIndexChanged

        OkButton.Enabled = UserInfoComboBox.SelectedIndex >= 0
    End Sub

    Private Sub UserInfoComboBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles UserInfoComboBox.MouseDoubleClick

        OkButton.PerformClick()
    End Sub

    Public Shared Function Authenticate() As User

        Using Dialog = New AuthenticationForm2

            If Dialog.ShowDialog(Form.ActiveForm) = DialogResult.OK Then

                Return Dialog.SelectedUser
            Else

                Return Nothing
            End If
        End Using
    End Function
End Class