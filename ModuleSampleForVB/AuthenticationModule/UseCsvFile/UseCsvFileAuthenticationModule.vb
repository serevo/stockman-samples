Imports System.ComponentModel.Composition
Imports System.Threading
Imports Storex

<Export(GetType(IAuthenticationModule))>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.Id), "FCB29577-7E5B-4B0C-A514-B8E636AAF13D")>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.DisplayName), "簡易認証")>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.Description), "ID, 表示名, 読みで構成されたファイル (CSV) を使用")>
Public Class UseCsvFileAuthenticationModule
    Implements IAuthenticationModule

    Public ReadOnly Property IsConfiguable As Boolean Implements IAuthenticationModule.IsConfiguable
        Get
            IsConfiguable = True
        End Get
    End Property

    Public Function ConfigureAsync() As Task Implements IAuthenticationModule.ConfigureAsync
        Dim dialog As New CsvAuthenticationConfigureForm
        dialog.Show(Form.ActiveForm)

        ConfigureAsync = Task.CompletedTask
    End Function

    Public Async Function AuthenticateAsync() As Task(Of IUserInfo) Implements IAuthenticationModule.AuthenticateAsync
        Return Await AuthenticateAsync(cancellationToken:=CancellationToken.None)
    End Function

    Public Async Function AuthenticateAsync(cancellationToken As CancellationToken) As Task(Of IUserInfo) Implements IAuthenticationModule.AuthenticateAsync
        Dim userInfo As CsvUserInfo

        If My.Settings.IsUseCsvUserId Then
            userInfo = CsvIdAuthenticationForm.SlectUser
        Else
            userInfo = CsvSelectNameAutenticationForm.SlectUser
        End If

        Await Task.CompletedTask
        Return userInfo
    End Function


    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub
End Class
