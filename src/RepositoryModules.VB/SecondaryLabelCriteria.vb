Public Class SecondaryLabelCriteria
    Public Shared ReadOnly Property PropertyKey As String = "15db8aaf-3d90-42e0-9d69-dffcf5a6adc0"

    Public Property AcceptableTypes As SecondaryLabelTypes = SecondaryLabelTypes.C3Label

    <Obsolete>
    Public Property IsRequired As Boolean

    Public Property NoLabelBehavior As SecondaryNoLabelBehavior

    Public Property ItemNumberEqualsToPrimaryOneBehavior As SecondaryLabelBehavior
    Public Property SpecifiedByConditionFileBehavior As SecondaryLabelBehavior

    <Obsolete>
    Public Property OtherLabelsBehavior As SecondaryLabelBehavior

    Private _otherNotSingleSymbolLabelsBehavior As SecondaryLabelBehavior
    Public Property OtherNotSingleSymbolLabelsBehavior As SecondaryLabelBehavior
        Get
            If OtherLabelsBehavior <> SecondaryLabelBehavior.Default Then
                _otherNotSingleSymbolLabelsBehavior = OtherLabelsBehavior
                OtherLabelsBehavior = SecondaryLabelBehavior.Default
            End If

            Return _otherNotSingleSymbolLabelsBehavior
        End Get
        Set(ByVal value As SecondaryLabelBehavior)
            _otherNotSingleSymbolLabelsBehavior = value
        End Set
    End Property
End Class
