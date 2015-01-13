using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryTraverser.Lib;

namespace HardDriveFileListMakerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady)
                {
                    var paths = DirectoryScanner.Traverse(d.Name);
                    File.AppendAllLines(@"D:\SearchResult.txt", paths);
                }
            }
        }
    }
}
