using System.Windows.Forms;

namespace RepositoryModules
{
    sealed class MessageHelper
    {
        public static bool AlertShow(string message) 
        {
            return MessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static void ErrorShow(string message) 
        {
            MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
