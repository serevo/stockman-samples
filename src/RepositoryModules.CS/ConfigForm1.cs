using System;
using System.IO;
using System.Windows.Forms;

namespace RepositoryModules
{
    partial class ConfigForm1
    {
        public ConfigForm1()
        {
            InitializeComponent();
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.SetError(FileButton, null);

            ErrorProvider.SetError(FolderButton, null);

            ErrorProvider.SetError(SecondaryConditionFileButton, null);

            if (!File.Exists(FileTextBox.Text))
            {
                ErrorProvider.SetError(FileButton, "ファイルを選択してください。");

                return;
            }

            if (!Directory.Exists(FolderTextBox.Text))
            {
                ErrorProvider.SetError(FolderButton, "フォルダを選択してください。");

                return;
            }

            DialogResult = DialogResult.OK;
        }

        void FileButton_Click(object sender, EventArgs e)
        {
            FileDialog.FileName = FileTextBox.Text;

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                FileTextBox.Text = FileDialog.FileName;
            }
        }

        void FolderButton_Click(object sender, EventArgs e)
        {
            FolderDialog.SelectedPath = FileTextBox.Text;

            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                FolderTextBox.Text = FolderDialog.SelectedPath;
            }
        }

        void SecondaryConditionFileButton_Click(object sender, EventArgs e)
        {
            SecondaryConditionFileDialog.FileName = SecondaryConditionFileTextBox.Text;

            if (SecondaryConditionFileDialog.ShowDialog() == DialogResult.OK)
            {
                SecondaryConditionFileTextBox.Text = SecondaryConditionFileDialog.FileName;
            }
        }

        public static void Configure()
        {
            using (var Form = new ConfigForm1())
            {
                Form.FileTextBox.Text = MySettings.Default.FilePath;
                Form.FolderTextBox.Text = MySettings.Default.FolderPath;
                Form.SecondaryConditionFileTextBox.Text = MySettings.Default.SecondaryConditionFilePath;

                if (Form.ShowDialog() == DialogResult.OK)
                {
                    MySettings.Default.FilePath = Form.FileTextBox.Text;
                    MySettings.Default.FolderPath = Form.FolderTextBox.Text;
                    MySettings.Default.SecondaryConditionFilePath = Form.SecondaryConditionFileTextBox.Text;
                    MySettings.Default.Save();
                }
            }
        }
    }
}