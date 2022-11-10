Imports Storex
Imports System.Text.Json

Public Class FixedLengthRepositoryModeSettingForm
    Public errors As New List(Of String)

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

        'If String.IsNullOrEmpty(PrimaryStartWithTextBox.Text.TrimEnd) Then
        '    ErrorProvider.SetError(PrimaryStartWithTextBox, "入力してください")
        '    errors.Add(NameOf(PrimaryStartWithTextBox))
        '    OkButton.Enabled = False
        'End If

    End Sub

    Private Sub PrimaryStartWithTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrimaryStartWithTextBox.TextChanged
        If String.IsNullOrEmpty(PrimaryStartWithTextBox.Text.TrimEnd) Then
            ErrorProvider.SetError(PrimaryStartWithTextBox, "入力してください")
            errors.Add(NameOf(PrimaryStartWithTextBox))
        Else
            ErrorProvider.SetError(PrimaryStartWithTextBox, Nothing)
            errors.Remove(NameOf(PrimaryStartWithTextBox))
        End If

        OkButton.Enabled = errors.Count = 0

    End Sub

    Public Shared Sub Show(mode As IMode)
        Dim dialog = New FixedLengthRepositoryModeSettingForm(mode)

        If dialog.ShowDialog(Form.ActiveForm) = Windows.Forms.DialogResult.OK Then

            mode.RepositorySettings = New FixedLengthRepositoryModeSetting() With
            {
                .PrimaryStartWithFormat = dialog.PrimaryStartWithTextBox.Text,
                .PrimaryValueLength = dialog.PrimaryLengthNumericUpDown.Value,
                .PartStartIndex = dialog.PartStartIndexNumericUpDown.Value,
                .PartLength = dialog.PartLengthNumericUpDown.Value,
                .SerialStartIndex = dialog.SerialStartIndexNumericUpDown.Value,
                .SerialLength = dialog.SerialLengthNumericUpDown.Value
            }

        End If
    End Sub

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles SerialStartIndexNumericUpDown.ValueChanged, SerialLengthNumericUpDown.ValueChanged, PrimaryLengthNumericUpDown.ValueChanged, PartStartIndexNumericUpDown.ValueChanged, PartLengthNumericUpDown.ValueChanged
        If PrimaryLengthNumericUpDown.Value < PartStartIndexNumericUpDown.Value - 1 Then
            ErrorProvider.SetError(PartStartIndexNumericUpDown, "開始位置が文字長さを超えています")
            errors.Add(NameOf(PartStartIndexNumericUpDown))
        Else
            ErrorProvider.SetError(PartStartIndexNumericUpDown, Nothing)
            errors.Remove(NameOf(PartStartIndexNumericUpDown))
        End If

        If PrimaryLengthNumericUpDown.Value < PartStartIndexNumericUpDown.Value - 1 + PartLengthNumericUpDown.Value Then
            ErrorProvider.SetError(PartLengthNumericUpDown, "指定位置がシンボル文字長さを超えています")
            errors.Add(NameOf(PartLengthNumericUpDown))

        Else
            ErrorProvider.SetError(PartLengthNumericUpDown, Nothing)
            errors.Remove(NameOf(PartLengthNumericUpDown))
        End If

        If PrimaryLengthNumericUpDown.Value < SerialStartIndexNumericUpDown.Value - 1 Then
            ErrorProvider.SetError(SerialStartIndexNumericUpDown, "開始位置が文字長さを超えています")
            errors.Add(NameOf(SerialStartIndexNumericUpDown))
        Else
            ErrorProvider.SetError(SerialStartIndexNumericUpDown, Nothing)
            errors.Remove(NameOf(SerialStartIndexNumericUpDown))
        End If

        If PrimaryLengthNumericUpDown.Value < SerialStartIndexNumericUpDown.Value - 1 + SerialLengthNumericUpDown.Value Then
            ErrorProvider.SetError(SerialLengthNumericUpDown, "指定位置がシンボル文字長さを超えています")
            errors.Add(NameOf(SerialLengthNumericUpDown))

        Else
            ErrorProvider.SetError(SerialLengthNumericUpDown, Nothing)
            errors.Remove(NameOf(SerialLengthNumericUpDown))

        End If


        OkButton.Enabled = errors.Count = 0
    End Sub
End Class