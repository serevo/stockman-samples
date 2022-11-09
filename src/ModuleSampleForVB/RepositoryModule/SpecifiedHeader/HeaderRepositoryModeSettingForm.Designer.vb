<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderRepositoryModeSettingForm
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
        Me.ExtractPartCheckBox = New System.Windows.Forms.CheckBox()
        Me.StartIndexNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartIndexNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Location = New System.Drawing.Point(275, 221)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 5
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'PrimaryStartWithTextBox
        '
        Me.PrimaryStartWithTextBox.Location = New System.Drawing.Point(37, 47)
        Me.PrimaryStartWithTextBox.Name = "PrimaryStartWithTextBox"
        Me.PrimaryStartWithTextBox.Size = New System.Drawing.Size(272, 19)
        Me.PrimaryStartWithTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "プライマリと判定する開始文字を入力してください"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ExtractPartCheckBox
        '
        Me.ExtractPartCheckBox.AutoSize = True
        Me.ExtractPartCheckBox.Location = New System.Drawing.Point(37, 94)
        Me.ExtractPartCheckBox.Name = "ExtractPartCheckBox"
        Me.ExtractPartCheckBox.Size = New System.Drawing.Size(112, 16)
        Me.ExtractPartCheckBox.TabIndex = 6
        Me.ExtractPartCheckBox.Text = "部品名を抜き出す"
        Me.ExtractPartCheckBox.UseVisualStyleBackColor = True
        '
        'StartIndexNumericUpDown
        '
        Me.StartIndexNumericUpDown.Location = New System.Drawing.Point(124, 128)
        Me.StartIndexNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StartIndexNumericUpDown.Name = "StartIndexNumericUpDown"
        Me.StartIndexNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.StartIndexNumericUpDown.TabIndex = 7
        Me.StartIndexNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.StartIndexNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "開始位置"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "文字数"
        '
        'LengthNumericUpDown
        '
        Me.LengthNumericUpDown.Location = New System.Drawing.Point(124, 153)
        Me.LengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LengthNumericUpDown.Name = "LengthNumericUpDown"
        Me.LengthNumericUpDown.Size = New System.Drawing.Size(123, 19)
        Me.LengthNumericUpDown.TabIndex = 9
        Me.LengthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LengthNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HeaderRepositoryModeSettingForm
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 256)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LengthNumericUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StartIndexNumericUpDown)
        Me.Controls.Add(Me.ExtractPartCheckBox)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PrimaryStartWithTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HeaderRepositoryModeSettingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "モードレポジトリ設定"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartIndexNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkButton As Button
    Friend WithEvents PrimaryStartWithTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents StartIndexNumericUpDown As NumericUpDown
    Friend WithEvents ExtractPartCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LengthNumericUpDown As NumericUpDown
End Class
