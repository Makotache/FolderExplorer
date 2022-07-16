using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    public partial class test : Form
    {
        [DllImport("Shlwapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint AssocQueryString(AssocF flags, AssocStr str, string pszAssoc, string pszExtra, [Out] StringBuilder pszOut, [In][Out] ref uint pcchOut);
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Command : "+FileExtentionInfo(AssocStr.Command, textBox1.Text), "Command");
            Console.WriteLine("DDEAplication : "+FileExtentionInfo(AssocStr.DDEApplication, textBox1.Text), "DDEApplication");
            Console.WriteLine("DDEIFExec : "+FileExtentionInfo(AssocStr.DDEIfExec, textBox1.Text), "DDEIfExec");
            Console.WriteLine("DDETopic : "+FileExtentionInfo(AssocStr.DDETopic, textBox1.Text), "DDETopic");
            Console.WriteLine("Executable : "+FileExtentionInfo(AssocStr.Executable, textBox1.Text), "Executable");
            Console.WriteLine("FriendlyAppName : "+FileExtentionInfo(AssocStr.FriendlyAppName, textBox1.Text), "FriendlyAppName");
            Console.WriteLine("FriendlyDocName : "+FileExtentionInfo(AssocStr.FriendlyDocName, textBox1.Text), "FriendlyDocName");
            Console.WriteLine("NoOpen : "+FileExtentionInfo(AssocStr.NoOpen, textBox1.Text), "NoOpen");
            Console.WriteLine("ShellNewValue : "+FileExtentionInfo(AssocStr.ShellNewValue, textBox1.Text), "ShellNewValue");

        }


        public static string FileExtentionInfo(AssocStr assocStr, string doctype)
        {
            uint pcchOut = 0;
            AssocQueryString(AssocF.Verify, assocStr, doctype, null, null, ref pcchOut);

            StringBuilder pszOut = new StringBuilder((int)pcchOut);
            AssocQueryString(AssocF.Verify, assocStr, doctype, null, pszOut, ref pcchOut);
            return pszOut.ToString();
        }

        [Flags]
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

    }
}