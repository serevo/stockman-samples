Imports Storex
Imports System.Text.Json

Public Class HeaderRepositoryModeSettingForm
    Sub New(mode As IMode)
        InitializeComponent()

        Dim definition As HeaderRepositoryModeSetting = Nothing

        If TypeOf mode.RepositorySettings Is JsonElement Then
            Dim str = JsonSerializer.Serialize(mode.RepositorySettings)

            Try
                definition = JsonSerializer.Deserialize(Of HeaderRepositoryModeSetting)(str)
            Catch ex As JsonException
            End Try
        ElseIf TypeOf mode.RepositorySettings Is HeaderRepositoryModeSetting Then
            definition = CType(mode.RepositorySettings, HeaderRepositoryModeSetting)
        End If

        If definition IsNot Nothing Then
            PrimaryStartWithTextBox.Text = definition.PrimaryStartWithFormat

            If definition.PartStartIndex.HasValue And definition.PartLength.HasValue Then
                ExtractPartCheckBox.Checked = True
                StartIndexNumericUpDown.Value = definition.PartStartIndex.Value
                LengthNumericUpDown.Value = definition.PartLength.Value
            Else
                StartIndexNumericUpDown.Enabled = LengthNumericUpDown.Enabled = False
            End If

        End If

        If String.IsNullOrEmpty(PrimaryStartWithTextBox.Text.TrimEnd) Then
            ErrorProvider.SetError(PrimaryStartWithTextBox, "入力してください")
            OkButton.Enabled = False
        End If

    End Sub

    Private Sub PrimaryStartWithTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrimaryStartWithTextBox.TextChanged
        If String.IsNullOrEmpty(PrimaryStartWithTextBox.Text.TrimEnd) Then
            ErrorProvider.SetError(PrimaryStartWithTextBox, "入力してください")
            OkButton.Enabled = False
        Else
            ErrorProvider.SetError(PrimaryStartWithTextBox, String.Empty)
            OkButton.Enabled = True
        End If
    End Sub

    Public Shared Sub Show(mode As IMode)
        Dim dialog = New HeaderRepositoryModeSettingForm(mode)

        If dialog.ShowDialog(Form.ActiveForm) = Windows.Forms.DialogResult.OK Then

            mode.RepositorySettings = New HeaderRepositoryModeSetting() With
            {
                .PrimaryStartWithFormat = dialog.PrimaryStartWithTextBox.Text
            }

        End If
    End Sub

    Private Sub ExtractPartCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ExtractPartCheckBox.CheckStateChanged
        StartIndexNumericUpDown.Enabled = LengthNumericUpDown.Enabled = ExtractPartCheckBox.Checked
    End Sub
End Class