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
            label8 = New Label()
            OtherNotSinglLabelComboBox = New ComboBox()
            label5 = New Label()
            SpecifiedByConditionComboBox = New ComboBox()
            label1 = New Label()
            EqualsToPrimaryComboBox = New ComboBox()
            label9 = New Label()
            NoLabelBehaviorComboBox = New ComboBox()
            tabControl1 = New TabControl()
            tabPage1 = New TabPage()
            tabPage2 = New TabPage()
            groupBox1 = New GroupBox()
            AcceptSingleSymbolLabelCeckBox = New CheckBox()
            AcceptC3LabelCheckBox = New CheckBox()
            label10 = New Label()
            CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
            CType(PrimaryItemStartUpDown, ComponentModel.ISupportInitialize).BeginInit()
            CType(PrimaryItemLengthUpDown, ComponentModel.ISupportInitialize).BeginInit()
            CType(PrimarySerialLengthUpDown, ComponentModel.ISupportInitialize).BeginInit()
            CType(PrimarySerialStartUpDown, ComponentModel.ISupportInitialize).BeginInit()
            tabControl1.SuspendLayout()
            tabPage1.SuspendLayout()
            tabPage2.SuspendLayout()
            groupBox1.SuspendLayout()
            SuspendLayout()
            ' 
            ' OkButton
            ' 
            OkButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            OkButton.DialogResult = DialogResult.OK
            OkButton.Location = New Point(257, 426)
            OkButton.Name = "OkButton"
            OkButton.Size = New Size(75, 23)
            OkButton.TabIndex = 1
            OkButton.Text = "OK"
            OkButton.UseVisualStyleBackColor = True
            AddHandler OkButton.Click, New EventHandler(AddressOf OkButton_Click)
            ' 
            ' PrimaryPrefixKeyTextBox
            ' 
            PrimaryPrefixKeyTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            PrimaryPrefixKeyTextBox.Location = New Point(28, 48)
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
            PrimaryItemStartUpDown.Location = New Point(28, 111)
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
            Label2.Location = New Point(26, 90)
            Label2.Name = "Label2"
            Label2.Size = New Size(85, 12)
            Label2.TabIndex = 2
            Label2.Text = "品番  開始位置"
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New Point(26, 150)
            Label3.Name = "Label3"
            Label3.Size = New Size(69, 12)
            Label3.TabIndex = 4
            Label3.Text = "品番 文字数"
            ' 
            ' PrimaryItemLengthUpDown
            ' 
            PrimaryItemLengthUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            PrimaryItemLengthUpDown.Location = New Point(28, 171)
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
            Label4.Location = New Point(26, 27)
            Label4.Name = "Label4"
            Label4.Size = New Size(96, 12)
            Label4.TabIndex = 0
            Label4.Text = "シンボル 開始文字"
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Location = New Point(26, 267)
            Label6.Name = "Label6"
            Label6.Size = New Size(81, 12)
            Label6.TabIndex = 8
            Label6.Text = "シリアル 文字数"
            ' 
            ' PrimarySerialLengthUpDown
            ' 
            PrimarySerialLengthUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            PrimarySerialLengthUpDown.Location = New Point(28, 288)
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
            Label7.Location = New Point(26, 210)
            Label7.Name = "Label7"
            Label7.Size = New Size(93, 12)
            Label7.TabIndex = 6
            Label7.Text = "シリアル 開始位置"
            ' 
            ' PrimarySerialStartUpDown
            ' 
            PrimarySerialStartUpDown.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            PrimarySerialStartUpDown.Location = New Point(28, 231)
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
            InputCancelButton.Location = New Point(338, 426)
            InputCancelButton.Name = "InputCancelButton"
            InputCancelButton.Size = New Size(81, 23)
            InputCancelButton.TabIndex = 2
            InputCancelButton.Text = "キャンセル"
            InputCancelButton.UseVisualStyleBackColor = True
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New Point(16, 158)
            label8.Name = "label8"
            label8.Size = New Size(227, 12)
            label8.TabIndex = 15
            label8.Text = "C-3 ラベルで上記のいずれにも該当しない品番"
            ' 
            ' OtherNotSinglLabelComboBox
            ' 
            OtherNotSinglLabelComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            OtherNotSinglLabelComboBox.FormattingEnabled = True
            OtherNotSinglLabelComboBox.Location = New Point(15, 179)
            OtherNotSinglLabelComboBox.Name = "OtherNotSinglLabelComboBox"
            OtherNotSinglLabelComboBox.Size = New Size(341, 20)
            OtherNotSinglLabelComboBox.TabIndex = 3
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Location = New Point(13, 94)
            label5.Name = "label5"
            label5.Size = New Size(127, 12)
            label5.TabIndex = 13
            label5.Text = "対応表で指定された品番"
            ' 
            ' SpecifiedByConditionComboBox
            ' 
            SpecifiedByConditionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            SpecifiedByConditionComboBox.FormattingEnabled = True
            SpecifiedByConditionComboBox.Location = New Point(15, 115)
            SpecifiedByConditionComboBox.Name = "SpecifiedByConditionComboBox"
            SpecifiedByConditionComboBox.Size = New Size(341, 20)
            SpecifiedByConditionComboBox.TabIndex = 2
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Point(13, 30)
            label1.Name = "label1"
            label1.Size = New Size(150, 12)
            label1.TabIndex = 11
            label1.Text = "プライマリラベルと一致する品番"
            ' 
            ' EqualsToPrimaryComboBox
            ' 
            EqualsToPrimaryComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            EqualsToPrimaryComboBox.FormattingEnabled = True
            EqualsToPrimaryComboBox.Location = New Point(15, 51)
            EqualsToPrimaryComboBox.Name = "EqualsToPrimaryComboBox"
            EqualsToPrimaryComboBox.Size = New Size(341, 20)
            EqualsToPrimaryComboBox.TabIndex = 1
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Location = New Point(32, 76)
            label9.Name = "label9"
            label9.Size = New Size(165, 12)
            label9.TabIndex = 9
            label9.Text = "セカンダリラベルの指定がない場合"
            ' 
            ' NoLabelBehaviorComboBox
            ' 
            NoLabelBehaviorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            NoLabelBehaviorComboBox.FormattingEnabled = True
            NoLabelBehaviorComboBox.Location = New Point(30, 97)
            NoLabelBehaviorComboBox.Name = "NoLabelBehaviorComboBox"
            NoLabelBehaviorComboBox.Size = New Size(341, 20)
            NoLabelBehaviorComboBox.TabIndex = 2
            ' 
            ' tabControl1
            ' 
            tabControl1.Controls.Add(tabPage1)
            tabControl1.Controls.Add(tabPage2)
            tabControl1.Location = New Point(12, 12)
            tabControl1.Name = "tabControl1"
            tabControl1.SelectedIndex = 0
            tabControl1.Size = New Size(408, 405)
            tabControl1.TabIndex = 0
            ' 
            ' tabPage1
            ' 
            tabPage1.Controls.Add(Label4)
            tabPage1.Controls.Add(PrimaryPrefixKeyTextBox)
            tabPage1.Controls.Add(PrimarySerialStartUpDown)
            tabPage1.Controls.Add(PrimaryItemStartUpDown)
            tabPage1.Controls.Add(Label7)
            tabPage1.Controls.Add(Label2)
            tabPage1.Controls.Add(Label3)
            tabPage1.Controls.Add(Label6)
            tabPage1.Controls.Add(PrimarySerialLengthUpDown)
            tabPage1.Controls.Add(PrimaryItemLengthUpDown)
            tabPage1.Location = New Point(4, 22)
            tabPage1.Name = "tabPage1"
            tabPage1.Padding = New Padding(3)
            tabPage1.Size = New Size(400, 379)
            tabPage1.TabIndex = 0
            tabPage1.Text = "プライマリラベル"
            tabPage1.UseVisualStyleBackColor = True
            ' 
            ' tabPage2
            ' 
            tabPage2.Controls.Add(groupBox1)
            tabPage2.Controls.Add(AcceptSingleSymbolLabelCeckBox)
            tabPage2.Controls.Add(AcceptC3LabelCheckBox)
            tabPage2.Controls.Add(label10)
            tabPage2.Controls.Add(NoLabelBehaviorComboBox)
            tabPage2.Controls.Add(label9)
            tabPage2.Location = New Point(4, 22)
            tabPage2.Name = "tabPage2"
            tabPage2.Padding = New Padding(3)
            tabPage2.Size = New Size(400, 379)
            tabPage2.TabIndex = 1
            tabPage2.Text = "セカンダリラベル"
            tabPage2.UseVisualStyleBackColor = True
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(SpecifiedByConditionComboBox)
            groupBox1.Controls.Add(label1)
            groupBox1.Controls.Add(EqualsToPrimaryComboBox)
            groupBox1.Controls.Add(label5)
            groupBox1.Controls.Add(label8)
            groupBox1.Controls.Add(OtherNotSinglLabelComboBox)
            groupBox1.Location = New Point(16, 141)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Size(369, 223)
            groupBox1.TabIndex = 3
            groupBox1.TabStop = False
            groupBox1.Text = "品番照合詳細"
            ' 
            ' AcceptSingleSymbolLabelCeckBox
            ' 
            AcceptSingleSymbolLabelCeckBox.AutoSize = True
            AcceptSingleSymbolLabelCeckBox.Location = New Point(147, 37)
            AcceptSingleSymbolLabelCeckBox.Name = "AcceptSingleSymbolLabelCeckBox"
            AcceptSingleSymbolLabelCeckBox.Size = New Size(87, 16)
            AcceptSingleSymbolLabelCeckBox.TabIndex = 1
            AcceptSingleSymbolLabelCeckBox.Text = "単一シンボル"
            AcceptSingleSymbolLabelCeckBox.UseVisualStyleBackColor = True
            ' 
            ' AcceptC3LabelCheckBox
            ' 
            AcceptC3LabelCheckBox.AutoSize = True
            AcceptC3LabelCheckBox.Location = New Point(31, 37)
            AcceptC3LabelCheckBox.Name = "AcceptC3LabelCheckBox"
            AcceptC3LabelCheckBox.Size = New Size(76, 16)
            AcceptC3LabelCheckBox.TabIndex = 0
            AcceptC3LabelCheckBox.Text = "C-3 ラベル"
            AcceptC3LabelCheckBox.UseVisualStyleBackColor = True
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Location = New Point(28, 16)
            label10.Name = "label10"
            label10.Size = New Size(81, 12)
            label10.TabIndex = 16
            label10.Text = "有効ラベル種類"
            ' 
            ' ModeConfigForm1
            ' 
            AcceptButton = OkButton
            AutoScaleDimensions = New SizeF(6.0F, 12.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(432, 461)
            Controls.Add(tabControl1)
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
            tabControl1.ResumeLayout(False)
            tabPage1.ResumeLayout(False)
            tabPage1.PerformLayout()
            tabPage2.ResumeLayout(False)
            tabPage2.PerformLayout()
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            ResumeLayout(False)

        End Sub

        Friend OkButton As Button
        Friend PrimaryPrefixKeyTextBox As TextBox
        Friend ErrorProvider As ErrorProvider
        Friend Label2 As Label
        Friend PrimaryItemStartUpDown As NumericUpDown
        Friend Label3 As Label
        Friend PrimaryItemLengthUpDown As NumericUpDown
        Friend Label4 As Label
        Friend Label6 As Label
        Friend PrimarySerialLengthUpDown As NumericUpDown
        Friend Label7 As Label
        Friend PrimarySerialStartUpDown As NumericUpDown
        Friend InputCancelButton As Button
        Friend label8 As Label
        Private OtherNotSinglLabelComboBox As ComboBox
        Friend label5 As Label
        Private SpecifiedByConditionComboBox As ComboBox
        Friend label1 As Label
        Private EqualsToPrimaryComboBox As ComboBox
        Friend label9 As Label
        Private NoLabelBehaviorComboBox As ComboBox
        Private tabControl1 As TabControl
        Private tabPage1 As TabPage
        Private tabPage2 As TabPage
        Private AcceptSingleSymbolLabelCeckBox As CheckBox
        Private AcceptC3LabelCheckBox As CheckBox
        Private label10 As Label
        Private groupBox1 As GroupBox
End Class