<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CsvSelectNameAutenticationForm
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
        Me.UserInfoComboBox = New System.Windows.Forms.ComboBox()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.CsvFilterControl = New ModuleSampleForVB.CsvFilterControl()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputCancelButton
        '
        Me.InputCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.InputCancelButton.Location = New System.Drawing.Point(327, 116)
        Me.InputCancelButton.Name = "InputCancelButton"
        Me.InputCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.InputCancelButton.TabIndex = 11
        Me.InputCancelButton.Text = "キャンセル"
        Me.InputCancelButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Enabled = False
        Me.OkButton.Location = New System.Drawing.Point(216, 116)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(78, 26)
        Me.OkButton.TabIndex = 10
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'UserInfoComboBox
        '
        Me.UserInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserInfoComboBox.FormattingEnabled = True
        Me.UserInfoComboBox.Location = New System.Drawing.Point(47, 80)
        Me.UserInfoComboBox.Name = "UserInfoComboBox"
        Me.UserInfoComboBox.Size = New System.Drawing.Size(326, 20)
        Me.UserInfoComboBox.TabIndex = 12
        '
        'ElementHost1
        '
        Me.ElementHost1.Location = New System.Drawing.Point(47, 12)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(326, 42)
        Me.ElementHost1.TabIndex = 13
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Me.CsvFilterControl
        '
        'CsvSelectNameAutenticationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 170)
        Me.Controls.Add(Me.ElementHost1)
        Me.Controls.Add(Me.UserInfoComboBox)
        Me.Controls.Add(Me.InputCancelButton)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "CsvSelectNameAutenticationForm"
        Me.Text = "CsvSelectNameAutenticationForm"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputCancelButton As Button
    Friend WithEvents OkButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents UserInfoComboBox As ComboBox
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend CsvFilterControl As CsvFilterControl
End Class
