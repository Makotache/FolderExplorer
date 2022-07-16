using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FolderExplorer
{
    internal static class OpenWith
    {

        [DllImport("Shlwapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint AssocQueryString(AssocF flags, AssocStr str, string pszAssoc, string pszExtra, [Out] StringBuilder pszOut, [In][Out] ref uint pcchOut);
        public static string ExtensionToPrg(string extension)
        {
            return FileExtentionInfo(AssocStr.FriendlyAppName, extension);
        }

        public static Image ElementToImage(string extension)
        {
            string appli_exe;
            if (extension.Contains("\\"))
            {//on a un chemin complet d'une appli
                appli_exe = extension;
            }
            else
            {//on a une extension
                appli_exe = FileExtentionInfo(AssocStr.Executable, extension);
            }
            //recuperation de l'icone
            if (appli_exe.Contains("exe"))
            {
                return Icon.ExtractAssociatedIcon(appli_exe).ToBitmap();
            }
            else
            {
                return null;
            }
        }

        public static Icon ElementToIco(string extension)
        {
            string appli_exe = FileExtentionInfo(AssocStr.Executable, extension);
            if (appli_exe.Contains("exe"))
            {
                return Icon.ExtractAssociatedIcon(appli_exe);
            }
            else
            {
                return null;
            }
        }

        public static string DocNameToFriendly(string extension)
        {
            return FileExtentionInfo(AssocStr.FriendlyDocName, extension);
        }

        public enum AssocStr
        {
            Command = 1,
            Executable,
            FriendlyDocName,
            FriendlyAppName,
            NoOpen,
            ShellNewValue,
            DDECommand,
            DDEIfExec,
            DDEApplication,
            DDETopic
        }
        public enum AssocF
        {
            Init_NoRemapCLSID = 0x1,
            Init_ByExeName = 0x2,
            Open_ByExeName = 0x2,
            Init_DefaultToStar = 0x4,
            Init_DefaultToFolder = 0x8,
            NoUserSettings = 0x10,
            NoTruncate = 0x20,
            Verify = 0x40,
            RemapRunDll = 0x80,
            NoFixUps = 0x100,
            IgnoreBaseClass = 0x200
        }

        public static string FileExtentionInfo(AssocStr assocStr, string doctype)
        {
            uint pcchOut = 0;
            AssocQueryString(AssocF.Verify, assocStr, doctype, null, null, ref pcchOut);

            StringBuilder pszOut = new StringBuilder((int)pcchOut);
            AssocQueryString(AssocF.Verify, assocStr, doctype, null, pszOut, ref pcchOut);
            return pszOut.ToString();
        }
    }
}
