using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepositoryModules
{
    static class RepositoryModuleHelper
    {
        public static void WriteImage(string path, byte[] image)
        {
            using (var ms = new MemoryStream(image))
            using (var bitmap = new Bitmap(ms))
            {
                bitmap.Save(path, ImageFormat.Jpeg);
            }
        }

        public static SecondaryCondition[] ReadSecondaryConditionsFile()
        {
            var filePath = MySettings.Default.SecondaryConditionFilePath;

            if (!File.Exists(filePath))
                return Array.Empty<SecondaryCondition>();

            var text = File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis"));

            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .Select(x => x.Split(','))
                .Where(x => x.Length == 2)
                .Select(x => new SecondaryCondition(x[0], x[1]))
                .ToArray();
        }

        public static bool ShowAlert(string message) => MessageBox.Show(message, "警告"
            , MessageBoxButtons.YesNo
            , MessageBoxIcon.Exclamation
            , MessageBoxDefaultButton.Button2
            ) == DialogResult.Yes;

        public static void ShowError(string message) => MessageBox.Show(message, "エラー"
            , MessageBoxButtons.OK
            , MessageBoxIcon.Error
            );

        public static bool EqualsIgnoreCase(string a, string b) => string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
    }
}
