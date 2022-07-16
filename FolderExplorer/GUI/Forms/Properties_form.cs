using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Properties_form(string fullPath)
        {
            Element element = new Element(fullPath);
            StreamWriter sr = new StreamWriter("C:/testFolderExplorer/logs.log", true);
            sr.WriteLine(fullPath);
            sr.WriteLine(element.ToString());
            sr.Close();

            InitializeComponent();
            this.Text = "Propriétés de : " + element.name + Path.GetExtension(element.fullPath);

            btn_appliquer.Enabled = false;
            //infos in element region proprietes normal
            //name
            Tb_name.Text = element.name;
            //type
            itemType_label.Text = element.itemType + " (" + Path.GetExtension(element.fullPath) + ")";
            //openWith_label.Text = OpenWith.ExtensionToPrg(Path.GetExtension(element.fullPath));
            //element.GetValue(MetaDataElement.name)
            path_label.Text = element.path.Replace("/","\\");
            //size
            size_label.Text = Size_Manager.convertsize(element.size, SizeType.o) + " (" + element.size.ToString() + " octets)";
            //size on disk
            sizeOnDisk_label.Text = Size_Manager.convertsize(element.sizeOnDisk, SizeType.o) + " (" + element.sizeOnDisk.ToString() + " octets)";
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

        private void btn_avance_Click(object sender, EventArgs e)
        {
            AdvancedAttributes_form advancedAttributes_Form = new AdvancedAttributes_form();
            advancedAttributes_Form.Show();
        }
    }
}
