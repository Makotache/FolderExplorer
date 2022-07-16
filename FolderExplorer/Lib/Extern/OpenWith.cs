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

        public static string ExtensionToPrg(string extension)
        {
            string progid;
            string xretour = "";
            int indexdebut;
            int indexfin;
            bool amodif = false;
            RegistryKey CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extension + "\\UserChoice", false);
            JObject conversion = JObject.Parse(File.ReadAllText(FolderExplorer_form.ProgId));
            if (CurrentUser != null)
            //cas avec user choice
            {
                try
                {
                    progid = CurrentUser.GetValue("ProgId", false).ToString();
                }
                catch
                {
                    progid = "";
                }
                CurrentUser.Close();
                if (progid != "")
                //cas avec progid
                {
                    //plusieurs possibilites pour progid
                    //1 - un code commence par AppX
                    //2 - Applications\nomdu logiciel : Ex Applications\WDMap.exe
                    //3 - le nom du logiciel directement avec Extension : Ex ChromeHTML
                    //3 - Nom du logiciel directement : Ex WinRAR
                    //3 - Nom du logiciel.extension : Ex VLC.mp3
                    switch(progid.Substring(0,4))
                    {
                        case "AppX":
                            //1
                            CurrentUser = Registry.ClassesRoot.OpenSubKey(progid + "\\Application");
                            try
                            {
                                xretour = CurrentUser.GetValue("ApplicationName", false).ToString();
                            }
                            catch
                            {
                                xretour = "";
                            }
                            CurrentUser.Close();
                            if (xretour != "")
                            {
                                //plusieurs possibilites
                                //ms-ressource://Windows.nomlogiciel/ressources
                                //ms-ressource://Microsoft.Windows.nomlogiciel/ressources
                                //nom directement
                                //ms-ressource://Microsoft.Windowsnomlogiciel/ressources
                                //ms-ressource://Microsoft.nomlogiciel/ressources
                                //ms-ressource://MicrosoftWindows.nomlogiciel/ressources
                                indexdebut = xretour.IndexOf("://");
                                indexfin = xretour.IndexOf("/res",StringComparison.OrdinalIgnoreCase);
                                if (indexdebut !=-1)
                                {
                                    xretour = xretour.Substring(indexdebut, indexfin - indexdebut);
                                    xretour = xretour.Substring(3, xretour.Length - 3); //on enleve les :// devant
                                    //xretour = xretour.Remove(xretour.Length - 1, 1); //on enleve le / de fin
                                }
                            }
                            break;
                        case "Appl":
                            //2
                            xretour = progid.Substring(12, progid.Length - 11);
                            break;
                        default:
                            //3
                            xretour = progid;
                            break;
                    }
                }
                else
                //cas sans progid
                {
                    //normalement pas possible mais on laisse au cas ou
                    xretour = "";
                }
            }
            else
            //cas sans user choice
            {
                CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extension + "\\OpenWithList", false);
                //en general dans a on a le logiciel directement
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
            //a decommenter une fois progid.json rempli
            //xretour = conversion.Property(xretour).Value.ToString();
            //JProperty prop = conversion.Property(xretour);
            //if (prop != null)
            //{
            //    xretour = prop.Value.ToString();
            //}
            //fin truc a decommenter



           
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
