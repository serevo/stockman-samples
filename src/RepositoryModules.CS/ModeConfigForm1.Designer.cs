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
            this.components = new System.ComponentModel.Container();
            this.OkButton = new System.Windows.Forms.Button();
            this.PrimaryPrefixKeyTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PrimaryItemStartUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PrimaryItemLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.PrimarySerialLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label7 = new System.Windows.Forms.Label();
            this.PrimarySerialStartUpDown = new System.Windows.Forms.NumericUpDown();
            this.InputCancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OtherLabelsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpecifiedByConditionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EqualsToPrimaryComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NoneLabelBehaviorComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryItemStartUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryItemLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySerialLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySerialStartUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(257, 679);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PrimaryPrefixKeyTextBox
            // 
            this.PrimaryPrefixKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPrefixKeyTextBox.Location = new System.Drawing.Point(25, 55);
            this.PrimaryPrefixKeyTextBox.Name = "PrimaryPrefixKeyTextBox";
            this.PrimaryPrefixKeyTextBox.Size = new System.Drawing.Size(341, 19);
            this.PrimaryPrefixKeyTextBox.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PrimaryItemStartUpDown
            // 
            this.PrimaryItemStartUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryItemStartUpDown.Location = new System.Drawing.Point(25, 118);
            this.PrimaryItemStartUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimaryItemStartUpDown.Name = "PrimaryItemStartUpDown";
            this.PrimaryItemStartUpDown.Size = new System.Drawing.Size(341, 19);
            this.PrimaryItemStartUpDown.TabIndex = 3;
            this.PrimaryItemStartUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrimaryItemStartUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "品番  開始位置";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 12);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "品番 文字数";
            // 
            // PrimaryItemLengthUpDown
            // 
            this.PrimaryItemLengthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryItemLengthUpDown.Location = new System.Drawing.Point(25, 178);
            this.PrimaryItemLengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimaryItemLengthUpDown.Name = "PrimaryItemLengthUpDown";
            this.PrimaryItemLengthUpDown.Size = new System.Drawing.Size(341, 19);
            this.PrimaryItemLengthUpDown.TabIndex = 5;
            this.PrimaryItemLengthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrimaryItemLengthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(23, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 12);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "シンボル 開始文字";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(23, 274);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(81, 12);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "シリアル 文字数";
            // 
            // PrimarySerialLengthUpDown
            // 
            this.PrimarySerialLengthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimarySerialLengthUpDown.Location = new System.Drawing.Point(25, 295);
            this.PrimarySerialLengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimarySerialLengthUpDown.Name = "PrimarySerialLengthUpDown";
            this.PrimarySerialLengthUpDown.Size = new System.Drawing.Size(341, 19);
            this.PrimarySerialLengthUpDown.TabIndex = 9;
            this.PrimarySerialLengthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrimarySerialLengthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(23, 217);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(93, 12);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "シリアル 開始位置";
            // 
            // PrimarySerialStartUpDown
            // 
            this.PrimarySerialStartUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimarySerialStartUpDown.Location = new System.Drawing.Point(25, 238);
            this.PrimarySerialStartUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimarySerialStartUpDown.Name = "PrimarySerialStartUpDown";
            this.PrimarySerialStartUpDown.Size = new System.Drawing.Size(341, 19);
            this.PrimarySerialStartUpDown.TabIndex = 7;
            this.PrimarySerialStartUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrimarySerialStartUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputCancelButton
            // 
            this.InputCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InputCancelButton.Location = new System.Drawing.Point(338, 679);
            this.InputCancelButton.Name = "InputCancelButton";
            this.InputCancelButton.Size = new System.Drawing.Size(81, 23);
            this.InputCancelButton.TabIndex = 3;
            this.InputCancelButton.Text = "キャンセル";
            this.InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.PrimaryPrefixKeyTextBox);
            this.groupBox1.Controls.Add(this.PrimaryItemStartUpDown);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.PrimaryItemLengthUpDown);
            this.groupBox1.Controls.Add(this.PrimarySerialLengthUpDown);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.PrimarySerialStartUpDown);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "プライマリ ラベル";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.OtherLabelsComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SpecifiedByConditionComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EqualsToPrimaryComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.NoneLabelBehaviorComboBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "セカンダリ ラベル";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "その他C3ラベル";
            // 
            // OtherLabelsComboBox
            // 
            this.OtherLabelsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OtherLabelsComboBox.FormattingEnabled = true;
            this.OtherLabelsComboBox.Location = new System.Drawing.Point(25, 218);
            this.OtherLabelsComboBox.Name = "OtherLabelsComboBox";
            this.OtherLabelsComboBox.Size = new System.Drawing.Size(341, 20);
            this.OtherLabelsComboBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "対応表と一致するC3ラベル";
            // 
            // SpecifiedByConditionComboBox
            // 
            this.SpecifiedByConditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecifiedByConditionComboBox.FormattingEnabled = true;
            this.SpecifiedByConditionComboBox.Location = new System.Drawing.Point(25, 160);
            this.SpecifiedByConditionComboBox.Name = "SpecifiedByConditionComboBox";
            this.SpecifiedByConditionComboBox.Size = new System.Drawing.Size(341, 20);
            this.SpecifiedByConditionComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "部品名が一致するC3ラベル";
            // 
            // EqualsToPrimaryComboBox
            // 
            this.EqualsToPrimaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqualsToPrimaryComboBox.FormattingEnabled = true;
            this.EqualsToPrimaryComboBox.Location = new System.Drawing.Point(25, 102);
            this.EqualsToPrimaryComboBox.Name = "EqualsToPrimaryComboBox";
            this.EqualsToPrimaryComboBox.Size = new System.Drawing.Size(341, 20);
            this.EqualsToPrimaryComboBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "シンボル無し時";
            // 
            // NoneLabelBehaviorComboBox
            // 
            this.NoneLabelBehaviorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoneLabelBehaviorComboBox.FormattingEnabled = true;
            this.NoneLabelBehaviorComboBox.Location = new System.Drawing.Point(25, 44);
            this.NoneLabelBehaviorComboBox.Name = "NoneLabelBehaviorComboBox";
            this.NoneLabelBehaviorComboBox.Size = new System.Drawing.Size(341, 20);
            this.NoneLabelBehaviorComboBox.TabIndex = 1;
            // 
            // ModeConfigForm1
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputCancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModeConfigForm1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "モード設定";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryItemStartUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryItemLengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySerialLengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySerialStartUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        internal Button OkButton;
        internal TextBox PrimaryPrefixKeyTextBox;
        internal ErrorProvider ErrorProvider;
        internal Label Label2;
        internal NumericUpDown PrimaryItemStartUpDown;
        internal Label Label3;
        internal NumericUpDown PrimaryItemLengthUpDown;
        internal Label Label4;
        internal Label Label6;
        internal NumericUpDown PrimarySerialLengthUpDown;
        internal Label Label7;
        internal NumericUpDown PrimarySerialStartUpDown;
        internal Button InputCancelButton;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        internal Label label8;
        private ComboBox OtherLabelsComboBox;
        internal Label label5;
        private ComboBox SpecifiedByConditionComboBox;
        internal Label label1;
        private ComboBox EqualsToPrimaryComboBox;
        internal Label label9;
        private ComboBox NoneLabelBehaviorComboBox;
    }
}