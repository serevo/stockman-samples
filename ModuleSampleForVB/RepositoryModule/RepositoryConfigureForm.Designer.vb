<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepositoryConfigureForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderSelectorButton = New System.Windows.Forms.Button()
        Me.FolderPathTextBox = New System.Windows.Forms.TextBox()
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSelectorButton = New System.Windows.Forms.Button()
        Me.MasterFilePathTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "保存先フォルダ"
        '
        'FolderSelectorButton
        '
        Me.FolderSelectorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FolderSelectorButton.Location = New System.Drawing.Point(272, 31)
        Me.FolderSelectorButton.Name = "FolderSelectorButton"
        Me.FolderSelectorButton.Size = New System.Drawing.Size(51, 23)
        Me.FolderSelectorButton.TabIndex = 10
        Me.FolderSelectorButton.Text = "検索"
        Me.FolderSelectorButton.UseVisualStyleBackColor = True
        '
        'FolderPathTextBox
        '
        Me.FolderPathTextBox.Enabled = False
        Me.FolderPathTextBox.Location = New System.Drawing.Point(29, 33)
        Me.FolderPathTextBox.Name = "FolderPathTextBox"
        Me.FolderPathTextBox.Size = New System.Drawing.Size(237, 19)
        Me.FolderPathTextBox.TabIndex = 9
        '
        'ApplyButton
        '
        Me.ApplyButton.Location = New System.Drawing.Point(248, 136)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyButton.TabIndex = 12
        Me.ApplyButton.Text = "適用"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "セカンダリマスタファイル"
        '
        'FileSelectorButton
        '
        Me.FileSelectorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FileSelectorButton.Location = New System.Drawing.Point(272, 87)
        Me.FileSelectorButton.Name = "FileSelectorButton"
        Me.FileSelectorButton.Size = New System.Drawing.Size(51, 23)
        Me.FileSelectorButton.TabIndex = 14
        Me.FileSelectorButton.Text = "検索"
        Me.FileSelectorButton.UseVisualStyleBackColor = True
        '
        'MasterFilePathTextBox
        '
        Me.MasterFilePathTextBox.Enabled = False
        Me.MasterFilePathTextBox.Location = New System.Drawing.Point(29, 89)
        Me.MasterFilePathTextBox.Name = "MasterFilePathTextBox"
        Me.MasterFilePathTextBox.Size = New System.Drawing.Size(237, 19)
        Me.MasterFilePathTextBox.TabIndex = 13
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'OriginalRepositoryConfigureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 184)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileSelectorButton)
        Me.Controls.Add(Me.MasterFilePathTextBox)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FolderSelectorButton)
        Me.Controls.Add(Me.FolderPathTextBox)
        Me.Name = "OriginalRepositoryConfigureForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "レポジトリ設定"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents FolderSelectorButton As Button
    Friend WithEvents FolderPathTextBox As TextBox
    Friend WithEvents ApplyButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FileSelectorButton As Button
    Friend WithEvents MasterFilePathTextBox As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
