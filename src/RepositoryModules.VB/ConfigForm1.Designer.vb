<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigForm1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.SecondaryConditionFileButton = New Button()
        Me.SecondaryConditionFileTextBox = New TextBox()
        Me.label3 = New Label()
        Me.SecondaryConditionFileDialog = New OpenFileDialog()
        CType(Me.ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' InputCancelButton
        ' 
        Me.InputCancelButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Me.InputCancelButton.DialogResult = DialogResult.Cancel
        Me.InputCancelButton.Location = New Point(277, 197)
        Me.InputCancelButton.Name = "InputCancelButton"
        Me.InputCancelButton.Size = New Size(75, 23)
        Me.InputCancelButton.TabIndex = 7
        Me.InputCancelButton.Text = "キャンセル"
        Me.InputCancelButton.UseVisualStyleBackColor = True
        ' 
        ' OkButton
        ' 
        Me.OkButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Me.OkButton.Location = New Point(176, 195)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New Size(78, 26)
        Me.OkButton.TabIndex = 6
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        AddHandler Me.OkButton.Click, New EventHandler(AddressOf OkButton_Click)
        ' 
        ' ErrorProvider
        ' 
        Me.ErrorProvider.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(95, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "概要データ ファイル"
        ' 
        ' FileTextBox
        ' 
        Me.FileTextBox.Location = New Point(27, 44)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New Size(283, 19)
        Me.FileTextBox.TabIndex = 1
        ' 
        ' FileButton
        ' 
        Me.FileButton.AutoSize = True
        Me.FileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.FileButton.Location = New Point(316, 41)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New Size(21, 22)
        Me.FileButton.TabIndex = 2
        Me.FileButton.Text = "..."
        Me.FileButton.UseVisualStyleBackColor = True
        AddHandler FileButton.Click, New EventHandler(AddressOf FileButton_Click)
        ' 
        ' FolderButton
        ' 
        Me.FolderButton.AutoSize = True
        Me.FolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.FolderButton.Location = New Point(316, 96)
        Me.FolderButton.Name = "FolderButton"
        Me.FolderButton.Size = New Size(21, 22)
        Me.FolderButton.TabIndex = 5
        Me.FolderButton.Text = "..."
        Me.FolderButton.UseVisualStyleBackColor = True
        AddHandler FolderButton.Click, New EventHandler(AddressOf FolderButton_Click)
        ' 
        ' FolderTextBox
        ' 
        Me.FolderTextBox.Location = New Point(27, 97)
        Me.FolderTextBox.Name = "FolderTextBox"
        Me.FolderTextBox.Size = New Size(283, 19)
        Me.FolderTextBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(25, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(96, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "詳細データ フォルダ"
        ' 
        ' FileDialog
        ' 
        Me.FileDialog.FileName = "OpenFileDialog1"
        Me.FileDialog.Filter = "タブ区切り | *.tsv"
        ' 
        ' SecondaryConditionFileButton
        ' 
        Me.SecondaryConditionFileButton.AutoSize = True
        Me.SecondaryConditionFileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.SecondaryConditionFileButton.Location = New Point(316, 148)
        Me.SecondaryConditionFileButton.Name = "SecondaryConditionFileButton"
        Me.SecondaryConditionFileButton.Size = New Size(21, 22)
        Me.SecondaryConditionFileButton.TabIndex = 10
        Me.SecondaryConditionFileButton.Text = "..."
        Me.SecondaryConditionFileButton.UseVisualStyleBackColor = True
        AddHandler Me.SecondaryConditionFileButton.Click, New EventHandler(AddressOf SecondaryConditionFileButton_Click)
        ' 
        ' SecondaryConditionFileTextBox
        ' 
        Me.SecondaryConditionFileTextBox.Location = New Point(27, 150)
        Me.SecondaryConditionFileTextBox.Name = "SecondaryConditionFileTextBox"
        Me.SecondaryConditionFileTextBox.Size = New Size(283, 19)
        Me.SecondaryConditionFileTextBox.TabIndex = 9
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New Point(25, 135)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(131, 12)
        Me.label3.TabIndex = 8
        Me.label3.Text = "品名対応表データ ファイル"
        ' 
        ' SecondaryConditionFileDialog
        ' 
        Me.SecondaryConditionFileDialog.FileName = "OpenFileDialog1"
        Me.SecondaryConditionFileDialog.Filter = "カンマ区切り | *.csv"
        ' 
        ' ConfigForm1
        ' 
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New SizeF(6.0F, 12.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.InputCancelButton
        Me.ClientSize = New Size(363, 233)
        Me.Controls.Add(Me.SecondaryConditionFileButton)
        Me.Controls.Add(Me.SecondaryConditionFileTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.FolderButton)
        Me.Controls.Add(Me.FolderTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FileButton)
        Me.Controls.Add(Me.FileTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputCancelButton)
        Me.Controls.Add(Me.OkButton)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigurationForm1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "モジュール設定"
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

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
    Friend WithEvents SecondaryConditionFileButton As Button
    Friend WithEvents SecondaryConditionFileTextBox As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents SecondaryConditionFileDialog As OpenFileDialog
End Class
