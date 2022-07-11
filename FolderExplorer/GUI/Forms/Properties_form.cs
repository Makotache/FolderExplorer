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
            this.element = new Element(@"C:\testFolderExplorer\4.jpg", true);
            init();
        }

        private void init()
        {
            //infos in element region proprietes normal
            itemType_label.Text = element.itemType;
            //element.GetValue(MetaDataElement.name)
            path_label.Text = element.path;
            //size
            //switch (element.size)
            //{
            //    case < 1024 :
            //        break;
            //    case 1024 < * < 1024576 :
            //        break;
            //}
            size_label.Text = "Ko ("+element.size.ToString() + " octets)";
        }
    }
}
