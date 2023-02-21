using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RepositoryModules
{
    static class IOHelper
    {
        public static void WriteImage(string path, byte[] image)
        {
            using (var ms = new MemoryStream(image))
            using (var bitmap = new Bitmap(ms))
            {
                bitmap.Save(path, ImageFormat.Jpeg);
            }
        }
    }
}
