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
            this.IsSecondaryLabelRequiredCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.OkButton.Location = new System.Drawing.Point(257, 500);
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
            this.InputCancelButton.Location = new System.Drawing.Point(338, 500);
            this.InputCancelButton.Name = "InputCancelButton";
            this.InputCancelButton.Size = new System.Drawing.Size(81, 23);
            this.InputCancelButton.TabIndex = 3;
            this.InputCancelButton.Text = "キャンセル";
            this.InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // IsSecondaryLabelRequiredCheck
            // 
            this.IsSecondaryLabelRequiredCheck.AutoSize = true;
            this.IsSecondaryLabelRequiredCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IsSecondaryLabelRequiredCheck.Location = new System.Drawing.Point(28, 43);
            this.IsSecondaryLabelRequiredCheck.Name = "IsSecondaryLabelRequiredCheck";
            this.IsSecondaryLabelRequiredCheck.Size = new System.Drawing.Size(255, 16);
            this.IsSecondaryLabelRequiredCheck.TabIndex = 0;
            this.IsSecondaryLabelRequiredCheck.Text = "必須にする (品名が一致する C-3 ラベルが必要)";
            this.IsSecondaryLabelRequiredCheck.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.IsSecondaryLabelRequiredCheck);
            this.groupBox2.Location = new System.Drawing.Point(22, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "セカンダリ ラベル";
            // 
            // ModeConfigForm1
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 535);
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
        internal CheckBox ExtractPartCheckBox;
        internal Label Label3;
        internal NumericUpDown PrimaryItemLengthUpDown;
        internal Label Label4;
        internal Label Label6;
        internal NumericUpDown PrimarySerialLengthUpDown;
        internal Label Label7;
        internal NumericUpDown PrimarySerialStartUpDown;
        internal Button InputCancelButton;
        private CheckBox IsSecondaryLabelRequiredCheck;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}