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

namespace FolderExplorer
{
    public partial class Ajout_Categorie_form : Form
    {
        public Ajout_Categorie_form()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (File.Exists("FolderExplorerConfigs\\details_categories.ini"))
            {
                string fichier = "FolderExplorerConfigs\\details_categories.ini";
                File.AppendAllText(fichier, tb_nom_categorie.Text+"\n");
            }
            Close();
        }
    }
}
