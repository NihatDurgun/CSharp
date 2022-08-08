using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateManager
{
    class Manager
    {
        private string Path = "";

        public Manager(string Path)
        {
            this.Path = Path;
        }

        public void DirIsExits()
        {
            if (!Directory.Exists(@Path))
            {
                Directory.CreateDirectory(@Path);
            }
        }


        public int ControlFiles(string[] files,string[] searching)
        {
            int result = 0;
            foreach(var nextItem in files)
            {
                foreach (var searchItem in searching)
                {
                    string SearchedPath = Path + "\\" + searchItem;
                    if (SearchedPath == nextItem)
                    {
                        result++;
                    }
                }
            }
            return result;
        }


        public bool DirIsEmpty()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            string[] dirs = System.IO.Directory.GetDirectories(@Path);
            string[] files = System.IO.Directory.GetFiles(@Path);

            sw.Stop();
            Extra extra = new Extra();
            int result1 = ControlFiles(dirs, extra.Dirs);
            int result2 = ControlFiles(files, extra.Files);

            Console.WriteLine(result1 + ":" + result2);
            if (result1 == 0 && result2 == 0)
                return true;
            else
                return false;

        }

    }
}
