using System;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using yazlab11;

namespace yazlab11
{
    public partial class Main : Form
    {
        IFirebaseClient client;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(credential.config);
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            var data = new UserDatas()
            {
                Username = textbox_username.Text,
                Password = textbox_password.Text
            };
            FirebaseResponse result = await client.GetTaskAsync("Accounts/" + textbox_username.Text);
            check_credential(result.ResultAs<UserDatas>());
        }

        private void check_credential(UserDatas dataObject)
        {
            if (textbox_username.Text.Equals(dataObject.Username) && textbox_password.Text.Equals(dataObject.Password))
            {
                CargosStatus form = new CargosStatus();
                form.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username or password is not correct!");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            KayitOl form = new KayitOl();
            form.Visible = true;
        }

        private void btn_lostpassword_Click(object sender, EventArgs e)
        {
                       ResetPassword form = new ResetPassword();
            form.Visible = true;
        }
    }
}
