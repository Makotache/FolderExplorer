using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    internal static class OpenWith
    {

        public static string ExtensionToPrg (string extension)
        {
            string progid;
            string xretour = "";
            RegistryKey CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extension + "\\UserChoice", false);
            if (CurrentUser != null)
            {
                try
                {
                    progid = CurrentUser.GetValue("ProgId", false).ToString();
                }
                catch
                {
                    progid = "";
                }
                if (progid != "")
                {
                    CurrentUser = Registry.ClassesRoot.OpenSubKey(progid + "\\Application");
                    xretour = CurrentUser.GetValue("ApplicationName", false).ToString();
                    CurrentUser.Close();
                }
            }
            else
            {
                CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extension + "\\OpenWithList", false);
                try
                {
                    xretour = CurrentUser.GetValue("a", false).ToString();
                }
                catch
                {
                    xretour = "";
                }
                CurrentUser.Close();
            }
            //lecture json de conversion
            JObject Parametrages = JObject.Parse(File.ReadAllText();
            return xretour;
        }

        public static string ExtensionToIco(string extension)
        {
            string xtailleko ="";
            return xtailleko;
        }
    }
}
