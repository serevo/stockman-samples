Imports Storex
Imports System.Text.Json

Public Class FixedLengthRepositoryModeSettingForm
    Sub New(mode As IMode)
        InitializeComponent()

        Dim definition As FixedLengthRepositoryModeSetting = Nothing

        If TypeOf mode.RepositorySettings Is JsonElement Then
            Dim str = JsonSerializer.Serialize(mode.RepositorySettings)

            Try
                definition = JsonSerializer.Deserialize(Of FixedLengthRepositoryModeSetting)(str)
            Catch ex As JsonException
            End Try
        ElseIf TypeOf mode.RepositorySettings Is FixedLengthRepositoryModeSetting Then
            definition = CType(mode.RepositorySettings, FixedLengthRepositoryModeSetting)
        End If

        If definition IsNot Nothing Then
            PrimaryStartWithTextBox.Text = definition.PrimaryStartWithFormat
            PrimaryLengthNumericUpDown.Value = definition.PrimaryValueLength
            PartStartIndexNumericUpDown.Value = definition.PartStartIndex
            PartLengthNumericUpDown.Value = definition.PartLength

            SerialStartIndexNumericUpDown.Value = definition.SerialStartIndex
            SerialLengthNumericUpDown.Value = definition.SerialLength
        End If

        If String.IsNullOrEmpty(PrimaryStartWithTextBox.Text.TrimEnd) Then
            ErrorProvider.SetError(PrimaryStartWithTextBox, "入力してください")
            OkButton.Enabled = False
        End If

    End Sub

    Private Sub PrimaryStartWithTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrimaryStartWithTextBox.TextChanged
        If String.IsNullOrEmpty(PrimaryStartWithTextBox.Text.TrimEnd) Then
            ErrorProvider.SetError(PrimaryStartWithTextBox, "入力してください")
        Else
            ErrorProvider.SetError(PrimaryStartWithTextBox, String.Empty)
        End If
    End Sub

    Public Shared Sub Show(mode As IMode)
        Dim dialog = New FixedLengthRepositoryModeSettingForm(mode)

        If dialog.ShowDialog(Form.ActiveForm) = Windows.Forms.DialogResult.OK Then

            mode.RepositorySettings = New FixedLengthRepositoryModeSetting() With
            {
                .PrimaryStartWithFormat = dialog.PrimaryStartWithTextBox.Text,
                .PartStartIndex = If(dialog.ExtractPartCheckBox.Checked, dialog.PartStartIndexNumericUpDown.Value, Nothing),
                .PartLength = If(dialog.ExtractPartCheckBox.Checked, dialog.PartLengthNumericUpDown.Value, Nothing)
            }

        End If
    End Sub

    Private Sub ExtractPartCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles ExtractPartCheckBox.CheckStateChanged
        PartStartIndexNumericUpDown.Enabled = PartLengthNumericUpDown.Enabled = ExtractPartCheckBox.Checked
    End Sub

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PrimaryLengthNumericUpDown.ValueChanged, SerialStartIndexNumericUpDown.ValueChanged, SerialLengthNumericUpDown.ValueChanged, PartStartIndexNumericUpDown.ValueChanged, PartLengthNumericUpDown.ValueChanged

    End Sub
End Class