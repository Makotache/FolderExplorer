﻿using Microsoft.Win32;
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
        private Element element;
        public Properties_form(Element element)
        {
            InitializeComponent();
            this.element = element;
            init();
        }
        public Properties_form()
        {
            InitializeComponent();
            this.element = new Element("C:/testFolderExplorer/tt.txt", true);
            this.Text = "Propriétés de : " + element.name + Path.GetExtension(element.fullPath);
            init();
        }

        private void init()
        {
            btn_appliquer.Enabled = false;
            //infos in element region proprietes normal
            //name
            Tb_name.Text = element.name;
            //type
            itemType_label.Text = element.itemType + " (" + Path.GetExtension(element.fullPath) + ")";
            openWith_label.Text = openwith(Path.GetExtension(element.fullPath));
            //element.GetValue(MetaDataElement.name)
            path_label.Text = element.path.Replace("/","\\");
            //size
            size_label.Text = convertsize(element.size) + " (" + element.size.ToString() + " octets)";
            //size on disk
            //sizeOnDisk_label.Text = element.
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
            Console.WriteLine(element.attribute);
        }

        private string convertsize(long xtaille)
        {
            string retour = "";
            switch (xtaille)
            {
                case < 1024:
                    //octets
                    retour = Convert.ToInt32(xtaille).ToString() + " o";
                    break;
                case < 1024576:
                    retour = Size_Manager.otoko(Convert.ToInt32(xtaille)).ToString() + " Ko";
                    //ko
                    break;
                case < 1073741824:
                    //Mo
                    retour = Size_Manager.otomo(Convert.ToInt32(xtaille)).ToString() + " Mo";
                    break;
                case < 1099511627776:
                    //Go
                    retour = Size_Manager.otogo(Convert.ToInt32(xtaille)).ToString() + " Go";
                    break;
            }
            return retour;
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

        private string openwith(string extension)
        {
            string progid;
            string xretour = "";
            RegistryKey CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" +extension+"\\UserChoice", false);
            try
            {
                progid = CurrentUser.GetValue("ProgId", false).ToString();
            }
            catch
            {
                progid = "";
            }
            CurrentUser.Close();
            if (progid != "")
            {
                CurrentUser = Registry.ClassesRoot.OpenSubKey(progid + "\\Application");
                xretour = CurrentUser.GetValue("ApplicationName", false).ToString();
                CurrentUser.Close();
            }
            return xretour;
        }
    }
}
