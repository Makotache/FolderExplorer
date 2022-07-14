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
            int indexdebut;
            int indexfin;
            RegistryKey CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extension + "\\UserChoice", false);
            JObject conversion = JObject.Parse(File.ReadAllText(FolderExplorer_form.ProgId));
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
                    if (!progid.Contains("."))
                    {
                        CurrentUser = Registry.ClassesRoot.OpenSubKey(progid + "\\Application");
                        xretour = CurrentUser.GetValue("ApplicationName", false).ToString();
                        CurrentUser.Close();
                        //lecture json de conversion
                        indexdebut = xretour.IndexOf("Microsoft");
                        indexfin = xretour.IndexOf("_");
                        if (indexdebut != -1)
                        {
                            if (indexfin != -1)
                            {
                                xretour = xretour.Substring(indexdebut, indexfin - indexdebut);
                            }
                            else
                            {
                                xretour = xretour.Substring(indexdebut);
                            }
                        }
                    }
                    else
                    {
                        xretour = progid.Substring(progid.IndexOf("\\") + 1);
                    }
                    
                    
                    Console.WriteLine(xretour);
                    //xretour = conversion.Property(xretour).Value.ToString();
                    JProperty prop = conversion.Property(xretour);
                    if (prop != null)
                    {
                        xretour = prop.Value.ToString();
                    }                        
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
                //xretour = conversion.Property(xretour).Value.ToString();
                JProperty prop = conversion.Property(xretour);
                if (prop != null)
                {
                    xretour = prop.Value.ToString();
                }
            }
            Console.WriteLine(xretour);
            return xretour;
        }

        public static string ExtensionToIco(string extension)
        {
            string xtailleko ="";
            return xtailleko;
        }
    }
}
