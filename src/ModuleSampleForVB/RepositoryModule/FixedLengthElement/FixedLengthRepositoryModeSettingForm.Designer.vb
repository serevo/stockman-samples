<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixedLengthRepositoryModeSettingForm
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
        Me.PrimaryStartWithTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PartStartIndexNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PartLengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrimaryLengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SerialLengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SerialStartIndexNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartStartIndexNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialStartIndexNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Location = New System.Drawing.Point(256, 232)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 5
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'PrimaryStartWithTextBox
        '
        Me.PrimaryStartWithTextBox.Location = New System.Drawing.Point(145, 33)
        Me.PrimaryStartWithTextBox.Name = "PrimaryStartWithTextBox"
        Me.PrimaryStartWithTextBox.Size = New System.Drawing.Size(175, 19)
        Me.PrimaryStartWithTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "プライマリシンボルの条件設定"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PartStartIndexNumericUpDown
        '
        Me.PartStartIndexNumericUpDown.Location = New System.Drawing.Point(145, 97)
        Me.PartStartIndexNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PartStartIndexNumericUpDown.Name = "PartStartIndexNumericUpDown"
        Me.PartStartIndexNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.PartStartIndexNumericUpDown.TabIndex = 7
        Me.PartStartIndexNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PartStartIndexNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "部品名開始位置"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "文字数"
        '
        'PartLengthNumericUpDown
        '
        Me.PartLengthNumericUpDown.Location = New System.Drawing.Point(145, 129)
        Me.PartLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PartLengthNumericUpDown.Name = "PartLengthNumericUpDown"
        Me.PartLengthNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.PartLengthNumericUpDown.TabIndex = 9
        Me.PartLengthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PartLengthNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "シンボル開始文字"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "文字数"
        '
        'PrimaryLengthNumericUpDown
        '
        Me.PrimaryLengthNumericUpDown.Location = New System.Drawing.Point(145, 62)
        Me.PrimaryLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimaryLengthNumericUpDown.Name = "PrimaryLengthNumericUpDown"
        Me.PrimaryLengthNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.PrimaryLengthNumericUpDown.TabIndex = 13
        Me.PrimaryLengthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrimaryLengthNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "文字数"
        '
        'SerialLengthNumericUpDown
        '
        Me.SerialLengthNumericUpDown.Location = New System.Drawing.Point(145, 195)
        Me.SerialLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SerialLengthNumericUpDown.Name = "SerialLengthNumericUpDown"
        Me.SerialLengthNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.SerialLengthNumericUpDown.TabIndex = 16
        Me.SerialLengthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SerialLengthNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "シリアル開始位置"
        '
        'SerialStartIndexNumericUpDown
        '
        Me.SerialStartIndexNumericUpDown.Location = New System.Drawing.Point(145, 163)
        Me.SerialStartIndexNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SerialStartIndexNumericUpDown.Name = "SerialStartIndexNumericUpDown"
        Me.SerialStartIndexNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.SerialStartIndexNumericUpDown.TabIndex = 14
        Me.SerialStartIndexNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SerialStartIndexNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FixedLengthRepositoryModeSettingForm
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 271)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SerialLengthNumericUpDown)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SerialStartIndexNumericUpDown)
        Me.Controls.Add(Me.PrimaryLengthNumericUpDown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PartLengthNumericUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PartStartIndexNumericUpDown)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PrimaryStartWithTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FixedLengthRepositoryModeSettingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "モードレポジトリ設定"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartStartIndexNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartLengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryLengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialLengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialStartIndexNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkButton As Button
    Friend WithEvents PrimaryStartWithTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents PartStartIndexNumericUpDown As NumericUpDown
    Friend WithEvents ExtractPartCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PartLengthNumericUpDown As NumericUpDown
    Friend WithEvents PrimaryLengthNumericUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SerialLengthNumericUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents SerialStartIndexNumericUpDown As NumericUpDown
End Class
