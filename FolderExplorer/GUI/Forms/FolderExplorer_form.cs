using Shell32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace FolderExplorer
{
    public partial class FolderExplorer_form : Form
    {
        private ElementViewer_usrc eViewer = new ElementViewer_usrc();
        internal static readonly string FolderMainPath = Path.Combine(Directory.GetCurrentDirectory(), "FolderExplorerConfigs");
        internal static readonly string ExtensionJson = Path.Combine(FolderMainPath, "extension.json");
        Element[] elements;

        public FolderExplorer_form()
        {
            InitializeComponent();
            if (!Directory.Exists(FolderMainPath))
            {
                MessageBox.Show($"Impossible de trouver le dossier à cette position = '{FolderMainPath}'");
                Close();
            }
        }

        private void FolderExplorer_Load(object sender, EventArgs e)
        {
            eViewer.Location = new Point(52, 124);
            eViewer.Name = "eviewer_usrc";
            this.Controls.Add(eViewer);

            elements = Element.GetElements("C:/testFolderExplorer");
            /*for(int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i].ToString());
            }*/
        }

        private void FolderExplorer_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            eViewer.EndTimerMoveHeader();
        }



        private void button1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            Console.WriteLine("MouseButtons => " + Control.MouseButtons);
            //Console.WriteLine("System.Windows.Forms.Cursor.Current => " + System.Windows.Forms.Cursor.Current);
            //Console.WriteLine("System.Windows.Forms.Cursor.Current 'bool'=> " + eViewer.IsVsplit_Cursor);
        }
    }
}
