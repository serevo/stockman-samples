using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AuthenticationModules
{
    internal partial class AuthenticationForm2 : Form
    {
        // フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
        [DebuggerNonUserCode()]
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
            this.UserInfoComboBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // InputCancelButton
            // 
            this.InputCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InputCancelButton.Location = new System.Drawing.Point(306, 330);
            this.InputCancelButton.Name = "InputCancelButton";
            this.InputCancelButton.Size = new System.Drawing.Size(81, 26);
            this.InputCancelButton.TabIndex = 11;
            this.InputCancelButton.Text = "キャンセル";
            this.InputCancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(222, 330);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(78, 26);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // UserInfoComboBox
            // 
            this.UserInfoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInfoComboBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserInfoComboBox.FormattingEnabled = true;
            this.UserInfoComboBox.IntegralHeight = false;
            this.UserInfoComboBox.ItemHeight = 33;
            this.UserInfoComboBox.Location = new System.Drawing.Point(12, 12);
            this.UserInfoComboBox.Name = "UserInfoComboBox";
            this.UserInfoComboBox.Size = new System.Drawing.Size(375, 304);
            this.UserInfoComboBox.TabIndex = 12;
            this.UserInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.UserInfoComboBox_SelectedIndexChanged);
            this.UserInfoComboBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserInfoComboBox_MouseDoubleClick);
            // 
            // AuthenticationForm2
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.InputCancelButton;
            this.ClientSize = new System.Drawing.Size(400, 368);
            this.Controls.Add(this.UserInfoComboBox);
            this.Controls.Add(this.InputCancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthenticationForm2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ユーザー選択";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        internal Button InputCancelButton;
        internal Button OkButton;
        internal ErrorProvider ErrorProvider;
        internal ListBox UserInfoComboBox;
    }
}