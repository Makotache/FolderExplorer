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
    public partial class Personnalisation_form : Form
    {
        string _extension;
        public Personnalisation_form(string extension)
        {
            InitializeComponent();
            _extension = extension.Substring(1,extension.Length-1);
            FileStream fichiertemp = File.Create("temp_" + _extension);
            fichiertemp.Close();
            //rechercher, dans le json, ce qui a attrait à l'extension
            remplissagefichiertempo("FolderExplorerConfigs\\details.json");
            //procedure lecture fichier
            lecturefichiertempo();
        }

        private void btn_ajout_details_Click(object sender, EventArgs e)
        {
            Ajout_detail_form ajout_Detail_Form = new Ajout_detail_form(_extension);
            ajout_Detail_Form.ShowDialog();
            lecturefichiertempo();
        }

        private void lecturefichiertempo()
        {
            //lecture fichier temp_extension pour remplir
            dgv_details.Rows.Clear();
            string[] lignes = File.ReadAllLines("temp_" + _extension);
            int ligneencours = 0;
            while (ligneencours < lignes.Count()-2)
            {
                //categorie
                string categorie = lignes[ligneencours];
                categorie = categorie.Trim().Substring(1, categorie.Trim().Length-1);
                categorie = categorie.Substring(0, categorie.IndexOf(":") - 1);
                ligneencours++;
                //nom
                string nom = lignes[ligneencours];
                nom = nom.Trim().Substring(1, nom.Trim().Length - 1);
                nom = nom.Substring(0, nom.IndexOf(":") - 1);
                //type
                string type = lignes[ligneencours];
                type = type.Substring(type.IndexOf(":")+3);
                type = type.Substring(0, type.Length - 1);
                ligneencours+=2;
                dgv_details.Rows.Add(nom, type, categorie);
            }
        }

        private void remplissagefichiertempo(string fichierjson)
        {
            string[] lignesjson = File.ReadAllLines(fichierjson);
            int lignedebut = 0;
            int lignefin = 0;
            int ligneencours = 0;
            foreach(string lignejson in lignesjson)
            {
                ligneencours++;
                if (lignejson.Trim() == "//debut ." + _extension)
                {
                    lignedebut = ligneencours+1;
                }
                if (lignejson.Trim() == "//fin ." + _extension)
                {
                    lignefin = ligneencours-1;
                }
            }

            //rajouter les infos du json dans le fichier temp_extension
            ligneencours = 0;
            foreach (string lignejson in lignesjson)
            {
                ligneencours++;
                if (ligneencours > lignedebut && ligneencours < lignefin)
                {
                    File.AppendAllText("temp_" + _extension, lignejson+"\n");
                }
            }
        }
    }
}
