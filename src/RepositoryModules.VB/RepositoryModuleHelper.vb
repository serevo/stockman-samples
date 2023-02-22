Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

Friend Module RepositoryModuleHelper
    Public Sub WriteImage(Path As String, Image As Byte())

        Using MS = New MemoryStream(Image)

            Using BM = New Bitmap(MS)

                BM.Save(Path, ImageFormat.Jpeg)

            End Using
        End Using
    End Sub

    Public Function ReadSecondaryConditionsFile() As SecondaryCondition()

        Dim FilePath = MySettings.Default.SecondaryConditionFilePath

        If Not File.Exists(FilePath) Then

            Return Array.Empty(Of SecondaryCondition)()
        End If

        Dim Text = File.ReadAllText(FilePath, Encoding.GetEncoding("shift_jis"))

        Return Text.Split({Environment.NewLine}, StringSplitOptions.None) _
            .Select(Function(x) x.Split(","c)) _
            .Where(Function(x) x.Length = 2) _
            .Select(Function(x) New SecondaryCondition(x(0), x(1))) _
            .ToArray()
    End Function

    Public Function ShowAlert(Message As String) As Boolean

        Return MessageBox.Show(Message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes
    End Function

    Public Sub ShowError(Message As String)

        MessageBox.Show(Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function EqualsIgnoreCase(A As String, B As String) As Boolean

        Return String.Equals(A, B, StringComparison.CurrentCultureIgnoreCase)
    End Function
End Module
