using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    public partial class Properties_form : Form
    {
        private Element element;
        private bool details_loaded = false;
        public Properties_form(string fullPath)
        {
            element = new Element(fullPath);

            InitializeComponent();
            this.Text = "Propriétés de : " + element.fullName; 
            this.Icon = element.icon;
            if (element.extension == ".exe")
            {
                label3.Text = "Description : ";
                openwith_Icon.Visible = false;
                btn_modifier.Visible = false;
            }
            else
            {
                label3.Text = "S'ouvre avec : ";
                openwith_Icon.Visible = true;
                btn_modifier.Visible = true;
                tabControl1.TabPages.RemoveAt(1); //suppression onglet compatibilité
                tabControl1.TabPages.RemoveAt(1); //suppression onglet signatures numeriques, attention, on remet 1 parce que l'onglet a été décalé vers la gauche à cause de la suppression du premier
            }

            btn_appliquer.Enabled = false;
            //infos in element region proprietes normal
            //name
            Tb_name.Text = element.fullName;
            //type
            itemType_label.Text = element.itemType + " (" + element.extension + ")";
            if (element.extension == ".exe")
            {
                FileVersionInfo infosfichier = FileVersionInfo.GetVersionInfo(element.path.Replace("/", "\\") + "\\" + element.fullName);
                openWith_label.Text = infosfichier.FileDescription;
            }
            else
            {
                openWith_label.Text = element.openWith;
            }
            //icone
            openwith_Icon.Image = element.image;
            openwith_Image_Nom.Image = element.image;
            //element.GetValue(MetaDataElement.name)
            path_label.Text = element.path.Replace("/","\\");
            //size
            size_label.Text = Size_Manager.convertsize(element.size, SizeType.o) + " (" + element.size.ToString("### ### ### ### ###") + " octets)";
            //size on disk
            sizeOnDisk_label.Text = Size_Manager.convertsize(element.sizeOnDisk, SizeType.o) + " (" + element.sizeOnDisk.ToString("### ### ### ### ###") + " octets)";
            //creation date
            creationTime_label.Text = Maj_Min.PremiereLettreMaj(element.creationTime.ToString("F", CultureInfo.GetCultureInfo("fr-FR")));
            //last write time
            lastWriteTime_label.Text = Maj_Min.PremiereLettreMaj(element.lastWriteTime.ToString("F", CultureInfo.GetCultureInfo("fr-FR")));
            //last access
            if (element.lastAccessTime.Date == DateTime.Now.Date)
            {
                lastAccesTime_label.Text = "Aujourd'hui " + Maj_Min.PremiereLettreMaj(element.lastAccessTime.ToString("F", CultureInfo.GetCultureInfo("fr-FR")));
            }
            else
            {
                lastAccesTime_label.Text = Maj_Min.PremiereLettreMaj(element.lastAccessTime.ToString("F", CultureInfo.GetCultureInfo("fr-FR")));
            }
            if (element.attribute.ToString().Contains(FileAttributes.ReadOnly.ToString()))
            {
                cb_lecture_seule.Checked = true;
            }
            if (element.attribute.ToString().Contains(FileAttributes.Hidden.ToString()))
            {
                cb_cache.Checked = true;
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!details_loaded && tabControl1.SelectedIndex == tabControl1.Controls.GetChildIndex(details_tab))
            {
                JObject o1 = JObject.Parse(File.ReadAllText(FolderExplorer_form.DetailsJson));

                foreach (JProperty jProperty in o1.Properties())
                {
                    if (jProperty.Name.ToString() == element.extension)
                    {
                        int previous_y = 0;
                        foreach (JToken jToken in jProperty.Value.ToArray())
                        {
                            string header = ((JProperty)jToken).Name;
                            Details details = new Details(element, header, jToken);
                            details.Name = header;
                            details.Location = new Point(1, 1 + previous_y);
                            details.Size = new Size(details_tab.Size.Width, details.Size.Height);
                            details_tab.Controls.Add(details);
                        }
                    }
                }
                details_loaded = true;
            }
        }
    }
}
