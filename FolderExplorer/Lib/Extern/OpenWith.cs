﻿using Microsoft.Win32;
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
            bool amodif = false;
            RegistryKey CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extension + "\\UserChoice", false);
            JObject conversion = JObject.Parse(File.ReadAllText(FolderExplorer_form.ProgId));
            if (CurrentUser != null)
            {
                //cas avec user choice
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
                    if (!progid.Contains(".exe"))
                        //cas application microsoft
                    {
                        CurrentUser = Registry.ClassesRoot.OpenSubKey(progid + "\\Application");
                        try
                        {
                            xretour = CurrentUser.GetValue("ApplicationName", false).ToString();
                        }
                        catch
                        {
                            xretour = progid;
                        }
                        
                        CurrentUser.Close();
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
                        //cas pas application microsoft

                    {
                        xretour = progid.Substring(progid.IndexOf("\\") + 1);
                    }
                    
                    
                    Console.WriteLine(xretour);
                    //lecture json de conversion
                    xretour = conversion.Property(xretour).Value.ToString();
                }
            }
            else
            {
                //cas sans user choice
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
                xretour = conversion.Property(xretour).Value.ToString();
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
