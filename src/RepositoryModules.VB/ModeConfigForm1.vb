Imports Storex

Friend Class ModeConfigForm1

    Sub New()

        InitializeComponent()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs)

        If String.IsNullOrEmpty(PrimaryPrefixKeyTextBox.Text.TrimEnd()) Then
            ErrorProvider.SetError(PrimaryPrefixKeyTextBox, "入力してください")
        Else
            ErrorProvider.SetError(PrimaryPrefixKeyTextBox, Nothing)
        End If

        DialogResult = DialogResult.OK
    End Sub

    Public Shared Sub Configure(Mode As IMode)

        Dim PrimaryLabelSpec As FixedLengthSpec = Nothing
        Dim SecondaryLabelCriteria As SecondaryLabelCriteria = Nothing

        PrimaryLabelSpec = If(Mode.TryExtractProperty(FixedLengthSpec.PropertyKeyForPrimary, primaryLabelSpec), primaryLabelSpec, New FixedLengthSpec())
        SecondaryLabelCriteria = If(Mode.TryExtractProperty(SecondaryLabelCriteria.PropertyKey, SecondaryLabelCriteria), SecondaryLabelCriteria, New SecondaryLabelCriteria())

        Using form = New ModeConfigForm1()

            form.PrimaryPrefixKeyTextBox.Text = PrimaryLabelSpec.PrefixKey
            form.PrimaryItemStartUpDown.Value = PrimaryLabelSpec.ItemNumberStartIndex
            form.PrimaryItemLengthUpDown.Value = PrimaryLabelSpec.ItemNumberLength
            form.PrimarySerialStartUpDown.Value = PrimaryLabelSpec.SerialNumberStartIndex
            form.PrimarySerialLengthUpDown.Value = PrimaryLabelSpec.SerialNumberLength
            form.IsSecondaryLabelRequiredCheck.Checked = SecondaryLabelCriteria.IsRequired

            If form.ShowDialog() = DialogResult.OK Then

                PrimaryLabelSpec.PrefixKey = form.PrimaryPrefixKeyTextBox.Text
                PrimaryLabelSpec.ItemNumberStartIndex = Math.Round(form.PrimaryItemStartUpDown.Value)
                PrimaryLabelSpec.ItemNumberLength = Math.Round(form.PrimaryItemLengthUpDown.Value)
                PrimaryLabelSpec.SerialNumberStartIndex = Math.Round(form.PrimarySerialStartUpDown.Value)
                PrimaryLabelSpec.SerialNumberLength = Math.Round(form.PrimarySerialLengthUpDown.Value)
                SecondaryLabelCriteria.IsRequired = form.IsSecondaryLabelRequiredCheck.Checked

                Mode.ExtendedProperties(FixedLengthSpec.PropertyKeyForPrimary) = PrimaryLabelSpec
                Mode.ExtendedProperties(SecondaryLabelCriteria.PropertyKey) = SecondaryLabelCriteria
            End If
        End Using
    End Sub
End Class
