Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json
Imports Storex

Public Module ModeExtensions

    <Extension>
    Public Function TryExtractProperty(Of T As Class)(Mode As IMode, Key As String, <Out> ByRef Value As T) As Boolean

        Dim objValue As Object = Nothing

        If Mode.ExtendedProperties.TryGetValue(Key, objValue) AndAlso TypeOf objValue Is T Then

            Value = objValue

            Return True

        ElseIf objValue IsNot Nothing Then

            Try
                Value = JsonConvert.DeserializeObject(Of T)(JsonConvert.SerializeObject(objValue))

                Return True

            Catch Ex As JsonException

                Value = Nothing

                Return False
            End Try
        Else

            Value = Nothing

            Return False
        End If
    End Function
End Module
