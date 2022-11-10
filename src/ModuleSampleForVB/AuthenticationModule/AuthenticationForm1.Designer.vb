<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthenticationForm1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputCancelButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.NumTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDを入力してください"
        '
        'InputCancelButton
        '
        Me.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.InputCancelButton.Location = New System.Drawing.Point(235, 86)
        Me.InputCancelButton.Name = "InputCancelButton"
        Me.InputCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.InputCancelButton.TabIndex = 3
        Me.InputCancelButton.Text = "キャンセル"
        Me.InputCancelButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(134, 84)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(78, 26)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'NumTextBox
        '
        Me.NumTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumTextBox.Location = New System.Drawing.Point(24, 48)
        Me.NumTextBox.Name = "NumTextBox"
        Me.NumTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NumTextBox.Size = New System.Drawing.Size(276, 19)
        Me.NumTextBox.TabIndex = 1
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'AuthenticationForm1
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.InputCancelButton
        Me.ClientSize = New System.Drawing.Size(324, 121)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputCancelButton)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.NumTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AuthenticationForm1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ユーザー認証"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InputCancelButton As Button
    Friend WithEvents OkButton As Button
    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
