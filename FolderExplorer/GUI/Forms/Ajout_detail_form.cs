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
    public partial class Ajout_detail_form : Form
    {
        bool fininit;
        string _extension;
        public Ajout_detail_form(string extension)
        {
            InitializeComponent();
            _extension = extension;
            refreshcb(false);
        }

        private void cb_categories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (fininit)
            {
                if (cb_categories.SelectedItem.ToString() == "Nouvelle Categorie")
                {
                    //on ouvre la page de création de catégorie
                    Ajout_Categorie_form ajout_Categorie_Form = new Ajout_Categorie_form();
                    ajout_Categorie_Form.ShowDialog();
                    refreshcb(true);
                }
            }
        }

        private void refreshcb(bool dernieritem = false)
        {
            cb_categories.Items.Clear();
            //listing de toutes les catégories dispo dans le ini
            if (File.Exists("FolderExplorerConfigs\\details_categories.ini"))
            {
                string fichier = "FolderExplorerConfigs\\details_categories.ini";
                IEnumerable<string> lignes = File.ReadLines(fichier);
                foreach (string ligne in lignes)
                {
                    cb_categories.Items.Add(ligne);
                }
            }
            //Creation "nouvelle categorie"
            cb_categories.Items.Add("Nouvelle Categorie");
            //positionnement sur la premiere categorie trouvée
            if (dernieritem)
            {
                cb_categories.SelectedIndex = cb_categories.Items.Count-2;
            }
            else
            {
                cb_categories.SelectedIndex = cb_categories.Items.Count-1;
            }
            fininit = true;
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            /*
            ".wav": {
            "Fichier": {
            "Nom": "name"
            }
            }
             */
            string fichier = "temp"+_extension;
            string[] lignes = { "." + _extension + " : {", cb_categories.SelectedValue.ToString() + " : {", tb_detail_nom.Text + " : " + cb_type.SelectedValue.ToString(), "}", "}" };
            File.AppendAllLines(fichier, lignes);
            Close();
        }
    }
}
