Imports Storex

Public Class FixedLengthSpec

    Public Shared ReadOnly Property PropertyKeyForPrimary As String = "2026aedc-358d-41c5-a6a3-e03abe5ae5b3"

    Public Property PrefixKey As String

    Public Property ItemNumberStartIndex As Integer = 1

    Public Property ItemNumberLength As Integer = 1

    Public Property SerialNumberStartIndex As Integer = 1

    Public Property SerialNumberLength As Integer = 1

    Public Function TryGenerateLabel(Symbol As Symbol, ByRef Label As ILabel) As Boolean
        Dim minLength As Integer
        minLength = Math.Max(ItemNumberStartIndex + ItemNumberLength - 1, SerialNumberStartIndex + SerialNumberLength - 1)
        minLength = Math.Max(minLength, If(PrefixKey?.Length, 0))

        If Symbol.Value.Length >= minLength And (String.IsNullOrEmpty(PrefixKey) OrElse Symbol.Value.StartsWith(PrefixKey, StringComparison.CurrentCultureIgnoreCase)) Then

            Label = New BasicLabel(Symbol) With
            {
                .ItemNumber = Symbol.Value.Substring(ItemNumberStartIndex - 1, ItemNumberLength).TrimEnd(),
                .SerialNumber = Symbol.Value.Substring(SerialNumberStartIndex - 1, SerialNumberLength).TrimEnd()
            }

            Return True
        Else

            Label = Nothing

            Return False
        End If
    End Function
End Class
