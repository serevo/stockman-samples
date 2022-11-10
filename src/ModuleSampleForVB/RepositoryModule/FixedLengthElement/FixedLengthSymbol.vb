Imports Storex

Public Class FixedLengthSymbol
    Inherits Symbol

    Protected Overrides ReadOnly Property PartNumber As String

    Protected Overrides ReadOnly Property SerialNumber As String

    Shared ReadOnly ValidSymbolTypes() As SymbolType =
    {
       SymbolType.QrCode
    }

    Private Sub New(partNum As String, serialNum As String, type As SymbolType, value As String)
        MyBase.New(type, value)

        If String.IsNullOrEmpty(partNum) Then
            Throw New ArgumentException($"'{NameOf(partNum)}' を NULL または空にすることはできません。", NameOf(partNum))
        End If

        If String.IsNullOrEmpty(serialNum) Then
            Throw New ArgumentException($"'{NameOf(serialNum)}' を NULL または空にすることはできません。", NameOf(serialNum))
        End If

        PartNumber = partNum
        SerialNumber = serialNum
    End Sub

    Public Shared Function TryParse(symbol As Symbol, setting As FixedLengthRepositoryModeSetting, ByRef fixedLengthSymbol As FixedLengthSymbol) As Boolean
        If ValidSymbolTypes.Contains(symbol.Type) And symbol.Value.Length = setting.PrimaryValueLength And symbol.Value.StartsWith(setting.PrimaryStartWithFormat) Then
            Dim part = symbol.Value.Substring(setting.PartStartIndex - 1, setting.PartLength)
            Dim serial = symbol.Value.Substring(setting.SerialStartIndex - 1, setting.SerialLength)

            fixedLengthSymbol = New FixedLengthSymbol(part, serial, symbol.Type, symbol.Value)
            Return True
        End If

        Return False
    End Function
End Class
