using System;
using System.Drawing;
using System.Windows.Forms;

namespace RepositoryModules
{
    internal partial class ConfigForm1 : Form
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
            this.InputCancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SecondaryConditionFileButton = new System.Windows.Forms.Button();
            this.SecondaryConditionFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondaryConditionFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // InputCancelButton
            // 
            this.InputCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InputCancelButton.Location = new System.Drawing.Point(277, 197);
            this.InputCancelButton.Name = "InputCancelButton";
            this.InputCancelButton.Size = new System.Drawing.Size(75, 23);
            this.InputCancelButton.TabIndex = 7;
            this.InputCancelButton.Text = "キャンセル";
            this.InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(176, 195);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(78, 26);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "概要データ ファイル";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(27, 44);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(283, 19);
            this.FileTextBox.TabIndex = 1;
            // 
            // FileButton
            // 
            this.FileButton.AutoSize = true;
            this.FileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileButton.Location = new System.Drawing.Point(316, 41);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(21, 22);
            this.FileButton.TabIndex = 2;
            this.FileButton.Text = "...";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.AutoSize = true;
            this.FolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderButton.Location = new System.Drawing.Point(316, 96);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(21, 22);
            this.FolderButton.TabIndex = 5;
            this.FolderButton.Text = "...";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(27, 97);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(283, 19);
            this.FolderTextBox.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(25, 82);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 12);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "詳細データ フォルダ";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "OpenFileDialog1";
            this.FileDialog.Filter = "タブ区切り | *.tsv";
            // 
            // SecondaryConditionFileButton
            // 
            this.SecondaryConditionFileButton.AutoSize = true;
            this.SecondaryConditionFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondaryConditionFileButton.Location = new System.Drawing.Point(316, 148);
            this.SecondaryConditionFileButton.Name = "SecondaryConditionFileButton";
            this.SecondaryConditionFileButton.Size = new System.Drawing.Size(21, 22);
            this.SecondaryConditionFileButton.TabIndex = 10;
            this.SecondaryConditionFileButton.Text = "...";
            this.SecondaryConditionFileButton.UseVisualStyleBackColor = true;
            this.SecondaryConditionFileButton.Click += new System.EventHandler(this.SecondaryConditionFileButton_Click);
            // 
            // SecondaryConditionFileTextBox
            // 
            this.SecondaryConditionFileTextBox.Location = new System.Drawing.Point(27, 150);
            this.SecondaryConditionFileTextBox.Name = "SecondaryConditionFileTextBox";
            this.SecondaryConditionFileTextBox.Size = new System.Drawing.Size(283, 19);
            this.SecondaryConditionFileTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "C-3 品名対応表データ ファイル";
            // 
            // SecondaryConditionFileDialog
            // 
            this.SecondaryConditionFileDialog.FileName = "OpenFileDialog1";
            this.SecondaryConditionFileDialog.Filter = "カンマ区切り | *.csv";
            // 
            // ConfigForm1
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.InputCancelButton;
            this.ClientSize = new System.Drawing.Size(363, 233);
            this.Controls.Add(this.SecondaryConditionFileButton);
            this.Controls.Add(this.SecondaryConditionFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.InputCancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "モジュール設定";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button InputCancelButton;
        internal Button OkButton;
        internal ErrorProvider ErrorProvider;
        internal Button FolderButton;
        internal TextBox FolderTextBox;
        internal Label Label2;
        internal Button FileButton;
        internal TextBox FileTextBox;
        internal Label Label1;
        internal FolderBrowserDialog FolderDialog;
        internal OpenFileDialog FileDialog;
        internal Button SecondaryConditionFileButton;
        internal TextBox SecondaryConditionFileTextBox;
        internal Label label3;
        internal OpenFileDialog SecondaryConditionFileDialog;
    }
}