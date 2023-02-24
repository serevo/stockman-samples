using System;
using System.Collections.Generic;
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

        public static IReadOnlyDictionary<string, IEnumerable<string>> ReadSecondaryConditionsFile()
        {
            var filePath = MySettings.Default.SecondaryConditionFilePath;

            var text = File.Exists(filePath) ? File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis")) : string.Empty;

            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .Select(x => x.Split(','))
                .Where(x => x.Length == 2)
                .Select(x => new { primaryItemNumber = x[0], secondaryItemNumber = x[1] })
                .GroupBy(x => x.primaryItemNumber, StringComparer.CurrentCultureIgnoreCase)
                .ToDictionary(o => o.Key, o => o.Select(oo => oo.secondaryItemNumber).ToArray().AsEnumerable(), StringComparer.CurrentCultureIgnoreCase)
                ;
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
