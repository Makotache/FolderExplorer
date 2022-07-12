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
        private Dictionary<MetaDataElement, Control> label_dict = new Dictionary<MetaDataElement, Control>();
        private ElementViewer elementViewer;
        private const int heightLabel = 20;
        public const int heightRow = 22;
        public Element element { get; private set; }

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

        public ElementViewerRow(Element element, bool nameOnly, ElementViewer elementViewer)
        {
            InitializeComponent();
            this.element = element;
            this.elementViewer = elementViewer;
            this.Size = new Size(0, 0);
            elementViewer.HeaderResize += new EventHandler(HeaderResize);
            ChangeNameVisibility(nameOnly);
        }

        public void ChangeNameVisibility(bool nameOnly)
        {
            name_labelEdit.Init(nameOnly ? elementName : elementFullName);
        }

        public void AddColumn(ElementViewerHeader evh)
        {
            //pour le moment
            //on met un string
            //on feras plus tard pour que ce soit au propre

            Control label = evh.metaDataElement != MetaDataElement.Name ? new Label() : name_labelEdit;
            label.Name = evh.metaDataElement.ToString();
            label.Text = element.GetValue(evh.metaDataElement).ToString();
            label.AutoSize = false;
                
            ChangeLabelLocationSize(label, evh);
            this.Size = new Size(this.Size.Width + label.Width, heightRow);
            this.Controls.Add(label);
            label_dict.Add(evh.metaDataElement, label);
        }

        public void RemoveColumn(MetaDataElement metaDataElement)
        {
            if (metaDataElement != MetaDataElement.Name)
            {
                this.Controls.Remove(label_dict[metaDataElement]);
                label_dict.Remove(metaDataElement);
            }
        }

        private void HeaderResize(object sender, EventArgs e)
        {
            for(int i =0; i < elementViewer.elementViewerHeader_lst.Count; i++)
            {
                ElementViewerHeader evh = elementViewer.elementViewerHeader_lst[i];
                ChangeLabelLocationSize(label_dict[evh.metaDataElement], evh);
                if(i + 1 == elementViewer.elementViewerHeader_lst.Count)
                {
                    this.Size = new Size(evh.Location.X + evh.Width, heightRow);
                }
            }            
        }

        private void ChangeLabelLocationSize(Control label, ElementViewerHeader evh)
        {
            //attention scroll
            int x = evh.Location.X;
            //int y = evh.Location.Y;
            label.Location = new Point(x, 1);
            label.Size = new Size(evh.Size.Width, heightLabel);
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
