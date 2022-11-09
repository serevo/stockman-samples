<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CsvAuthenticationConfigureForm
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
        Me.AbandonButton = New System.Windows.Forms.Button()
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.IsUsedIdRadioButton = New System.Windows.Forms.RadioButton()
        Me.IsUsedNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSelectorButton = New System.Windows.Forms.Button()
        Me.FilePathTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AbandonButton
        '
        Me.AbandonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AbandonButton.Location = New System.Drawing.Point(244, 166)
        Me.AbandonButton.Name = "AbandonButton"
        Me.AbandonButton.Size = New System.Drawing.Size(75, 23)
        Me.AbandonButton.TabIndex = 13
        Me.AbandonButton.Text = "キャンセル"
        Me.AbandonButton.UseVisualStyleBackColor = True
        '
        'ApplyButton
        '
        Me.ApplyButton.Location = New System.Drawing.Point(157, 166)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyButton.TabIndex = 12
        Me.ApplyButton.Text = "適用"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'IsUsedIdRadioButton
        '
        Me.IsUsedIdRadioButton.AutoSize = True
        Me.IsUsedIdRadioButton.Location = New System.Drawing.Point(12, 109)
        Me.IsUsedIdRadioButton.Name = "IsUsedIdRadioButton"
        Me.IsUsedIdRadioButton.Size = New System.Drawing.Size(66, 16)
        Me.IsUsedIdRadioButton.TabIndex = 11
        Me.IsUsedIdRadioButton.TabStop = True
        Me.IsUsedIdRadioButton.Text = "Idで検索"
        Me.IsUsedIdRadioButton.UseVisualStyleBackColor = True
        '
        'IsUsedNameRadioButton
        '
        Me.IsUsedNameRadioButton.AutoSize = True
        Me.IsUsedNameRadioButton.Location = New System.Drawing.Point(12, 87)
        Me.IsUsedNameRadioButton.Name = "IsUsedNameRadioButton"
        Me.IsUsedNameRadioButton.Size = New System.Drawing.Size(81, 16)
        Me.IsUsedNameRadioButton.TabIndex = 10
        Me.IsUsedNameRadioButton.TabStop = True
        Me.IsUsedNameRadioButton.Text = "名前で検索"
        Me.IsUsedNameRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "使用するファイル"
        '
        'FileSelectorButton
        '
        Me.FileSelectorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FileSelectorButton.Location = New System.Drawing.Point(255, 27)
        Me.FileSelectorButton.Name = "FileSelectorButton"
        Me.FileSelectorButton.Size = New System.Drawing.Size(51, 23)
        Me.FileSelectorButton.TabIndex = 8
        Me.FileSelectorButton.Text = "検索"
        Me.FileSelectorButton.UseVisualStyleBackColor = True
        '
        'FilePathTextBox
        '
        Me.FilePathTextBox.Enabled = False
        Me.FilePathTextBox.Location = New System.Drawing.Point(12, 29)
        Me.FilePathTextBox.Name = "FilePathTextBox"
        Me.FilePathTextBox.Size = New System.Drawing.Size(237, 19)
        Me.FilePathTextBox.TabIndex = 7
        '
        'CsvAuthenticationConfigureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 203)
        Me.Controls.Add(Me.AbandonButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.IsUsedIdRadioButton)
        Me.Controls.Add(Me.IsUsedNameRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileSelectorButton)
        Me.Controls.Add(Me.FilePathTextBox)
        Me.Name = "CsvAuthenticationConfigureForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "認証設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AbandonButton As Button
    Friend WithEvents ApplyButton As Button
    Friend WithEvents IsUsedIdRadioButton As RadioButton
    Friend WithEvents IsUsedNameRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents FileSelectorButton As Button
    Friend WithEvents FilePathTextBox As TextBox
End Class
