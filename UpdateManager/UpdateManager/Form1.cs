using System;
using System.Net;
using System.Windows.Forms;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace UpdateManager
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
            var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Manager manager = new Manager(CurrentDirectory);
            bool result = manager.DirIsEmpty();
            if(result == true)
            {
                button3.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            string Title = "Devam Etmek istiyor musunuz?";
            string Text = "Uygulanın bütün verileri kalıcı olarak kaldırılacaktır,devam etmek istiyor musunuz?";
            DialogResult dialogResult = MessageBox.Show(Text, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                Uninstall UManager = new Uninstall();
                UManager.Start(CurrentDirectory);
                DialogResult dialogResult2 = MessageBox.Show("Uygulama başarıyla kaldırıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if(dialogResult2 == DialogResult.OK)
                {
                    this.Close();
                }   
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options OManager = new Options();
            this.Hide();
            OManager.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Manager manager = new Manager(CurrentDirectory);
            manager.DirIsExits();
            bool result = manager.DirIsEmpty();

            Console.WriteLine(result);
            if (result == false)
            {
                string URL = new Extra().GameJSON_URL;
                using (WebClient wc = new WebClient())
                {
                    string jsonServer = wc.DownloadString(URL);
                    //Console.WriteLine(json);
                    dynamic server = JsonConvert.DeserializeObject(jsonServer);
                    var ServerVersion = server.version;

                    string jsonClient = wc.DownloadString(@".\version.json");
                    dynamic client = JsonConvert.DeserializeObject(jsonClient);
                    var ClientVersion = client.version;

                    if (ServerVersion > ClientVersion)
                    {
                        Uninstall UManager = new Uninstall();
                        UManager.Start(CurrentDirectory);

                        Process process = new Process(false, CurrentDirectory, 1);
                        process.Show();
                        this.Hide();
                    }
                    else
                    {
                        string Title = "Uygulamanız Güncel";
                        string Text = "Programın en güncel sürümünü kullanıyorsunuz!";
                        DialogResult dialogResult = MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(dialogResult == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                 }

            }
        }
    }
}

public class JSONResponse
{
    public string version { get; set; }
}
