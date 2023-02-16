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
            this.label8 = new System.Windows.Forms.Label();
            this.OtherNotSinglLabelComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpecifiedByConditionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EqualsToPrimaryComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NoLabelBehaviorComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AcceptSingleSymbolLabelCeckBox = new System.Windows.Forms.CheckBox();
            this.AcceptC3LabelCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryItemStartUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryItemLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySerialLengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySerialStartUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(257, 435);
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
            this.PrimaryPrefixKeyTextBox.Location = new System.Drawing.Point(28, 48);
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
            this.PrimaryItemStartUpDown.Location = new System.Drawing.Point(28, 111);
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
            this.Label2.Location = new System.Drawing.Point(26, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "品番  開始位置";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 150);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 12);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "品番 文字数";
            // 
            // PrimaryItemLengthUpDown
            // 
            this.PrimaryItemLengthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryItemLengthUpDown.Location = new System.Drawing.Point(28, 171);
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
            this.Label4.Location = new System.Drawing.Point(26, 27);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 12);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "シンボル 開始文字";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(26, 267);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(81, 12);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "シリアル 文字数";
            // 
            // PrimarySerialLengthUpDown
            // 
            this.PrimarySerialLengthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimarySerialLengthUpDown.Location = new System.Drawing.Point(28, 288);
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
            this.Label7.Location = new System.Drawing.Point(26, 210);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(93, 12);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "シリアル 開始位置";
            // 
            // PrimarySerialStartUpDown
            // 
            this.PrimarySerialStartUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimarySerialStartUpDown.Location = new System.Drawing.Point(28, 231);
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
            this.InputCancelButton.Location = new System.Drawing.Point(338, 435);
            this.InputCancelButton.Name = "InputCancelButton";
            this.InputCancelButton.Size = new System.Drawing.Size(81, 23);
            this.InputCancelButton.TabIndex = 3;
            this.InputCancelButton.Text = "キャンセル";
            this.InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "部品名不一致、かつ対応表に存在しないC3ラベル";
            // 
            // OtherNotSinglLabelComboBox
            // 
            this.OtherNotSinglLabelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OtherNotSinglLabelComboBox.FormattingEnabled = true;
            this.OtherNotSinglLabelComboBox.Location = new System.Drawing.Point(27, 253);
            this.OtherNotSinglLabelComboBox.Name = "OtherNotSinglLabelComboBox";
            this.OtherNotSinglLabelComboBox.Size = new System.Drawing.Size(341, 20);
            this.OtherNotSinglLabelComboBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "対応表と一致するとき";
            // 
            // SpecifiedByConditionComboBox
            // 
            this.SpecifiedByConditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecifiedByConditionComboBox.FormattingEnabled = true;
            this.SpecifiedByConditionComboBox.Location = new System.Drawing.Point(27, 182);
            this.SpecifiedByConditionComboBox.Name = "SpecifiedByConditionComboBox";
            this.SpecifiedByConditionComboBox.Size = new System.Drawing.Size(341, 20);
            this.SpecifiedByConditionComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "部品名が一致するとき";
            // 
            // EqualsToPrimaryComboBox
            // 
            this.EqualsToPrimaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqualsToPrimaryComboBox.FormattingEnabled = true;
            this.EqualsToPrimaryComboBox.Location = new System.Drawing.Point(27, 119);
            this.EqualsToPrimaryComboBox.Name = "EqualsToPrimaryComboBox";
            this.EqualsToPrimaryComboBox.Size = new System.Drawing.Size(341, 20);
            this.EqualsToPrimaryComboBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "セカンダリラベル無し時";
            // 
            // NoLabelBehaviorComboBox
            // 
            this.NoLabelBehaviorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoLabelBehaviorComboBox.FormattingEnabled = true;
            this.NoLabelBehaviorComboBox.Location = new System.Drawing.Point(30, 324);
            this.NoLabelBehaviorComboBox.Name = "NoLabelBehaviorComboBox";
            this.NoLabelBehaviorComboBox.Size = new System.Drawing.Size(341, 20);
            this.NoLabelBehaviorComboBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 402);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.PrimaryPrefixKeyTextBox);
            this.tabPage1.Controls.Add(this.PrimarySerialStartUpDown);
            this.tabPage1.Controls.Add(this.PrimaryItemStartUpDown);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.Label6);
            this.tabPage1.Controls.Add(this.PrimarySerialLengthUpDown);
            this.tabPage1.Controls.Add(this.PrimaryItemLengthUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "プライマリラベル";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AcceptSingleSymbolLabelCeckBox);
            this.tabPage2.Controls.Add(this.AcceptC3LabelCheckBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.SpecifiedByConditionComboBox);
            this.tabPage2.Controls.Add(this.OtherNotSinglLabelComboBox);
            this.tabPage2.Controls.Add(this.NoLabelBehaviorComboBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.EqualsToPrimaryComboBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "セカンダリラベル";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AcceptSingleSymbolLabelCeckBox
            // 
            this.AcceptSingleSymbolLabelCeckBox.AutoSize = true;
            this.AcceptSingleSymbolLabelCeckBox.Location = new System.Drawing.Point(146, 53);
            this.AcceptSingleSymbolLabelCeckBox.Name = "AcceptSingleSymbolLabelCeckBox";
            this.AcceptSingleSymbolLabelCeckBox.Size = new System.Drawing.Size(119, 16);
            this.AcceptSingleSymbolLabelCeckBox.TabIndex = 18;
            this.AcceptSingleSymbolLabelCeckBox.Text = "単独シンボル ラベル";
            this.AcceptSingleSymbolLabelCeckBox.UseVisualStyleBackColor = true;
            // 
            // AcceptC3LabelCheckBox
            // 
            this.AcceptC3LabelCheckBox.AutoSize = true;
            this.AcceptC3LabelCheckBox.Location = new System.Drawing.Point(30, 53);
            this.AcceptC3LabelCheckBox.Name = "AcceptC3LabelCheckBox";
            this.AcceptC3LabelCheckBox.Size = new System.Drawing.Size(76, 16);
            this.AcceptC3LabelCheckBox.TabIndex = 17;
            this.AcceptC3LabelCheckBox.Text = "C-3 ラベル";
            this.AcceptC3LabelCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "有効ラベル種類";
            // 
            // ModeConfigForm1
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 470);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        internal Label label8;
        private ComboBox OtherNotSinglLabelComboBox;
        internal Label label5;
        private ComboBox SpecifiedByConditionComboBox;
        internal Label label1;
        private ComboBox EqualsToPrimaryComboBox;
        internal Label label9;
        private ComboBox NoLabelBehaviorComboBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox AcceptSingleSymbolLabelCeckBox;
        private CheckBox AcceptC3LabelCheckBox;
        private Label label10;
    }
}