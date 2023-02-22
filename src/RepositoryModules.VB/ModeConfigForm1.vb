Imports Storex

Friend Class ModeConfigForm1
    Private Shared ReadOnly SecondaryLabelBehaviorViewModels As IReadOnlyList(Of KeyValuePair(Of String, SecondaryLabelBehavior)) = {
        New KeyValuePair(Of String, SecondaryLabelBehavior)("許可", SecondaryLabelBehavior.Default),
        New KeyValuePair(Of String, SecondaryLabelBehavior)("警告", SecondaryLabelBehavior.Warnning),
        New KeyValuePair(Of String, SecondaryLabelBehavior)("拒否", SecondaryLabelBehavior.Deny)
    }

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

        PrimaryLabelSpec = If(Mode.TryExtractProperty(FixedLengthSpec.PropertyKeyForPrimary, PrimaryLabelSpec), PrimaryLabelSpec, New FixedLengthSpec())

        SecondaryLabelCriteria = If(Mode.TryExtractProperty(SecondaryLabelCriteria.PropertyKey, SecondaryLabelCriteria), SecondaryLabelCriteria, New SecondaryLabelCriteria())

        Using form = New ModeConfigForm1()

            form.PrimaryPrefixKeyTextBox.Text = PrimaryLabelSpec.PrefixKey
            form.PrimaryItemStartUpDown.Value = PrimaryLabelSpec.ItemNumberStartIndex
            form.PrimaryItemLengthUpDown.Value = PrimaryLabelSpec.ItemNumberLength
            form.PrimarySerialStartUpDown.Value = PrimaryLabelSpec.SerialNumberStartIndex
            form.PrimarySerialLengthUpDown.Value = PrimaryLabelSpec.SerialNumberLength

            form.AcceptC3LabelCheckBox.Checked = (SecondaryLabelCriteria.AcceptableTypes And SecondaryLabelTypes.C3Label) = SecondaryLabelTypes.C3Label
            form.AcceptSingleSymbolLabelCeckBox.Checked = (SecondaryLabelCriteria.AcceptableTypes And SecondaryLabelTypes.SingleSymbol) = SecondaryLabelTypes.SingleSymbol

            form.EqualsToPrimaryComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList()
            form.SpecifiedByConditionComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList()
            form.OtherNotSinglLabelComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList()

            form.NoLabelBehaviorComboBox.DataSource = {
                New KeyValuePair(Of String, SecondaryNoLabelBehavior)("許可", SecondaryNoLabelBehavior.Default),
                New KeyValuePair(Of String, SecondaryNoLabelBehavior)("警告", SecondaryNoLabelBehavior.Warnning),
                New KeyValuePair(Of String, SecondaryNoLabelBehavior)("拒否", SecondaryNoLabelBehavior.Deny),
                New KeyValuePair(Of String, SecondaryNoLabelBehavior)("タグで品番照合 (合致しない場合警告) ", SecondaryNoLabelBehavior.WarningWhenTagNotMatched),
                New KeyValuePair(Of String, SecondaryNoLabelBehavior)("タグで品番照合 (合致しない場合拒否)", SecondaryNoLabelBehavior.DenyWhenTagNotMatched)
            }

            form.NoLabelBehaviorComboBox.DisplayMember = NameOf(KeyValuePair(Of String, SecondaryNoLabelBehavior).Key)
            form.EqualsToPrimaryComboBox.DisplayMember = NameOf(KeyValuePair(Of String, SecondaryLabelBehavior).Key)
            form.SpecifiedByConditionComboBox.DisplayMember = NameOf(KeyValuePair(Of String, SecondaryLabelBehavior).Key)
            form.OtherNotSinglLabelComboBox.DisplayMember = NameOf(KeyValuePair(Of String, SecondaryLabelBehavior).Key)

            form.NoLabelBehaviorComboBox.ValueMember = NameOf(KeyValuePair(Of String, SecondaryNoLabelBehavior).Value)
            form.EqualsToPrimaryComboBox.ValueMember = NameOf(KeyValuePair(Of String, SecondaryLabelBehavior).Value)
            form.SpecifiedByConditionComboBox.ValueMember = NameOf(KeyValuePair(Of String, SecondaryLabelBehavior).Value)
            form.OtherNotSinglLabelComboBox.ValueMember = NameOf(KeyValuePair(Of String, SecondaryLabelBehavior).Value)

            form.NoLabelBehaviorComboBox.SelectedValue = SecondaryLabelCriteria.NoLabelBehavior

            form.EqualsToPrimaryComboBox.SelectedValue = SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior
            form.SpecifiedByConditionComboBox.SelectedValue = SecondaryLabelCriteria.SpecifiedByConditionFileBehavior
            form.OtherNotSinglLabelComboBox.SelectedValue = SecondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior

            If form.ShowDialog() = DialogResult.OK Then

                PrimaryLabelSpec.PrefixKey = form.PrimaryPrefixKeyTextBox.Text
                PrimaryLabelSpec.ItemNumberStartIndex = Math.Round(form.PrimaryItemStartUpDown.Value)
                PrimaryLabelSpec.ItemNumberLength = Math.Round(form.PrimaryItemLengthUpDown.Value)
                PrimaryLabelSpec.SerialNumberStartIndex = Math.Round(form.PrimarySerialStartUpDown.Value)
                PrimaryLabelSpec.SerialNumberLength = Math.Round(form.PrimarySerialLengthUpDown.Value)

                Dim AcceptTypes = SecondaryLabelTypes.None
                AcceptTypes = AcceptTypes Or If(form.AcceptC3LabelCheckBox.Checked, SecondaryLabelTypes.C3Label, SecondaryLabelTypes.None)
                AcceptTypes = AcceptTypes Or If(form.AcceptSingleSymbolLabelCeckBox.Checked, SecondaryLabelTypes.SingleSymbol, SecondaryLabelTypes.None)

                SecondaryLabelCriteria.AcceptableTypes = AcceptTypes

                SecondaryLabelCriteria.NoLabelBehavior = CType(form.NoLabelBehaviorComboBox.SelectedValue, SecondaryNoLabelBehavior)

                SecondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = CType(form.EqualsToPrimaryComboBox.SelectedValue, SecondaryLabelBehavior)
                SecondaryLabelCriteria.SpecifiedByConditionFileBehavior = CType(form.SpecifiedByConditionComboBox.SelectedValue, SecondaryLabelBehavior)
                SecondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior = CType(form.OtherNotSinglLabelComboBox.SelectedValue, SecondaryLabelBehavior)

                Mode.ExtendedProperties(FixedLengthSpec.PropertyKeyForPrimary) = PrimaryLabelSpec
                Mode.ExtendedProperties(SecondaryLabelCriteria.PropertyKey) = SecondaryLabelCriteria
            End If
        End Using
    End Sub
End Class
