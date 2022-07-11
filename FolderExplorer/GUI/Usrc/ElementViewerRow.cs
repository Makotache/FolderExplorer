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
    public partial class ElementViewerRow : UserControl
    {
        private Dictionary<MetaDataElement,Label> label_lsts = new Dictionary<MetaDataElement, Label>();
        private Element element;

        public event MouseEventHandler
        
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

        public void AddColumn(MetaDataElement[] metaDataElements)
        {
            for(int i = 0; i < metaDataElements.Length; i++)
            {
                MetaDataElement med = metaDataElements[i];
                if(med != MetaDataElement.Name)
                {
                    Label label = new Label();
                    label.Name = med.ToString();
                    label.Text = element.GetValue(med).ToString();
                    label.AutoSize = false;
                    label.Location = new Point();
                    label.Size = new Size();
                    label_lsts.Add(med, label);
                }
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

    //public delegate void MouseEventHandler(object sender, MouseEventArgs e);
    public delegate void RowEventHandler(object sender, RowEventArgs e);


}
