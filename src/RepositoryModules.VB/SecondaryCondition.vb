Friend Class SecondaryCondition
    Public ReadOnly Property PrimaryLabelItemNumber As String

    Public ReadOnly Property SecondaryItemNumber As String

    Public Sub New(PrimaryLabelItemNumber As String, SecondaryItemNumber As String)

        If String.IsNullOrWhiteSpace(PrimaryLabelItemNumber) Then

            Throw New ArgumentException($"'{NameOf(PrimaryLabelItemNumber)}' を null または空白にすることはできません。", NameOf(PrimaryLabelItemNumber))
        End If

        If String.IsNullOrWhiteSpace(SecondaryItemNumber) Then

            Throw New ArgumentException($"'{NameOf(SecondaryItemNumber)}' を null または空白にすることはできません。", NameOf(SecondaryItemNumber))
        End If

        Me.PrimaryLabelItemNumber = PrimaryLabelItemNumber
        Me.SecondaryItemNumber = SecondaryItemNumber
    End Sub
End Class
