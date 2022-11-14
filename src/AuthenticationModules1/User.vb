Imports Storex

Friend Class User
    Implements IUser

    Public Property Id As String

    Public ReadOnly Property DisplayName As String Implements IUser.DisplayName

    Sub New(cId As String, name As String)

        If cId Is Nothing Then
            Throw New ArgumentNullException(NameOf(cId))
        End If

        If String.IsNullOrEmpty(name.TrimEnd) Then
            Throw New ArgumentNullException(NameOf(name))
        End If

        Id = cId
        DisplayName = name
    End Sub
End Class
