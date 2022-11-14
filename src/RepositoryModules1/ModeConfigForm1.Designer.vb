<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeConfigForm1
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
        Me.OkButton = New System.Windows.Forms.Button()
        Me.PrimaryPrefixKeyTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrimaryItemStartUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrimaryItemLengthUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrimarySerialLengthUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrimarySerialStartUpDown = New System.Windows.Forms.NumericUpDown()
        Me.InputCancelButton = New System.Windows.Forms.Button()
        Me.HasNoSecondaryRadio = New System.Windows.Forms.RadioButton()
        Me.IsSecondaryRequiredRadio = New System.Windows.Forms.RadioButton()
        Me.HasSecondaryRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryItemStartUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryItemLengthUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimarySerialLengthUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimarySerialStartUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Location = New System.Drawing.Point(209, 426)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 11
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'PrimaryPrefixKeyTextBox
        '
        Me.PrimaryPrefixKeyTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimaryPrefixKeyTextBox.Location = New System.Drawing.Point(34, 47)
        Me.PrimaryPrefixKeyTextBox.Name = "PrimaryPrefixKeyTextBox"
        Me.PrimaryPrefixKeyTextBox.Size = New System.Drawing.Size(318, 19)
        Me.PrimaryPrefixKeyTextBox.TabIndex = 1
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PrimaryItemStartUpDown
        '
        Me.PrimaryItemStartUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimaryItemStartUpDown.Location = New System.Drawing.Point(34, 110)
        Me.PrimaryItemStartUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimaryItemStartUpDown.Name = "PrimaryItemStartUpDown"
        Me.PrimaryItemStartUpDown.Size = New System.Drawing.Size(318, 19)
        Me.PrimaryItemStartUpDown.TabIndex = 3
        Me.PrimaryItemStartUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrimaryItemStartUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "品番  開始位置"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "品番 文字数"
        '
        'PrimaryItemLengthUpDown
        '
        Me.PrimaryItemLengthUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimaryItemLengthUpDown.Location = New System.Drawing.Point(34, 170)
        Me.PrimaryItemLengthUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimaryItemLengthUpDown.Name = "PrimaryItemLengthUpDown"
        Me.PrimaryItemLengthUpDown.Size = New System.Drawing.Size(318, 19)
        Me.PrimaryItemLengthUpDown.TabIndex = 5
        Me.PrimaryItemLengthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrimaryItemLengthUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "主シンボル開始文字"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 12)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "シリアル 文字数"
        '
        'PrimarySerialLengthUpDown
        '
        Me.PrimarySerialLengthUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimarySerialLengthUpDown.Location = New System.Drawing.Point(34, 287)
        Me.PrimarySerialLengthUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimarySerialLengthUpDown.Name = "PrimarySerialLengthUpDown"
        Me.PrimarySerialLengthUpDown.Size = New System.Drawing.Size(318, 19)
        Me.PrimarySerialLengthUpDown.TabIndex = 9
        Me.PrimarySerialLengthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrimarySerialLengthUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "シリアル 開始位置"
        '
        'PrimarySerialStartUpDown
        '
        Me.PrimarySerialStartUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimarySerialStartUpDown.Location = New System.Drawing.Point(34, 230)
        Me.PrimarySerialStartUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimarySerialStartUpDown.Name = "PrimarySerialStartUpDown"
        Me.PrimarySerialStartUpDown.Size = New System.Drawing.Size(318, 19)
        Me.PrimarySerialStartUpDown.TabIndex = 7
        Me.PrimarySerialStartUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrimarySerialStartUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'InputCancelButton
        '
        Me.InputCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.InputCancelButton.Location = New System.Drawing.Point(290, 426)
        Me.InputCancelButton.Name = "InputCancelButton"
        Me.InputCancelButton.Size = New System.Drawing.Size(81, 23)
        Me.InputCancelButton.TabIndex = 12
        Me.InputCancelButton.Text = "キャンセル"
        Me.InputCancelButton.UseVisualStyleBackColor = True
        '
        'HasNoSecondaryRadio
        '
        Me.HasNoSecondaryRadio.AutoSize = True
        Me.HasNoSecondaryRadio.Location = New System.Drawing.Point(6, 27)
        Me.HasNoSecondaryRadio.Name = "HasNoSecondaryRadio"
        Me.HasNoSecondaryRadio.Size = New System.Drawing.Size(42, 16)
        Me.HasNoSecondaryRadio.TabIndex = 0
        Me.HasNoSecondaryRadio.TabStop = True
        Me.HasNoSecondaryRadio.Text = "なし"
        Me.HasNoSecondaryRadio.UseVisualStyleBackColor = True
        '
        'IsSecondaryRequiredRadio
        '
        Me.IsSecondaryRequiredRadio.AutoSize = True
        Me.IsSecondaryRequiredRadio.Location = New System.Drawing.Point(107, 27)
        Me.IsSecondaryRequiredRadio.Name = "IsSecondaryRequiredRadio"
        Me.IsSecondaryRequiredRadio.Size = New System.Drawing.Size(47, 16)
        Me.IsSecondaryRequiredRadio.TabIndex = 2
        Me.IsSecondaryRequiredRadio.TabStop = True
        Me.IsSecondaryRequiredRadio.Text = "必須"
        Me.IsSecondaryRequiredRadio.UseVisualStyleBackColor = True
        '
        'HasSecondaryRadio
        '
        Me.HasSecondaryRadio.AutoSize = True
        Me.HasSecondaryRadio.Location = New System.Drawing.Point(54, 27)
        Me.HasSecondaryRadio.Name = "HasSecondaryRadio"
        Me.HasSecondaryRadio.Size = New System.Drawing.Size(47, 16)
        Me.HasSecondaryRadio.TabIndex = 1
        Me.HasSecondaryRadio.TabStop = True
        Me.HasSecondaryRadio.Text = "任意"
        Me.HasSecondaryRadio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.HasNoSecondaryRadio)
        Me.GroupBox1.Controls.Add(Me.HasSecondaryRadio)
        Me.GroupBox1.Controls.Add(Me.IsSecondaryRequiredRadio)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "副シンボル (C-3 ラベル)"
        '
        'ModeRepositorySettingsForm1
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InputCancelButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PrimarySerialLengthUpDown)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PrimarySerialStartUpDown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PrimaryItemLengthUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PrimaryItemStartUpDown)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PrimaryPrefixKeyTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModeRepositorySettingsForm1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "モード設定"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryItemStartUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryItemLengthUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimarySerialLengthUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimarySerialStartUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkButton As Button
    Friend WithEvents PrimaryPrefixKeyTextBox As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents PrimaryItemStartUpDown As NumericUpDown
    Friend WithEvents ExtractPartCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PrimaryItemLengthUpDown As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PrimarySerialLengthUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents PrimarySerialStartUpDown As NumericUpDown
    Friend WithEvents InputCancelButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HasNoSecondaryRadio As RadioButton
    Friend WithEvents HasSecondaryRadio As RadioButton
    Friend WithEvents IsSecondaryRequiredRadio As RadioButton
End Class
