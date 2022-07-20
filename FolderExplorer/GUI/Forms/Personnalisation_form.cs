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
        public Personnalisation_form(string extension)
        {
            InitializeComponent();

           
       
        }

        private void btn_ajout_details_Click(object sender, EventArgs e)
        {
            Ajout_detail_form ajout_Detail_Form = new Ajout_detail_form();
            ajout_Detail_Form.Show();
        }
    }
}
