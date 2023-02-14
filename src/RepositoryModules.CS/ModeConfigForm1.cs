using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Storex;

namespace RepositoryModules
{
    partial class ModeConfigForm1
    {
        static readonly IReadOnlyList<SecondaryLabelBehaviorViewModel> SecondaryLabelBehaviorViewModels = new[]
        {
            new SecondaryLabelBehaviorViewModel("許可", SecondaryLabelBehavior.Default),
            new SecondaryLabelBehaviorViewModel("警告を表示", SecondaryLabelBehavior.Warnning),
            new SecondaryLabelBehaviorViewModel("拒否", SecondaryLabelBehavior.Deny)
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

                form.NoneLabelBehaviorComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();
                form.EqualsToPrimaryComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();
                form.SpecifiedByConditionComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();
                form.OtherLabelsComboBox.DataSource = SecondaryLabelBehaviorViewModels.ToList();

                form.NoneLabelBehaviorComboBox.DisplayMember
                    = form.EqualsToPrimaryComboBox.DisplayMember
                    = form.SpecifiedByConditionComboBox.DisplayMember
                    = form.OtherLabelsComboBox.DisplayMember = nameof(SecondaryLabelBehaviorViewModel.Display);

                form.NoneLabelBehaviorComboBox.ValueMember
                    = form.EqualsToPrimaryComboBox.ValueMember
                    = form.SpecifiedByConditionComboBox.ValueMember
                    = form.OtherLabelsComboBox.ValueMember = nameof(SecondaryLabelBehaviorViewModel.Behavior);

                form.NoneLabelBehaviorComboBox.SelectedValue = secondaryLabelCriteria.NoLabelBehavior;
                form.EqualsToPrimaryComboBox.SelectedValue = secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior;
                form.SpecifiedByConditionComboBox.SelectedValue = secondaryLabelCriteria.SpecifiedByConditionFileBehavior;
                form.OtherLabelsComboBox.SelectedValue = secondaryLabelCriteria.OtherLabelsBehavior;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    primaryLabelSpec.PrefixKey = form.PrimaryPrefixKeyTextBox.Text;
                    primaryLabelSpec.ItemNumberStartIndex = (int)Math.Round(form.PrimaryItemStartUpDown.Value);
                    primaryLabelSpec.ItemNumberLength = (int)Math.Round(form.PrimaryItemLengthUpDown.Value);
                    primaryLabelSpec.SerialNumberStartIndex = (int)Math.Round(form.PrimarySerialStartUpDown.Value);
                    primaryLabelSpec.SerialNumberLength = (int)Math.Round(form.PrimarySerialLengthUpDown.Value);

                    secondaryLabelCriteria.NoLabelBehavior = (SecondaryLabelBehavior)form.NoneLabelBehaviorComboBox.SelectedValue;
                    secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior = (SecondaryLabelBehavior)form.EqualsToPrimaryComboBox.SelectedValue;
                    secondaryLabelCriteria.SpecifiedByConditionFileBehavior = (SecondaryLabelBehavior)form.SpecifiedByConditionComboBox.SelectedValue;
                    secondaryLabelCriteria.OtherLabelsBehavior = (SecondaryLabelBehavior)form.OtherLabelsComboBox.SelectedValue;

                    Mode.ExtendedProperties[FixedLengthSpec.PropertyKeyForPrimary] = primaryLabelSpec;
                    Mode.ExtendedProperties[SecondaryLabelCriteria.PropertyKey] = secondaryLabelCriteria;
                }
            }
        }
    }
}