﻿Imports System.IO
Imports System.Text

Friend Class AuthenticationModuleHelper

    Public Shared Sub PickUsersFileAndSaveToSetting()

        Using Dialog As New OpenFileDialog

            Dialog.Title = "ユーザーリストファイルを選択してください"
            Dialog.FileName = My.Settings.UsersFilePath
            Dialog.Filter = "CSVファイル|*.csv"

            If Dialog.ShowDialog() = DialogResult.OK Then

                My.Settings.UsersFilePath = Dialog.FileName
                My.Settings.Save()
            End If
        End Using
    End Sub

    Public Shared Function ReadUsersFile() As User()

        Dim FilePath = My.Settings.UsersFilePath

        If String.IsNullOrEmpty(FilePath) Then Return Nothing

        Dim Text As String = File.ReadAllText(FilePath, Encoding.GetEncoding("shift_jis"))

        Return Split(Text, Environment.NewLine) _
            .Select(Function(x) Split(x, ",")) _
            .Where(Function(x) x.Length = 2) _
            .Select(Function(x) New User(x(0), x(1))) _
            .ToArray()
    End Function
End Class
