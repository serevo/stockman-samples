Imports Storex

Friend Class ModeConfigForm1

    Sub New()

        InitializeComponent()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        If String.IsNullOrEmpty(PrimaryPrefixKeyTextBox.Text.TrimEnd) Then

            ErrorProvider.SetError(PrimaryPrefixKeyTextBox, "入力してください")
        Else

            ErrorProvider.SetError(PrimaryPrefixKeyTextBox, Nothing)
        End If

        DialogResult = DialogResult.OK
    End Sub

    Public Shared Sub Configure(Mode As IMode)

        Dim PrimaryLabelDefinition As LabelDefinition1 = Nothing

        PrimaryLabelDefinition = If(LabelDefinition1.TryExtract(Mode, LabelDefinition1.KeyForPrimary, PrimaryLabelDefinition), PrimaryLabelDefinition, New LabelDefinition1)

        Using Form = New ModeConfigForm1()

            Form.PrimaryPrefixKeyTextBox.Text = PrimaryLabelDefinition.PrefixKey
            Form.PrimaryItemStartUpDown.Value = PrimaryLabelDefinition.ItemNumberStartIndex
            Form.PrimaryItemLengthUpDown.Value = PrimaryLabelDefinition.ItemNumberLength
            Form.PrimarySerialStartUpDown.Value = PrimaryLabelDefinition.SerialNumberStartIndex
            Form.PrimarySerialLengthUpDown.Value = PrimaryLabelDefinition.SerialNumberLength

            If Mode.IsSecondaryLabelRequired Then

                Form.IsSecondaryRequiredRadio.Checked = True
            ElseIf Mode.HasSecondaryLabel Then

                Form.HasSecondaryRadio.Checked = True
            Else

                Form.HasNoSecondaryRadio.Checked = True
            End If

            If Form.ShowDialog() = DialogResult.OK Then

                Mode.HasC3Label = True
                Mode.HasSecondaryLabel = Form.HasSecondaryRadio.Checked Or Form.IsSecondaryRequiredRadio.Checked
                Mode.IsSecondaryLabelRequired = Form.IsSecondaryRequiredRadio.Checked

                PrimaryLabelDefinition.PrefixKey = Form.PrimaryPrefixKeyTextBox.Text
                PrimaryLabelDefinition.ItemNumberStartIndex = CInt(Form.PrimaryItemStartUpDown.Value)
                PrimaryLabelDefinition.ItemNumberLength = CInt(Form.PrimaryItemLengthUpDown.Value)
                PrimaryLabelDefinition.SerialNumberStartIndex = CInt(Form.PrimarySerialStartUpDown.Value)
                PrimaryLabelDefinition.SerialNumberLength = CInt(Form.PrimarySerialLengthUpDown.Value)

                Mode.ExtendedProperties(LabelDefinition1.KeyForPrimary) = PrimaryLabelDefinition
            End If
        End Using
    End Sub
End Class
