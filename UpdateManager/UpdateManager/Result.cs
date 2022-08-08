using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UpdateManager
{
    public partial class Result : Form
    {
        bool isDone = false;
        const string StartupMenu_Path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
        public Result(bool isDone)
        {
            InitializeComponent();
            Console.WriteLine("Setup Result:" + isDone);
            label_IsDone.Visible = false;
            label_IsFailed.Visible = false;
            if (isDone == true)
            {
                checkBox1.Enabled = true;
                label_IsDone.Visible = true;
                label_IsFailed.Visible = false;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                checkBox1.Enabled = false;
                label_IsDone.Visible = false;
                label_IsFailed.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                StartAPP();
            }
            Extra extra = new Extra();
            extra.CloseUM();
        }

        private static void StartAPP()
        {
            try
            {
                string shortcutAddress2 = StartupMenu_Path + @"\VirtualFair.lnk";
                Console.WriteLine(shortcutAddress2);

                System.Diagnostics.Process proc = System.Diagnostics.Process.Start(shortcutAddress2);
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
