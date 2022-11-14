<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm1
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
        Me.InputCancelButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.FileButton = New System.Windows.Forms.Button()
        Me.FolderButton = New System.Windows.Forms.Button()
        Me.FolderTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputCancelButton
        '
        Me.InputCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.InputCancelButton.Location = New System.Drawing.Point(277, 149)
        Me.InputCancelButton.Name = "InputCancelButton"
        Me.InputCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.InputCancelButton.TabIndex = 7
        Me.InputCancelButton.Text = "キャンセル"
        Me.InputCancelButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkButton.Location = New System.Drawing.Point(176, 147)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(78, 26)
        Me.OkButton.TabIndex = 6
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "概要データ ファイル"
        '
        'FileTextBox
        '
        Me.FileTextBox.Location = New System.Drawing.Point(27, 44)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(283, 19)
        Me.FileTextBox.TabIndex = 1
        '
        'FileButton
        '
        Me.FileButton.AutoSize = True
        Me.FileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FileButton.Location = New System.Drawing.Point(316, 41)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New System.Drawing.Size(21, 22)
        Me.FileButton.TabIndex = 2
        Me.FileButton.Text = "..."
        Me.FileButton.UseVisualStyleBackColor = True
        '
        'FolderButton
        '
        Me.FolderButton.AutoSize = True
        Me.FolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FolderButton.Location = New System.Drawing.Point(316, 96)
        Me.FolderButton.Name = "FolderButton"
        Me.FolderButton.Size = New System.Drawing.Size(21, 22)
        Me.FolderButton.TabIndex = 5
        Me.FolderButton.Text = "..."
        Me.FolderButton.UseVisualStyleBackColor = True
        '
        'FolderTextBox
        '
        Me.FolderTextBox.Location = New System.Drawing.Point(27, 99)
        Me.FolderTextBox.Name = "FolderTextBox"
        Me.FolderTextBox.Size = New System.Drawing.Size(283, 19)
        Me.FolderTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "詳細データ フォルダ"
        '
        'FileDialog
        '
        Me.FileDialog.FileName = "OpenFileDialog1"
        Me.FileDialog.Filter = "タブ区切り | *.tsv"
        '
        'ConfigurationForm1
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.InputCancelButton
        Me.ClientSize = New System.Drawing.Size(363, 185)
        Me.Controls.Add(Me.FolderButton)
        Me.Controls.Add(Me.FolderTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FileButton)
        Me.Controls.Add(Me.FileTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputCancelButton)
        Me.Controls.Add(Me.OkButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigurationForm1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "モジュール設定"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputCancelButton As Button
    Friend WithEvents OkButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents FolderButton As Button
    Friend WithEvents FolderTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FileButton As Button
    Friend WithEvents FileTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderDialog As FolderBrowserDialog
    Friend WithEvents FileDialog As OpenFileDialog
End Class
