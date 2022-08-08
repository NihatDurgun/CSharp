using System;
using System.Windows.Forms;
using System.IO;

namespace UpdateManager
{
    class Extra
    {
        public string GameZIP_URL = "https://tradeey.com/game/app/vf.zip";
        public string GameJSON_URL = "https://tradeey.com/game/app/version.json";
        public string[] Dirs = { "MonoBleedingEdge", "VirtualFair_Data" };
        public string[] Files = { "UnityCrashHandler64.exe", "UnityPlayer.dll",
            "VirtualFair.exe", "WinPixEventRuntime.dll","version.json","manager.exe"};
        public void CloseUM()
        {
            System.Windows.Forms.Application.Exit();
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(System.IO.Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
