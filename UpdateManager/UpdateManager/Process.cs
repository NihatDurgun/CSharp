using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.ComponentModel;
using IWshRuntimeLibrary;
using System.Diagnostics;

namespace UpdateManager
{
    public partial class Process : Form
    {
        const string StartupMenu_Path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
        string ZipPath = "";
        
        bool GenerateIcon=false;
        bool isCanceled = false;
        int Mode;
        string Path;
        WebClient wc;
        public Process(bool GenerateIcon,string Path,int Mode)
        {

            //Mode 0 first setup,Mode 1 update
            InitializeComponent();
            this.GenerateIcon = GenerateIcon;
            this.Path = Path;
            this.Mode = Mode;
            ZipPath = this.Path + "\\vf.zip";
            Start();
        }

        public void Start()
        {
            using (wc = new WebClient())
            {
                string URL = new Extra().GameZIP_URL;
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadCompleted;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri(URL),
                    // Param2 = Path to save
                    @ZipPath
                );
                Console.WriteLine(new System.Uri(URL) + ":" + @ZipPath);
            }
        }

        internal static void Start(string v)
        {
            throw new NotImplementedException();
        }

        internal static void Start(string v, object p)
        {
            throw new NotImplementedException();
        }

        internal static Process Start(ProcessStartInfo processInfo)
        {
            throw new NotImplementedException();
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void wc_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (isCanceled == false)
            {
                label2.Text = "Kuruluyor...";
                Extract();
                button3.Enabled = false;
                progressBar1.Value = 90;
            }
            else
            {
                System.IO.File.Delete(@ZipPath);
            }
            
        }

        private void Extract()
        {
            ZipFile.ExtractToDirectory(ZipPath, Path);
            System.IO.File.Delete(@ZipPath);
            Console.WriteLine(GenerateIcon);
            if (GenerateIcon == true)
            {
                object shDesktop = (object)"Desktop";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\VirtualFair.lnk";
                CreateShortcut(shortcutAddress);
            }
            Manager manager = new Manager(StartupMenu_Path+ @"\VirtualFair");
            manager.DirIsExits();

            WshShell shell2 = new WshShell();
            string shortcutAddress2 = StartupMenu_Path + @"\VirtualFair.lnk";
            string shortcutAddress3 = StartupMenu_Path + @"\VirtualFair\VirtualFair.lnk";
            CreateShortcut(shortcutAddress2);
            CreateShortcut(shortcutAddress3);
            progressBar1.Value = 100;
            Result result = new Result(true);
            result.Show();
            this.Hide();
        }

        private void CreateShortcut(string shortcutAddress)
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Tradeey-VirtualFair";
            shortcut.WorkingDirectory = Path;
            shortcut.TargetPath = Path+ @"\VirtualFair.exe";
            shortcut.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isCanceled = true;
            Uninstall UManager = new Uninstall();
            UManager.Start(Path);
            wc.CancelAsync();
            wc.Dispose();
            this.Hide();
            Result result = new Result(false);
            result.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
