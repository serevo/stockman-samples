Imports System.Text.RegularExpressions
Imports Storex

Public Class OriginalQr
    Implements IElement

    ReadOnly ValidSymbolTypes() As SymbolType =
    {
       SymbolType.QrCode
    }

    Public ReadOnly Property PartNumber As String Implements IElement.PartNumber

    Public ReadOnly Property SerialNumber As String Implements IElement.SerialNumber

    Public ReadOnly Property SymbolType As SymbolType Implements IElement.SymbolType

    Public ReadOnly Property Quantity As Integer

    Public ReadOnly Property Symbol As Symbol

    Sub New(partNum As String, serialNum As String, q As Integer, sym As Symbol)
        PartNumber = partNum
        SerialNumber = serialNum

        Quantity = q

        If ValidSymbolTypes.Contains(sym.Type) <> True Then
            Throw New ArgumentOutOfRangeException(NameOf(sym))
        End If

        Symbol = sym

        SymbolType = sym.Type
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim qr = TryCast(obj, OriginalQr)
        Return qr IsNot Nothing AndAlso
               EqualityComparer(Of SymbolType()).Default.Equals(ValidSymbolTypes, qr.ValidSymbolTypes) AndAlso
               PartNumber = qr.PartNumber AndAlso
               SerialNumber = qr.SerialNumber AndAlso
               Quantity = qr.Quantity AndAlso
               EqualityComparer(Of Symbol).Default.Equals(Symbol, qr.Symbol) AndAlso
               SymbolType = qr.SymbolType
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (ValidSymbolTypes, PartNumber, SerialNumber, Quantity, Symbol, SymbolType).GetHashCode()
    End Function

    Public Shared Function TryParse(symbol As Symbol, ByRef key As OriginalQr) As Boolean
        Dim match = Regex.Match(symbol.Value, "^(P[A-Z\d]{1,10})(S\d{10})(Q\d{1,5})$")

        If match.Success Then

            Dim partNum = match.Groups(1).Value.TrimEnd()
            Dim serialNum = match.Groups(2).Value
            Dim quantity = Integer.Parse(match.Groups(3).Value)
            key = New OriginalQr(partNum, serialNum, quantity, symbol)

            Return True
        End If

        Return False

    End Function
End Class
