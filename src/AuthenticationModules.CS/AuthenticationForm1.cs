using System;
using System.Linq;
using System.Windows.Forms;

namespace AuthenticationModules
{
    partial class AuthenticationForm1
    {
        readonly User[] _users;

        public User SelectedUser { get; set; }

        public AuthenticationForm1()
        {
            InitializeComponent();

            _users = AuthenticationModuleHelper.ReadUsersFile();

            if (_users is null)
            {
                ErrorProvider.SetError(NumTextBox, "ユーザーリストファイルが正しく設定されていないかまたはファイルを読み取れません。");

                OkButton.Enabled = false;
            }
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            var selectedUsers = _users.Where(x => (x.Id ?? "") == (NumTextBox.Text ?? "")).ToArray();

            if (selectedUsers.Length == 0)
            {
                ErrorProvider.SetError(NumTextBox, "Idと一致するユーザーが見つかりませんでした");
            }

            else if (selectedUsers.Length > 1)
            {
                ErrorProvider.SetError(NumTextBox, "Idと一致するユーザーが複数存在し特定できません");
            }

            else
            {
                SelectedUser = selectedUsers[0];

                DialogResult = DialogResult.OK;
            }
        }

        public static User Authenticate()
        {
            using (var dialog = new AuthenticationForm1())
            {

                if (dialog.ShowDialog(ActiveForm) == DialogResult.OK)
                {

                    return dialog.SelectedUser;
                }
                else
                {

                    return null;
                }
            }
        }
    }
}