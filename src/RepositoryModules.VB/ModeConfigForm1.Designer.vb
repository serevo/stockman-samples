<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModeConfigForm1
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
        components = New ComponentModel.Container()
        OkButton = New Button()
        PrimaryPrefixKeyTextBox = New TextBox()
        ErrorProvider = New ErrorProvider(components)
        PrimaryItemStartUpDown = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        PrimaryItemLengthUpDown = New NumericUpDown()
        Label4 = New Label()
        Label6 = New Label()
        PrimarySerialLengthUpDown = New NumericUpDown()
        Label7 = New Label()
        PrimarySerialStartUpDown = New NumericUpDown()
        InputCancelButton = New Button()
        IsSecondaryLabelRequiredCheck = New CheckBox()
        groupBox1 = New GroupBox()
        groupBox2 = New GroupBox()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        CType(PrimaryItemStartUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(PrimaryItemLengthUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(PrimarySerialLengthUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(PrimarySerialStartUpDown, ComponentModel.ISupportInitialize).BeginInit()
        groupBox1.SuspendLayout()
        groupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' OkButton
        ' 
        OkButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        OkButton.DialogResult = DialogResult.OK
        OkButton.Location = New Point(257, 500)
        OkButton.Name = "OkButton"
        OkButton.Size = New Size(75, 23)
        OkButton.TabIndex = 2
        OkButton.Text = "OK"
        OkButton.UseVisualStyleBackColor = True
        AddHandler OkButton.Click, New EventHandler(AddressOf OkButton_Click)
        ' 
        ' PrimaryPrefixKeyTextBox
        ' 
        PrimaryPrefixKeyTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PrimaryPrefixKeyTextBox.Location = New Point(25, 55)
        PrimaryPrefixKeyTextBox.Name = "PrimaryPrefixKeyTextBox"
        PrimaryPrefixKeyTextBox.Size = New Size(341, 19)
        PrimaryPrefixKeyTextBox.TabIndex = 1
        ' 
        ' ErrorProvider
        ' 
        ErrorProvider.ContainerControl = Me
        ' 
        ' PrimaryItemStartUpDown
        ' 
        PrimaryItemStartUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PrimaryItemStartUpDown.Location = New Point(25, 118)
        PrimaryItemStartUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        PrimaryItemStartUpDown.Name = "PrimaryItemStartUpDown"
        PrimaryItemStartUpDown.Size = New Size(341, 19)
        PrimaryItemStartUpDown.TabIndex = 3
        PrimaryItemStartUpDown.TextAlign = HorizontalAlignment.Right
        PrimaryItemStartUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 12)
        Label2.TabIndex = 2
        Label2.Text = "品番  開始位置"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 12)
        Label3.TabIndex = 4
        Label3.Text = "品番 文字数"
        ' 
        ' PrimaryItemLengthUpDown
        ' 
        PrimaryItemLengthUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PrimaryItemLengthUpDown.Location = New Point(25, 178)
        PrimaryItemLengthUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        PrimaryItemLengthUpDown.Name = "PrimaryItemLengthUpDown"
        PrimaryItemLengthUpDown.Size = New Size(341, 19)
        PrimaryItemLengthUpDown.TabIndex = 5
        PrimaryItemLengthUpDown.TextAlign = HorizontalAlignment.Right
        PrimaryItemLengthUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 12)
        Label4.TabIndex = 0
        Label4.Text = "シンボル 開始文字"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 12)
        Label6.TabIndex = 8
        Label6.Text = "シリアル 文字数"
        ' 
        ' PrimarySerialLengthUpDown
        ' 
        PrimarySerialLengthUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PrimarySerialLengthUpDown.Location = New Point(25, 295)
        PrimarySerialLengthUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        PrimarySerialLengthUpDown.Name = "PrimarySerialLengthUpDown"
        PrimarySerialLengthUpDown.Size = New Size(341, 19)
        PrimarySerialLengthUpDown.TabIndex = 9
        PrimarySerialLengthUpDown.TextAlign = HorizontalAlignment.Right
        PrimarySerialLengthUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 217)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 12)
        Label7.TabIndex = 6
        Label7.Text = "シリアル 開始位置"
        ' 
        ' PrimarySerialStartUpDown
        ' 
        PrimarySerialStartUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PrimarySerialStartUpDown.Location = New Point(25, 238)
        PrimarySerialStartUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        PrimarySerialStartUpDown.Name = "PrimarySerialStartUpDown"
        PrimarySerialStartUpDown.Size = New Size(341, 19)
        PrimarySerialStartUpDown.TabIndex = 7
        PrimarySerialStartUpDown.TextAlign = HorizontalAlignment.Right
        PrimarySerialStartUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' InputCancelButton
        ' 
        InputCancelButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        InputCancelButton.DialogResult = DialogResult.Cancel
        InputCancelButton.Location = New Point(338, 500)
        InputCancelButton.Name = "InputCancelButton"
        InputCancelButton.Size = New Size(81, 23)
        InputCancelButton.TabIndex = 3
        InputCancelButton.Text = "キャンセル"
        InputCancelButton.UseVisualStyleBackColor = True
        ' 
        ' IsSecondaryLabelRequiredCheck
        ' 
        IsSecondaryLabelRequiredCheck.AutoSize = True
        IsSecondaryLabelRequiredCheck.CheckAlign = ContentAlignment.TopLeft
        IsSecondaryLabelRequiredCheck.Location = New Point(28, 43)
        IsSecondaryLabelRequiredCheck.Name = "IsSecondaryLabelRequiredCheck"
        IsSecondaryLabelRequiredCheck.Size = New Size(255, 16)
        IsSecondaryLabelRequiredCheck.TabIndex = 0
        IsSecondaryLabelRequiredCheck.Text = "必須にする (品名が一致する C-3 ラベルが必要)"
        IsSecondaryLabelRequiredCheck.UseVisualStyleBackColor = True
        ' 
        ' groupBox1
        ' 
        groupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        groupBox1.Controls.Add(Label4)
        groupBox1.Controls.Add(PrimaryPrefixKeyTextBox)
        groupBox1.Controls.Add(PrimaryItemStartUpDown)
        groupBox1.Controls.Add(Label2)
        groupBox1.Controls.Add(Label6)
        groupBox1.Controls.Add(PrimaryItemLengthUpDown)
        groupBox1.Controls.Add(PrimarySerialLengthUpDown)
        groupBox1.Controls.Add(Label3)
        groupBox1.Controls.Add(Label7)
        groupBox1.Controls.Add(PrimarySerialStartUpDown)
        groupBox1.Location = New Point(22, 23)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Size(386, 345)
        groupBox1.TabIndex = 0
        groupBox1.TabStop = False
        groupBox1.Text = "プライマリ ラベル"
        ' 
        ' groupBox2
        ' 
        groupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        groupBox2.Controls.Add(IsSecondaryLabelRequiredCheck)
        groupBox2.Location = New Point(22, 387)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Size(386, 89)
        groupBox2.TabIndex = 1
        groupBox2.TabStop = False
        groupBox2.Text = "セカンダリ ラベル"
        ' 
        ' ModeConfigForm1
        ' 
        AcceptButton = OkButton
        AutoScaleDimensions = New SizeF(6.0F, 12.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 535)
        Controls.Add(groupBox2)
        Controls.Add(groupBox1)
        Controls.Add(InputCancelButton)
        Controls.Add(OkButton)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ModeConfigForm1"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "モード設定"
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        CType(PrimaryItemStartUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(PrimaryItemLengthUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(PrimarySerialLengthUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(PrimarySerialStartUpDown, ComponentModel.ISupportInitialize).EndInit()
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        groupBox2.ResumeLayout(False)
        groupBox2.PerformLayout()
        ResumeLayout(False)

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
    Friend WithEvents IsSecondaryLabelRequiredCheck As CheckBox
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents groupBox1 As GroupBox
End Class
