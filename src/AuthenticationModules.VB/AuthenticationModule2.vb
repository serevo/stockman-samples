Imports System.Threading
Imports Storex

<AuthenticationModuleExport("faf8d1ba-dd95-48d8-8f2e-146c3ad81681", "簡易認証 (氏名選択)", Description:="CSVファイル (ID と 氏名) を使用します")>
Public Class UseCsvFileAuthenticationModule
    Implements IAuthenticationModule

    Public ReadOnly Property IsConfiguable As Boolean Implements IAuthenticationModule.IsConfiguable
        Get
            IsConfiguable = True
        End Get
    End Property

    Public Function ConfigureAsync(cancellationToken As CancellationToken) As Task Implements IAuthenticationModule.ConfigureAsync

        AuthenticationModuleHelper.PickUsersFileAndSaveToSetting()

        ConfigureAsync = Task.CompletedTask

    End Function

    Public Function AuthenticateAsync(cancellationToken As CancellationToken) As Task(Of IUser) Implements IAuthenticationModule.AuthenticateAsync

        Dim User As IUser = AuthenticationForm2.Authenticate

        Return Task.FromResult(User)

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub
End Class
