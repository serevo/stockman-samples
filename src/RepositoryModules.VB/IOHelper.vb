Imports System.Drawing.Imaging
Imports System.IO

Friend Module IOHelper

    Public Sub WriteImage(Path As String, Image As Byte())

        Using MS = New MemoryStream(Image)

            Using BM = New Bitmap(MS)

                BM.Save(Path, ImageFormat.Jpeg)

            End Using
        End Using
    End Sub
End Module
