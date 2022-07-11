﻿using System;
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
    public partial class ElementViewerRow : UserControl
    {
        private Dictionary<MetaDataElement,Label> label_lsts = new Dictionary<MetaDataElement, Label>();
        private Element element;

        //public event RowEventHandler RowChanged;


        public string elementName
        {
            get { return element.name; }
            
            set { element.name = value; }
        }

        public string elementFullName
        {
            get { return element.fullName; }

            set { element.fullName = value; }
        }

        public ElementViewerRow(Element element, bool nameOnly)
        {
            InitializeComponent();
            this.element = element;
            ChangeNameVisibility(nameOnly);
        }

        public void ChangeNameVisibility(bool nameOnly)
        {
            name_labelEdit.Init(nameOnly ? elementName : elementFullName);
        }

        public void AddColumn(MetaDataElement metaDataElement, ElementViewer elementViewer)
        {
            //pour le moment
            //on met un string
            //on feras plus tard pour que ce soit au propre

            if(metaDataElement != MetaDataElement.Name)
            {
                Label label = new Label();
                label.Name = metaDataElement.ToString();
                label.Text = element.GetValue(metaDataElement).ToString();
                label.AutoSize = false;
                label.Location = new Point();
                label.Size = new Size();
                label_lsts.Add(metaDataElement, label);
            }
        }

        public void RemoveColumn(MetaDataElement[] metaDataElements)
        {
            for (int i = 0; i < metaDataElements.Length; i++)
            {
                MetaDataElement med = metaDataElements[i];
                if (med != MetaDataElement.Name)
                {
                    label_lsts.Remove(med);
                }
            }
        }

        private void ElementViewerRow_KeyDown(object sender, KeyEventArgs e)
        {
            //F2
            //fleche directionnel
            //touche "click droit"
            //suppr
            //alt entrer
            //entrer
            //shift / control
        }
    }
}
