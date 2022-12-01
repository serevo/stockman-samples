using System;
using System.Windows.Forms;
using Storex;

namespace RepositoryModules
{
    partial class ModeConfigForm1
    {
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
                form.IsSecondaryLabelRequiredCheck.Checked = secondaryLabelCriteria.IsRequired;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    primaryLabelSpec.PrefixKey = form.PrimaryPrefixKeyTextBox.Text;
                    primaryLabelSpec.ItemNumberStartIndex = (int)Math.Round(form.PrimaryItemStartUpDown.Value);
                    primaryLabelSpec.ItemNumberLength = (int)Math.Round(form.PrimaryItemLengthUpDown.Value);
                    primaryLabelSpec.SerialNumberStartIndex = (int)Math.Round(form.PrimarySerialStartUpDown.Value);
                    primaryLabelSpec.SerialNumberLength = (int)Math.Round(form.PrimarySerialLengthUpDown.Value);
                    secondaryLabelCriteria.IsRequired = form.IsSecondaryLabelRequiredCheck.Checked;

                    Mode.ExtendedProperties[FixedLengthSpec.PropertyKeyForPrimary] = primaryLabelSpec;
                    Mode.ExtendedProperties[SecondaryLabelCriteria.PropertyKey] = secondaryLabelCriteria;
                }
            }
        }
    }
}