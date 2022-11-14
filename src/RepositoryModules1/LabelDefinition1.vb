Imports Newtonsoft.Json
Imports Storex

Public Class LabelDefinition1

    Public Shared ReadOnly Property KeyForPrimary As String = "2026aedc-358d-41c5-a6a3-e03abe5ae5b3"

    Public Property PrefixKey As String

    Public Property ItemNumberStartIndex As Integer = 1

    Public Property ItemNumberLength As Integer = 1

    Public Property SerialNumberStartIndex As Integer = 1

    Public Property SerialNumberLength As Integer = 1

    Public Function TryGeneraLabel(Symbol As Symbol, ByRef Label As ILabel) As Boolean

        Dim MinLength As Integer
        MinLength = Math.Max(ItemNumberStartIndex + ItemNumberLength - 1, SerialNumberStartIndex + SerialNumberLength - 1)
        MinLength = Math.Max(MinLength, Len(PrefixKey))

        If Len(Symbol.Value) >= MinLength And (String.IsNullOrEmpty(PrefixKey) OrElse Symbol.Value.StartsWith(PrefixKey)) Then

            Label = New BasicLabel(Symbol) With {
                .ItemNumber = Symbol.Value.Substring(ItemNumberStartIndex - 1, ItemNumberLength).TrimEnd,
                .SerialNumber = Symbol.Value.Substring(SerialNumberStartIndex - 1, SerialNumberLength).TrimEnd
            }
            Return True
        End If

        Return False
    End Function

    Public Shared Function TryExtract(Mode As IMode, Name As String, Optional ByRef Definition As LabelDefinition1 = Nothing) As Boolean

        Dim objValue = Nothing

        objValue = If(Mode.ExtendedProperties.TryGetValue(Name, objValue), objValue, Nothing)

        If TypeOf objValue Is LabelDefinition1 Then

            Definition = objValue

            Return True

        ElseIf objValue IsNot Nothing Then

            Try

                Definition = JsonConvert.DeserializeObject(Of LabelDefinition1)(JsonConvert.SerializeObject(objValue))

                Return True

            Catch ex As JsonException

                Return False
            End Try
        Else

            Return False
        End If
    End Function
End Class
