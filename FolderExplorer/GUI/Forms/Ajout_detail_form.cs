using Newtonsoft.Json.Linq;
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
        public Ajout_detail_form()
        {
            InitializeComponent();
            //listing de toutes les catégories dispo dans le json
            if (File.Exists("FolderExplorerConfigs\\details_categories.json"))
            {
                JObject Categories = JObject.Parse(File.ReadAllText("FolderExplorerConfigs\\details_categories.json"));
                for (int i = 1; i < Categories.Count; i++)
                {
                    cb_categories.Items.Add(Categories.Property(i.ToString()).Value.ToString());
                }
            }
            //positionnement sur la premiere categorie trouvée
            cb_categories.SelectedIndex = 0;
            fininit = true;
        }

        private void cb_categories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (fininit)
            {
                if (cb_categories.SelectedItem.ToString() == "Nouvelle Categorie")
                {
                    //on ouvre la page de création de catégorie
                    Ajout_Categorie_form ajout_Categorie_Form = new Ajout_Categorie_form();
                    ajout_Categorie_Form.Show();
                }
            }
        }
    }
}
