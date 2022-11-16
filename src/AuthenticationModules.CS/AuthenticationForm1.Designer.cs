using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AuthenticationModules
{
    partial class AuthenticationForm1 : Form
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
            Label1 = new Label();
            InputCancelButton = new Button();
            OkButton = new Button();
            OkButton.Click += new EventHandler(OkButton_Click);
            NumTextBox = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(22, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(100, 12);
            Label1.TabIndex = 0;
            Label1.Text = "IDを入力してください";
            // 
            // InputCancelButton
            // 
            InputCancelButton.DialogResult = DialogResult.Cancel;
            InputCancelButton.Location = new Point(235, 86);
            InputCancelButton.Name = "InputCancelButton";
            InputCancelButton.Size = new Size(75, 23);
            InputCancelButton.TabIndex = 3;
            InputCancelButton.Text = "キャンセル";
            InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(134, 84);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(78, 26);
            OkButton.TabIndex = 2;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // NumTextBox
            // 
            NumTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumTextBox.Location = new Point(24, 48);
            NumTextBox.Name = "NumTextBox";
            NumTextBox.PasswordChar = '*';
            NumTextBox.Size = new Size(276, 19);
            NumTextBox.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // AuthenticationForm1
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(6.0f, 12.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = InputCancelButton;
            ClientSize = new Size(324, 121);
            Controls.Add(Label1);
            Controls.Add(InputCancelButton);
            Controls.Add(OkButton);
            Controls.Add(NumTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthenticationForm1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ユーザー認証";
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Button InputCancelButton;
        internal Button OkButton;
        internal TextBox NumTextBox;
        internal ErrorProvider ErrorProvider;
    }
}