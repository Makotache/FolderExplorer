using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    public partial class Details : UserControl
    {
        private Element element;
        private string header;
        private JToken jToken;

        public Details(Element element, string name, JToken jToken)
        {
            this.element = element;
            this.header = name;
            this.jToken = jToken;
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            header_label.Text = header;

            JObject o1 = JObject.Parse(File.ReadAllText(FolderExplorer_form.DetailsJson));
            
            int baseHeight = this.Size.Height;
            int cpt = 0;
            foreach (JToken jToken in jToken.Values().ToArray())
            {
                string visual_name = ((JProperty)jToken).Name.ToString();
                string script_name = ((JProperty)jToken).Value.ToString();
                string val = typeof(Element).GetProperty(script_name).GetValue(element).ToString();

                if (cpt > 0)
                {
                    Label prop_label = new Label();
                    Label val_label = new Label();

                    prop_label.Text = visual_name;
                    val_label.Text = val;

                    prop_label.Location = new Point(property_label.Location.X, property_label.Location.Y * (cpt + 1));
                    val_label.Location = new Point(value_label.Location.X, value_label.Location.Y * (cpt + 1));

                    this.Controls.Add(prop_label);
                    this.Controls.Add(val_label);
                }
                else
                {
                    property_label.Text = visual_name;
                    value_label.Text = val;
                }

                this.Size = new Size(this.Size.Width, baseHeight + 22 * cpt);

                cpt++;
            }
        }
    }
}
