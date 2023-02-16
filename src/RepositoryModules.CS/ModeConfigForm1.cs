using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Storex;

namespace RepositoryModules
{
    partial class ModeConfigForm1
    {
        static readonly IReadOnlyList<KeyValuePair<string, SecondaryLabelBehavior>> SecondaryLabelBehaviorViewModels = new[]
        {
            new KeyValuePair<string, SecondaryLabelBehavior>("許可", SecondaryLabelBehavior.Default),
            new KeyValuePair<string, SecondaryLabelBehavior>("登録時に警告を表示", SecondaryLabelBehavior.Warnning),
            new KeyValuePair<string, SecondaryLabelBehavior>("拒否", SecondaryLabelBehavior.Deny)
        };

        public ModeConfigForm1()
        {
            InitializeComponent();
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PrimaryPrefixKeyTextBox.Text.TrimEnd()))
            {
                ErrorProvider.SetError(PrimaryPrefixKeyTextBox, "入力してください");
            }
            else
            {
                ErrorProvider.SetError(PrimaryPrefixKeyTextBox, null);
            }

            DialogResult = DialogResult.OK;
        }

        public static void Configure(IMode Mode)
        {
            FixedLengthSpec primaryLabelSpec = Mode.TryExtractProperty(FixedLengthSpec.PropertyKeyForPrimary, out primaryLabelSpec) ?
                primaryLabelSpec :
                new FixedLengthSpec();

            SecondaryLabelCriteria secondaryLabelCriteria = Mode.TryExtractProperty(SecondaryLabelCriteria.PropertyKey, out secondaryLabelCriteria) ?
                secondaryLabelCriteria :
                new SecondaryLabelCriteria();

            using (var form = new ModeConfigForm1())
            {
                form.PrimaryPrefixKeyTextBox.Text = primaryLabelSpec.PrefixKey;
                form.PrimaryItemStartUpDown.Value = primaryLabelSpec.ItemNumberStartIndex;
                form.PrimaryItemLengthUpDown.Value = primaryLabelSpec.ItemNumberLength;
                form.PrimarySerialStartUpDown.Value = primaryLabelSpec.SerialNumberStartIndex;
                form.PrimarySerialLengthUpDown.Value = primaryLabelSpec.SerialNumberLength;

                form.AcceptC3LabelCheckBox.Checked = (secondaryLabelCriteria.AcceptableTypes & SecondaryLabelTypes.C3Label) == SecondaryLabelTypes.C3Label;
                form.AcceptSingleSymbolLabelCeckBox.Checked = (secondaryLabelCriteria.AcceptableTypes & SecondaryLabelTypes.SingleSymbol) == SecondaryLabelTypes.SingleSymbol;

                form.EqualsToPrimaryComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();
                form.SpecifiedByConditionComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();
                form.OtherNotSinglLabelComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();

                form.NoLabelBehaviorComboBox.DataSource = new[]
                {
                    new KeyValuePair<string, SecondaryNoLabelBehavior>("許可", SecondaryNoLabelBehavior.Default),
                    new KeyValuePair<string, SecondaryNoLabelBehavior>("登録時に警告を表示", SecondaryNoLabelBehavior.Warnning),
                    new KeyValuePair<string, SecondaryNoLabelBehavior>("登録時にタグで品名確認(一致しないとき警告)", SecondaryNoLabelBehavior.TagRequest),
                    new KeyValuePair<string, SecondaryNoLabelBehavior>("登録時にタグで品名確認(一致しないとき拒否)", SecondaryNoLabelBehavior.TagRequired),
                    new KeyValuePair<string, SecondaryNoLabelBehavior>("拒否", SecondaryNoLabelBehavior.Deny)
                };

                form.NoLabelBehaviorComboBox.DisplayMember
                    = form.EqualsToPrimaryComboBox.DisplayMember
                    = form.SpecifiedByConditionComboBox.DisplayMember
                    = form.OtherNotSinglLabelComboBox.DisplayMember = "Key";

                form.NoLabelBehaviorComboBox.ValueMember
                    = form.EqualsToPrimaryComboBox.ValueMember
                    = form.SpecifiedByConditionComboBox.ValueMember
                    = form.OtherNotSinglLabelComboBox.ValueMember ="Value";

                form.NoLabelBehaviorComboBox.SelectedValue = secondaryLabelCriteria.NoLabelBehavior;

                form.EqualsToPrimaryComboBox.SelectedValue = secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior;
                form.SpecifiedByConditionComboBox.SelectedValue = secondaryLabelCriteria.SpecifiedByConditionFileBehavior;
                form.OtherNotSinglLabelComboBox.SelectedValue = secondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    primaryLabelSpec.PrefixKey = form.PrimaryPrefixKeyTextBox.Text;
                    primaryLabelSpec.ItemNumberStartIndex = (int)Math.Round(form.PrimaryItemStartUpDown.Value);
                    primaryLabelSpec.ItemNumberLength = (int)Math.Round(form.PrimaryItemLengthUpDown.Value);
                    primaryLabelSpec.SerialNumberStartIndex = (int)Math.Round(form.PrimarySerialStartUpDown.Value);
                    primaryLabelSpec.SerialNumberLength = (int)Math.Round(form.PrimarySerialLengthUpDown.Value);

                    var acceptTypes = SecondaryLabelTypes.None;
                    acceptTypes |= form.AcceptC3LabelCheckBox.Checked ? SecondaryLabelTypes.C3Label : SecondaryLabelTypes.None;
                    acceptTypes |= form.AcceptSingleSymbolLabelCeckBox.Checked ? SecondaryLabelTypes.SingleSymbol : SecondaryLabelTypes.None;

                    secondaryLabelCriteria.AcceptableTypes = acceptTypes;

                    secondaryLabelCriteria.NoLabelBehavior = (SecondaryNoLabelBehavior)form.NoLabelBehaviorComboBox.SelectedValue;
                    secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = (SecondaryLabelBehavior)form.EqualsToPrimaryComboBox.SelectedValue;
                    secondaryLabelCriteria.SpecifiedByConditionFileBehavior = (SecondaryLabelBehavior)form.SpecifiedByConditionComboBox.SelectedValue;
                    secondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior = (SecondaryLabelBehavior)form.OtherNotSinglLabelComboBox.SelectedValue;

                    Mode.ExtendedProperties[FixedLengthSpec.PropertyKeyForPrimary] = primaryLabelSpec;
                    Mode.ExtendedProperties[SecondaryLabelCriteria.PropertyKey] = secondaryLabelCriteria;
                }
            }
        }
    }
}