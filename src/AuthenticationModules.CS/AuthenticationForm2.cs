using System;
using System.Windows.Forms;

namespace AuthenticationModules
{
    partial class AuthenticationForm2
    {
        readonly User[] _users;

        public User SelectedUser => (User)UserInfoComboBox.SelectedItem;

        public AuthenticationForm2()
        {
            InitializeComponent();

            _users = AuthenticationModuleHelper.ReadUsersFile();

            UserInfoComboBox.DisplayMember = nameof(User.DisplayName);
            UserInfoComboBox.DataSource = _users;
            UserInfoComboBox.SelectedIndex = -1;
        }

        void UserInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = UserInfoComboBox.SelectedIndex >= 0;
        }

        void UserInfoComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OkButton.PerformClick();
        }

        public static User Authenticate()
        {
            using (var dialog = new AuthenticationForm2())
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