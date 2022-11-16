using System;
using System.Drawing;
using System.Windows.Forms;

namespace RepositoryModules
{
    internal partial class ModeConfigForm1 : Form
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            OkButton = new Button();
            OkButton.Click += new EventHandler(OkButton_Click);
            PrimaryPrefixKeyTextBox = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            PrimaryItemStartUpDown = new NumericUpDown();
            Label2 = new Label();
            Label3 = new Label();
            PrimaryItemLengthUpDown = new NumericUpDown();
            Label4 = new Label();
            Label6 = new Label();
            PrimarySerialLengthUpDown = new NumericUpDown();
            Label7 = new Label();
            PrimarySerialStartUpDown = new NumericUpDown();
            InputCancelButton = new Button();
            HasNoSecondaryRadio = new RadioButton();
            IsSecondaryRequiredRadio = new RadioButton();
            HasSecondaryRadio = new RadioButton();
            GroupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrimaryItemStartUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrimaryItemLengthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrimarySerialLengthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrimarySerialStartUpDown).BeginInit();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(209, 426);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 11;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // PrimaryPrefixKeyTextBox
            // 
            PrimaryPrefixKeyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrimaryPrefixKeyTextBox.Location = new Point(34, 47);
            PrimaryPrefixKeyTextBox.Name = "PrimaryPrefixKeyTextBox";
            PrimaryPrefixKeyTextBox.Size = new Size(318, 19);
            PrimaryPrefixKeyTextBox.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // PrimaryItemStartUpDown
            // 
            PrimaryItemStartUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrimaryItemStartUpDown.Location = new Point(34, 110);
            PrimaryItemStartUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PrimaryItemStartUpDown.Name = "PrimaryItemStartUpDown";
            PrimaryItemStartUpDown.Size = new Size(318, 19);
            PrimaryItemStartUpDown.TabIndex = 3;
            PrimaryItemStartUpDown.TextAlign = HorizontalAlignment.Right;
            PrimaryItemStartUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(32, 89);
            Label2.Name = "Label2";
            Label2.Size = new Size(85, 12);
            Label2.TabIndex = 2;
            Label2.Text = "品番  開始位置";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(32, 149);
            Label3.Name = "Label3";
            Label3.Size = new Size(69, 12);
            Label3.TabIndex = 4;
            Label3.Text = "品番 文字数";
            // 
            // PrimaryItemLengthUpDown
            // 
            PrimaryItemLengthUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrimaryItemLengthUpDown.Location = new Point(34, 170);
            PrimaryItemLengthUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PrimaryItemLengthUpDown.Name = "PrimaryItemLengthUpDown";
            PrimaryItemLengthUpDown.Size = new Size(318, 19);
            PrimaryItemLengthUpDown.TabIndex = 5;
            PrimaryItemLengthUpDown.TextAlign = HorizontalAlignment.Right;
            PrimaryItemLengthUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(32, 26);
            Label4.Name = "Label4";
            Label4.Size = new Size(104, 12);
            Label4.TabIndex = 0;
            Label4.Text = "主シンボル開始文字";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(32, 266);
            Label6.Name = "Label6";
            Label6.Size = new Size(81, 12);
            Label6.TabIndex = 8;
            Label6.Text = "シリアル 文字数";
            // 
            // PrimarySerialLengthUpDown
            // 
            PrimarySerialLengthUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrimarySerialLengthUpDown.Location = new Point(34, 287);
            PrimarySerialLengthUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PrimarySerialLengthUpDown.Name = "PrimarySerialLengthUpDown";
            PrimarySerialLengthUpDown.Size = new Size(318, 19);
            PrimarySerialLengthUpDown.TabIndex = 9;
            PrimarySerialLengthUpDown.TextAlign = HorizontalAlignment.Right;
            PrimarySerialLengthUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(32, 209);
            Label7.Name = "Label7";
            Label7.Size = new Size(93, 12);
            Label7.TabIndex = 6;
            Label7.Text = "シリアル 開始位置";
            // 
            // PrimarySerialStartUpDown
            // 
            PrimarySerialStartUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrimarySerialStartUpDown.Location = new Point(34, 230);
            PrimarySerialStartUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PrimarySerialStartUpDown.Name = "PrimarySerialStartUpDown";
            PrimarySerialStartUpDown.Size = new Size(318, 19);
            PrimarySerialStartUpDown.TabIndex = 7;
            PrimarySerialStartUpDown.TextAlign = HorizontalAlignment.Right;
            PrimarySerialStartUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // InputCancelButton
            // 
            InputCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            InputCancelButton.DialogResult = DialogResult.Cancel;
            InputCancelButton.Location = new Point(290, 426);
            InputCancelButton.Name = "InputCancelButton";
            InputCancelButton.Size = new Size(81, 23);
            InputCancelButton.TabIndex = 12;
            InputCancelButton.Text = "キャンセル";
            InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // HasNoSecondaryRadio
            // 
            HasNoSecondaryRadio.AutoSize = true;
            HasNoSecondaryRadio.Location = new Point(6, 27);
            HasNoSecondaryRadio.Name = "HasNoSecondaryRadio";
            HasNoSecondaryRadio.Size = new Size(42, 16);
            HasNoSecondaryRadio.TabIndex = 0;
            HasNoSecondaryRadio.TabStop = true;
            HasNoSecondaryRadio.Text = "なし";
            HasNoSecondaryRadio.UseVisualStyleBackColor = true;
            // 
            // IsSecondaryRequiredRadio
            // 
            IsSecondaryRequiredRadio.AutoSize = true;
            IsSecondaryRequiredRadio.Location = new Point(107, 27);
            IsSecondaryRequiredRadio.Name = "IsSecondaryRequiredRadio";
            IsSecondaryRequiredRadio.Size = new Size(47, 16);
            IsSecondaryRequiredRadio.TabIndex = 2;
            IsSecondaryRequiredRadio.TabStop = true;
            IsSecondaryRequiredRadio.Text = "必須";
            IsSecondaryRequiredRadio.UseVisualStyleBackColor = true;
            // 
            // HasSecondaryRadio
            // 
            HasSecondaryRadio.AutoSize = true;
            HasSecondaryRadio.Location = new Point(54, 27);
            HasSecondaryRadio.Name = "HasSecondaryRadio";
            HasSecondaryRadio.Size = new Size(47, 16);
            HasSecondaryRadio.TabIndex = 1;
            HasSecondaryRadio.TabStop = true;
            HasSecondaryRadio.Text = "任意";
            HasSecondaryRadio.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox1.Controls.Add(HasNoSecondaryRadio);
            GroupBox1.Controls.Add(HasSecondaryRadio);
            GroupBox1.Controls.Add(IsSecondaryRequiredRadio);
            GroupBox1.Location = new Point(34, 343);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(318, 58);
            GroupBox1.TabIndex = 10;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "副シンボル (C-3 ラベル)";
            // 
            // ModeRepositorySettingsForm1
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(6.0f, 12.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(GroupBox1);
            Controls.Add(InputCancelButton);
            Controls.Add(Label6);
            Controls.Add(PrimarySerialLengthUpDown);
            Controls.Add(Label7);
            Controls.Add(PrimarySerialStartUpDown);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(PrimaryItemLengthUpDown);
            Controls.Add(Label2);
            Controls.Add(PrimaryItemStartUpDown);
            Controls.Add(OkButton);
            Controls.Add(PrimaryPrefixKeyTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModeRepositorySettingsForm1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "モード設定";
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrimaryItemStartUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrimaryItemLengthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrimarySerialLengthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrimarySerialStartUpDown).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button OkButton;
        internal TextBox PrimaryPrefixKeyTextBox;
        internal ErrorProvider ErrorProvider;
        internal Label Label2;
        internal NumericUpDown PrimaryItemStartUpDown;
        internal CheckBox ExtractPartCheckBox;
        internal Label Label3;
        internal NumericUpDown PrimaryItemLengthUpDown;
        internal Label Label4;
        internal Label Label6;
        internal NumericUpDown PrimarySerialLengthUpDown;
        internal Label Label7;
        internal NumericUpDown PrimarySerialStartUpDown;
        internal Button InputCancelButton;
        internal GroupBox GroupBox1;
        internal RadioButton HasNoSecondaryRadio;
        internal RadioButton HasSecondaryRadio;
        internal RadioButton IsSecondaryRequiredRadio;
    }
}