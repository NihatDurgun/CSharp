using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace yazlab11
{
    public partial class ResetPassword : Form
    {
        IFirebaseClient client;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private async void button_reset_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(credential.config);

            var userdata = new UserDatas()
            {
                Username = textbox_username.Text,
                Password = textbox_email.Text
            };
            FirebaseResponse response = await client.GetTaskAsync("Accounts/" + textbox_username.Text);
            resetAccount(response.ResultAs<UserDatas>());
        }

        private async void resetAccount(UserDatas userDatas_Object)
        {
            if (userDatas_Object.Username.Equals(textbox_username.Text))
            {
                var data2 = new UserDatas()
                {
                    Username = userDatas_Object.Username,
                    Email = userDatas_Object.Email,
                    Password = textbox_password.Text
                };
                FirebaseResponse response2 = await client.UpdateTaskAsync("Accounts/" + textbox_username.Text, data2);
                UserDatas result = response2.ResultAs<UserDatas>();
            }
            else
            {
                MessageBox.Show("Mail is incorrect!");
            }
        }
    }
}
