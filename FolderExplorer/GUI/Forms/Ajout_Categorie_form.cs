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
    public partial class Ajout_Categorie_form : Form
    {
        public Ajout_Categorie_form()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            JObject Categories = JObject.Parse(File.ReadAllText("FolderExplorerConfigs\\details_categories.json"));
            int i = Categories.Count;
            Categories = new JObject(
                new JProperty(i.ToString(), tb_nom_categorie.Text)
            );

            File.WriteAllText("details_categories.json", Categories.ToString());
            Close();
        }
    }
}
