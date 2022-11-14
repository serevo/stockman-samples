Imports System.ComponentModel.Composition
Imports System.Threading
Imports Storex

<Export(GetType(IAuthenticationModule))>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.Id), "faf8d1ba-dd95-48d8-8f2e-146c3ad81681")>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.DisplayName), "簡易認証 (氏名選択)")>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.Description), "CSVファイル (ID と 氏名) を使用します")>
Public Class UseCsvFileAuthenticationModule
    Implements IAuthenticationModule

    Public ReadOnly Property IsConfiguable As Boolean Implements IAuthenticationModule.IsConfiguable
        Get
            IsConfiguable = True
        End Get
    End Property

    Public Function ConfigureAsync() As Task Implements IAuthenticationModule.ConfigureAsync

        AuthenticationModuleHelper.PickUsersFileAndSaveToSetting()

        ConfigureAsync = Task.CompletedTask

    End Function

    Public Async Function AuthenticateAsync() As Task(Of IUser) Implements IAuthenticationModule.AuthenticateAsync

        Return Await AuthenticateAsync(cancellationToken:=CancellationToken.None)
    End Function

    Public Function AuthenticateAsync(cancellationToken As CancellationToken) As Task(Of IUser) Implements IAuthenticationModule.AuthenticateAsync

        Dim User As IUser = AuthenticationForm2.Authenticate

        Return Task.FromResult(User)

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub
End Class
