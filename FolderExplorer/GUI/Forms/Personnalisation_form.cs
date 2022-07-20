using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    public partial class Personnalisation_form : Form
    {
        string _extension;
        public Personnalisation_form(string extension)
        {
            InitializeComponent();
            _extension = extension;
            //rechercher, dans le json, ce qui a attrait à l'extension
            //rajouter les infos du json dans le fichier temp_extension
            //procedure lecture fichier
        }

        private void btn_ajout_details_Click(object sender, EventArgs e)
        {
            Ajout_detail_form ajout_Detail_Form = new Ajout_detail_form(_extension);
            ajout_Detail_Form.Show();
        }

        private void lecturefichier()
        {
            //lecture fichier temp_extension pour remplir
        }
    }
}
