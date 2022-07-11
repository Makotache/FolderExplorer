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
        private List<Label> label_lsts = new List<Label>();
        private Element element;
        
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
            //name_label.Text = nameOnly ? elementName : elementFullName;
        }

        public void AddColumn(MetaDataElement[] metaDataElements)
        {

        }

        public void RemoveColumn(MetaDataElement[] metaDataElements)
        {

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
