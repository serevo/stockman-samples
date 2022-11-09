Imports Storex

Public Class CsvUserInfo
    Implements IUserInfo

    Public Property Id As String

    Public Property Pronunciation As String

    Public ReadOnly Property DisplayName As String Implements IUserInfo.DisplayName

    Sub New(cId As String, name As String, pronun As String)
        If cId Is Nothing Then
            Throw New ArgumentNullException(NameOf(cId))
        End If

        If String.IsNullOrEmpty(name.TrimEnd) Then
            Throw New ArgumentNullException(NameOf(name))
        End If

        If String.IsNullOrEmpty(pronun.TrimEnd) Then
            Throw New ArgumentNullException(NameOf(pronun))
        End If

        Id = cId
        DisplayName = name
        Pronunciation = pronun
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim info = TryCast(obj, CsvUserInfo)
        Return info IsNot Nothing AndAlso
               Id = info.Id AndAlso
               Pronunciation = info.Pronunciation AndAlso
               DisplayName = info.DisplayName
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (Id, Pronunciation, DisplayName).GetHashCode()
    End Function
End Class
