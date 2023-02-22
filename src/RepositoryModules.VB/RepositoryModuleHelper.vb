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
        Dim filePath = MySettings.Default.SecondaryConditionFilePath

        If Not File.Exists(filePath) Then Return Array.Empty(Of SecondaryCondition)()

        Dim text = File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis"))

        Return text.Split({Environment.NewLine}, StringSplitOptions.None).[Select](Function(x) x.Split(","c)).Where(Function(x) x.Length = 2).[Select](Function(x) New SecondaryCondition(x(0), x(1))).ToArray()
    End Function

    Public Function ShowAlert(message As String) As Boolean
        Return MessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes
    End Function

    Public Sub ShowError(message As String)
        MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function CompareIgnoreCase(a As String, b As String) As Boolean
        Return String.Compare(a, b, True) = 0
    End Function
End Module
