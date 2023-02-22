Friend Class SecondaryCondition
    Public ReadOnly Property PrimaryLabelItemNumber As String

    Public ReadOnly Property SecondaryItemNumber As String

    Public Sub New(primaryLabelItemNumber As String, secondaryItemNumber As String)
        If String.IsNullOrWhiteSpace(primaryLabelItemNumber) Then Throw New ArgumentException($"'{NameOf(primaryLabelItemNumber)}' を null または空白にすることはできません。", NameOf(primaryLabelItemNumber))
        If String.IsNullOrWhiteSpace(secondaryItemNumber) Then Throw New ArgumentException($"'{NameOf(secondaryItemNumber)}' を null または空白にすることはできません。", NameOf(secondaryItemNumber))

        Me.PrimaryLabelItemNumber = primaryLabelItemNumber
        Me.SecondaryItemNumber = secondaryItemNumber
    End Sub
End Class
