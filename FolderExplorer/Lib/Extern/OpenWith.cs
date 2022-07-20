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
        #region Shlwapi
        [DllImport("Shlwapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint AssocQueryString(AssocF flags, AssocStr str, string pszAssoc, string pszExtra, [Out] StringBuilder pszOut, [In][Out] ref uint pcchOut);
        public static string ExtensionToPrg(string extension)
        {
            return FileExtentionInfo(AssocStr.FriendlyAppName, extension);
        }

        public static Image ElementToImage(Element element)
        {
            if (!element.isFile)
            {
                return GetDirectoryIcon();
            }
            else if (element.extension.Length == 0)
            {
                return Properties.Resources.sampleFolder;
            }

            string extension = element.extension;
            string appli_exe;
            if (element.typeElement == TypeElement.Executable)
            {//on a un chemin complet d'une appli
                appli_exe = element.fullPath;
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

        public static string DocNameToFriendly(string extension)
        {
            return FileExtentionInfo(AssocStr.FriendlyDocName, extension);
        }

        public static string FileExtentionInfo(AssocStr assocStr, string doctype)
        {
            uint pcchOut = 0;
            AssocQueryString(AssocF.Verify, assocStr, doctype, null, null, ref pcchOut);

            StringBuilder pszOut = new StringBuilder((int)pcchOut);
            AssocQueryString(AssocF.Verify, assocStr, doctype, null, pszOut, ref pcchOut);
            return pszOut.ToString();
        }
        #endregion

        #region Shell32

        [DllImport("shell32")]
        private static extern int SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFILEINFO psfi, uint cbFileInfo, uint flags);

        //Ref https://www.codeproject.com/Questions/881150/Get-the-systems-icon-of-a-windows-drive-or-folder
        public static Bitmap GetDirectoryIcon()
        {
            const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
            const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;

            const uint SHGFI_ICON = 0x000000100;
            const uint SHGFI_SMALLICON = 0x000000001;
            const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;
            
            uint flags = SHGFI_ICON | SHGFI_USEFILEATTRIBUTES | SHGFI_SMALLICON;
            uint attributes = FILE_ATTRIBUTE_NORMAL | FILE_ATTRIBUTE_DIRECTORY;

            int success = SHGetFileInfo("C:\\Windows", attributes, out SHFILEINFO shfi, (uint)Marshal.SizeOf(typeof(SHFILEINFO)), flags);

            if (success == 0)
                return null;

            return Bitmap.FromHicon(shfi.hIcon);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        #endregion

        #region Enums

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

        #endregion
    }
}
