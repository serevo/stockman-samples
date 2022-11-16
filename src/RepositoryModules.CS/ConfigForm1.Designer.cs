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
            components = new System.ComponentModel.Container();
            InputCancelButton = new Button();
            OkButton = new Button();
            OkButton.Click += new EventHandler(OkButton_Click);
            ErrorProvider = new ErrorProvider(components);
            Label1 = new Label();
            FileTextBox = new TextBox();
            FileButton = new Button();
            FileButton.Click += new EventHandler(FileButton_Click);
            FolderButton = new Button();
            FolderButton.Click += new EventHandler(FolderButton_Click);
            FolderTextBox = new TextBox();
            Label2 = new Label();
            FolderDialog = new FolderBrowserDialog();
            FileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // InputCancelButton
            // 
            InputCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            InputCancelButton.DialogResult = DialogResult.Cancel;
            InputCancelButton.Location = new Point(277, 149);
            InputCancelButton.Name = "InputCancelButton";
            InputCancelButton.Size = new Size(75, 23);
            InputCancelButton.TabIndex = 7;
            InputCancelButton.Text = "キャンセル";
            InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.Location = new Point(176, 147);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(78, 26);
            OkButton.TabIndex = 6;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(25, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(95, 12);
            Label1.TabIndex = 0;
            Label1.Text = "概要データ ファイル";
            // 
            // FileTextBox
            // 
            FileTextBox.Location = new Point(27, 44);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.Size = new Size(283, 19);
            FileTextBox.TabIndex = 1;
            // 
            // FileButton
            // 
            FileButton.AutoSize = true;
            FileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FileButton.Location = new Point(316, 41);
            FileButton.Name = "FileButton";
            FileButton.Size = new Size(21, 22);
            FileButton.TabIndex = 2;
            FileButton.Text = "...";
            FileButton.UseVisualStyleBackColor = true;
            // 
            // FolderButton
            // 
            FolderButton.AutoSize = true;
            FolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FolderButton.Location = new Point(316, 96);
            FolderButton.Name = "FolderButton";
            FolderButton.Size = new Size(21, 22);
            FolderButton.TabIndex = 5;
            FolderButton.Text = "...";
            FolderButton.UseVisualStyleBackColor = true;
            // 
            // FolderTextBox
            // 
            FolderTextBox.Location = new Point(27, 99);
            FolderTextBox.Name = "FolderTextBox";
            FolderTextBox.Size = new Size(283, 19);
            FolderTextBox.TabIndex = 4;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(25, 84);
            Label2.Name = "Label2";
            Label2.Size = new Size(96, 12);
            Label2.TabIndex = 3;
            Label2.Text = "詳細データ フォルダ";
            // 
            // FileDialog
            // 
            FileDialog.FileName = "OpenFileDialog1";
            FileDialog.Filter = "タブ区切り | *.tsv";
            // 
            // ConfigurationForm1
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(6.0f, 12.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = InputCancelButton;
            ClientSize = new Size(363, 185);
            Controls.Add(FolderButton);
            Controls.Add(FolderTextBox);
            Controls.Add(Label2);
            Controls.Add(FileButton);
            Controls.Add(FileTextBox);
            Controls.Add(Label1);
            Controls.Add(InputCancelButton);
            Controls.Add(OkButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigurationForm1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "モジュール設定";
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
    }
}