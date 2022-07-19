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
        private ElementViewer elementViewer;
        internal static readonly string FolderMainPath = Path.Combine(Directory.GetCurrentDirectory(), "FolderExplorerConfigs");
        internal static readonly string ExtensionJson = Path.Combine(FolderMainPath, "extension.json");
        internal static readonly string DetailsJson = Path.Combine(FolderMainPath, "details.json");
        internal static readonly string ProgIdJson = Path.Combine(FolderMainPath, "ProgId.json");

        public FolderExplorer_form()
        {
            InitializeComponent();
            if (!Directory.Exists(FolderMainPath))
            {
                MessageBox.Show($"Impossible de trouver le dossier à cette position = '{FolderMainPath}'");
                Application.Exit();
            }
        }

        private void FolderExplorer_Load(object sender, EventArgs e)
        {
            elementViewer = new ElementViewer(this, "C:/testFolderExplorer");
            elementViewer.Location = new Point(60, 130);
            elementViewer.Name = "eviewer_usrc";
            this.Controls.Add(elementViewer);

            /*Element[] elements = Element.GetElements("C:/testFolderExplorer");
            for(int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i].ToString());
            }*/
        }

        private void FolderExplorer_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            elementViewer.EndTimerMoveHeader();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            elementViewer.LoadPath(elementViewer.parentFolder);
        }
    }
}
