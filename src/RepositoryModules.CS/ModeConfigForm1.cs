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
            LabelDefinition1 primaryLabelDefinition = LabelDefinition1.TryExtract(Mode, LabelDefinition1.KeyForPrimary, out primaryLabelDefinition) ?
                primaryLabelDefinition :
                new LabelDefinition1();

            using (var form = new ModeConfigForm1())
            {
                form.PrimaryPrefixKeyTextBox.Text = primaryLabelDefinition.PrefixKey;
                form.PrimaryItemStartUpDown.Value = primaryLabelDefinition.ItemNumberStartIndex;
                form.PrimaryItemLengthUpDown.Value = primaryLabelDefinition.ItemNumberLength;
                form.PrimarySerialStartUpDown.Value = primaryLabelDefinition.SerialNumberStartIndex;
                form.PrimarySerialLengthUpDown.Value = primaryLabelDefinition.SerialNumberLength;

                if (Mode.IsSecondaryLabelRequired)
                {
                    form.IsSecondaryRequiredRadio.Checked = true;
                }
                else if (Mode.HasSecondaryLabel)
                {
                    form.HasSecondaryRadio.Checked = true;
                }
                else
                {
                    form.HasNoSecondaryRadio.Checked = true;
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    Mode.HasC3Label = true;
                    Mode.HasSecondaryLabel = form.HasSecondaryRadio.Checked | form.IsSecondaryRequiredRadio.Checked;
                    Mode.IsSecondaryLabelRequired = form.IsSecondaryRequiredRadio.Checked;

                    primaryLabelDefinition.PrefixKey = form.PrimaryPrefixKeyTextBox.Text;
                    primaryLabelDefinition.ItemNumberStartIndex = (int)Math.Round(form.PrimaryItemStartUpDown.Value);
                    primaryLabelDefinition.ItemNumberLength = (int)Math.Round(form.PrimaryItemLengthUpDown.Value);
                    primaryLabelDefinition.SerialNumberStartIndex = (int)Math.Round(form.PrimarySerialStartUpDown.Value);
                    primaryLabelDefinition.SerialNumberLength = (int)Math.Round(form.PrimarySerialLengthUpDown.Value);

                    Mode.ExtendedProperties[LabelDefinition1.KeyForPrimary] = primaryLabelDefinition;
                }
            }
        }
    }
}