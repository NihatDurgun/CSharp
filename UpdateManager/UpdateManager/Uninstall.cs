using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace UpdateManager
{
    class Uninstall
    {
        const string StartupMenu_Path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\VirtualFair";
        
        public void Start(string CurrentDirectory)
        {
            Extra extra = new Extra();
            foreach(var item in extra.Files)
            {
                try
                {
                    string Path = CurrentDirectory +"\\"+ item;
                    Console.WriteLine(Path);
                    File.Delete(Path);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
            }

            foreach (var item in extra.Dirs)
            {
                try
                {
                    string Path = CurrentDirectory + "\\" + item;
                    Console.WriteLine(Path);
                    var dir = new DirectoryInfo(@Path);
                    dir.Delete(true);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
            }
            if (CurrentDirectory != StartupMenu_Path)
            {
                Start(StartupMenu_Path);
            }
        }
    }
}

