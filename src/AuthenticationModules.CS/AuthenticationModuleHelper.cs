using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuthenticationModules
{
    static class AuthenticationModuleHelper
    {
        public static void PickUsersFileAndSaveToSetting()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "ユーザーリストファイルを選択してください";
                dialog.FileName = MySettings.Default.UsersFilePath;
                dialog.Filter = "CSVファイル|*.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MySettings.Default.UsersFilePath = dialog.FileName;
                    MySettings.Default.Save();
                }
            }
        }

        public static User[] ReadUsersFile()
        {
            var filePath = MySettings.Default.UsersFilePath;

            if (string.IsNullOrEmpty(filePath))
                return null;

            var text = File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis"));

            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(x => x.Split(',')).Where(x => x.Length == 2).Select(x => new User(x[0], x[1])).ToArray();
        }
    }
}