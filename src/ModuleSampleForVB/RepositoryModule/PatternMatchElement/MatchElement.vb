Imports System.Text.RegularExpressions
Imports Storex

Public Class MatchElement
    Implements IElement

    Shared ReadOnly ValidSymbolTypes() As SymbolType =
    {
       SymbolType.QrCode
    }

    Public ReadOnly Property PartNumber As String Implements IElement.PartNumber

    Public ReadOnly Property SerialNumber As String Implements IElement.SerialNumber

    Public ReadOnly Property SymbolType As SymbolType Implements IElement.SymbolType

    Public ReadOnly Property Quantity As Integer

    Public ReadOnly Property Symbols As Symbol()

    Sub New(partNum As String, serialNum As String, q As Integer, symbs() As Symbol)
        PartNumber = partNum
        SerialNumber = serialNum

        Quantity = q

        Dim types = symbs.Select(Function(x) x.Type).Distinct().ToArray()

        If types.Length <> 1 OrElse types.Any(Function(x) ValidSymbolTypes.Contains(x) <> True) Then
            Throw New ArgumentOutOfRangeException(NameOf(symbs))
        End If

        Symbols = symbs

        SymbolType = types(0)
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim element = TryCast(obj, MatchElement)
        Return element IsNot Nothing AndAlso
               PartNumber = element.PartNumber AndAlso
               SerialNumber = element.SerialNumber AndAlso
               SymbolType = element.SymbolType AndAlso
               Quantity = element.Quantity AndAlso
               EqualityComparer(Of Symbol()).Default.Equals(Symbols, element.Symbols)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (PartNumber, SerialNumber, SymbolType, Quantity, Symbols).GetHashCode()
    End Function

    Public Shared Function Extract(symbols() As Symbol) As MatchElement
        Dim partSerialPattern = "^(P[A-Z\d]{1,10})(S\d{10})$"
        Dim quantityPattern = "^Q(\d{1,5})$"

        Dim partSerialSymbols = symbols _
            .Where(Function(x) ValidSymbolTypes.Contains(x.Type)) _
            .Select(Function(x)
                        Dim match = Regex.Match(x.Value, partSerialPattern)
                        Dim result = match.Success

                        Return New With
                        {
                            .symbol = x,
                            result,
                            .part = If(result = True, match.Groups(1).Value, Nothing),
                            .serial = If(result = True, match.Groups(2).Value, Nothing)
                        }
                    End Function
                ) _
            .Where(Function(x) x.result) _
            .ToArray()

        Dim quantitySymbols = symbols _
            .Where(Function(x) ValidSymbolTypes.Contains(x.Type)) _
            .Select(Function(x)
                        Dim match = Regex.Match(x.Value, quantityPattern)
                        Dim result = match.Success

                        Return New With
                        {
                            .symbol = x,
                            result,
                            .quantity = If(result = True, Integer.Parse(match.Groups(1).Value), Nothing)
                        }
                    End Function
                ) _
            .Where(Function(x) x.result) _
            .ToArray()

        If partSerialSymbols.Length = 1 And quantitySymbols.Length = 1 Then
            Dim partSerialItem = partSerialSymbols(0)
            Dim quantityItem = quantitySymbols(0)

            Dim targetSymbols As Symbol() = {partSerialItem.symbol, quantityItem.symbol}
            If targetSymbols.Select(Function(x) x.Type).Distinct().Count = 1 Then
                Return New MatchElement(partSerialItem.part, partSerialItem.serial, quantityItem.quantity, targetSymbols)
            End If
        End If

        Return Nothing
    End Function
End Class
