Imports System.IO
Imports System.Text
Imports System.Windows.Controls
Imports Storex

Public Class SecondaryMasterData
    Public ReadOnly Property PartNumber As String

    Public ReadOnly Property ValidData As String

    Sub New(part As String, validVal As String)
        If String.IsNullOrEmpty(part.TrimEnd) Then
            Throw New ArgumentNullException(NameOf(part))
        End If

        If String.IsNullOrEmpty(validVal.TrimEnd) Then
            Throw New ArgumentNullException(NameOf(validVal))
        End If

        PartNumber = part
        ValidData = validVal
    End Sub

    Public Shared Function LoadSecondaryMasters() As SecondaryMasterData()
        Dim filePath = My.Settings.SecondaryMasterFilePath

        If String.IsNullOrEmpty(filePath) Then
            Return Array.Empty(Of SecondaryMasterData)
        End If

        Dim text As String

        Try
            Using reader = New StreamReader(filePath, Encoding.GetEncoding("shift_jis"))
                text = reader.ReadToEnd
            End Using
        Catch ex As FileNotFoundException
            Throw New ModuleException("設定されたセカンダリマスターファイルを開けませんでした")
        End Try

        Dim rows = Split(text, Environment.NewLine)

        Return rows _
            .Select(Function(x) Split(x, ",")) _
            .Where(Function(x) x.Length = 2) _
            .Select(Function(x) New SecondaryMasterData(x(0), x(1))) _
            .ToArray()
    End Function
End Class
