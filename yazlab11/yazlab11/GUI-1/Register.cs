using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace yazlab11
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private async void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new UserDatas
                {
                    Email = textbox_email.Text,
                    Username = textbox_username.Text,
                    Password = textbox_password.Text
                };
                IFirebaseClient client = new FireSharp.FirebaseClient(credential.config);
                SetResponse response = await client.SetTaskAsync("Accounts/" + textbox_username.Text, data);
                UserDatas.result = response.ResultAs<UserDatas>();
                MessageBox.Show("Registaration is completed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
