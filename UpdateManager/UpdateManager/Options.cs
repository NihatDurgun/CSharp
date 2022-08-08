using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UpdateManager
{
    public partial class Options : Form
    {
        string Path = "";
        public Options()
        {
            InitializeComponent();
           Path = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Path = folderBrowserDialog1.SelectedPath;
            textBox1.Text = Path;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(Path);
            manager.DirIsExits();
            bool result = manager.DirIsEmpty();
            Console.WriteLine(result);
            string Title = "Devam Etmek istiyor musunuz?";
            string Text = "Hedeflenen dizinde önceki kurulumdan kalan dosyalar bulundu,projeyi ilkten kurmak için kaldırması gerekmektedir.Kabul ediyor musunuz?";
            if (result == false)
            {
                DialogResult dialogResult = MessageBox.Show(Text, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Uninstall UManager = new Uninstall();
                    UManager.Start(Path);

                    Process process = new Process(checkBox1.Checked,Path,0);
                    process.Show();
                    this.Hide();
                }
            }
            else
            {
                Process process = new Process(checkBox1.Checked, Path,0);
                process.Show();
                this.Hide();
            }
        }
    }
}
