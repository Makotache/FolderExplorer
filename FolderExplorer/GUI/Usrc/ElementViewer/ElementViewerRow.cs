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

        public Color normalColor
        {
            get => Color.FromArgb(32, 32, 32);
        }

        public Color hoverColor
        {
            get => Color.FromArgb(77, 77, 77);
        }

        public Color selectColor
        {
            get => Color.FromArgb(98, 98, 98);
        }

        public Color selectHoverColor 
        {
            get => Color.FromArgb(119, 119, 119);
        }

        private bool _isSelected;
        public bool isSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                BackColor = value ? selectColor : normalColor;
            }
        }

        public ElementViewerRow(Element element, bool nameOnly, ElementViewer elementViewer)
        {
            InitializeComponent();

            this.element = element;
            this.elementViewer = elementViewer;
            this.Size = new Size(0, 0);
            
            elementViewer.HeaderResize += new EventHandler(HeaderResize);
            ChangeNameVisibility(nameOnly);

            icon_pictureBox.Image = element.image;
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
            Control control;
            if (evh.metaDataElement != MetaDataElement.Name)
            {
                control = new Label();
                control.ForeColor = Color.FromArgb(222, 222, 222);
                control.MouseMove += ElementViewerRow_MouseMove;
                control.MouseLeave += ElementViewerRow_MouseLeave;
                control.Click += ElementViewerRow_Click;
                control.DoubleClick += ElementViewerRow_DoubleClick;
            }
            else
            {
                name_labelEdit.MouseMove += ElementViewerRow_MouseMove;
                name_labelEdit.MouseLeave += ElementViewerRow_MouseLeave;
                name_labelEdit.Click += ElementViewerRow_Click;
                name_labelEdit.DoubleClick += ElementViewerRow_DoubleClick;
                control = name_labelEdit;
                control.ForeColor = Color.White;
            }
            control.Name = evh.metaDataElement.ToString();
            string value = element.GetValue(evh.metaDataElement).ToString();
            control.Text = value != "-1" ? value : "";
            control.AutoSize = false;


            ChangeLabelLocationSize(control, evh);

            this.Controls.Add(control);
            label_dict.Add(evh.metaDataElement, control);
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

        private void ChangeLabelLocationSize(Control control, ElementViewerHeader evh)
        {
            //attention scroll
            int x = evh.Location.X;
            if (elementViewer.elementViewerHeader_lst.IndexOf(evh) > 0)
            {
                control.Location = new Point(x + 15, 4);
                control.Size = new Size(evh.Size.Width - 15, heightLabel);
            }
            else
            {
                control.Location = new Point(35, 0);
                control.Size = new Size(evh.Size.Width - 35, heightLabel);
            }
        }

        private void ElementViewerRow_KeyDown(object sender, KeyEventArgs e)
        {
            //F2
            //fleche directionnel
            //alt + fleche directionnel
            //touche "click droit"
            //suppr
            //alt + entrer
            //entrer
            //shift / control
            
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftAlt))//| System.Windows.Input.Key.RightAlt
                    {
                        elementViewer.OpenProperties(null, null);
                    }
                    else
                    {
                        element.Open(elementViewer);
                    }
                    break;

                case Keys.Up:
                case Keys.Down:
                    //change selection
                    break;

                case Keys.Right:
                case Keys.Left:
                    if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftAlt))
                    {
                        //page précédante / suivante
                    }
                    break;

                case Keys.F2:
                    //renommer
                    break;
            }
        }

        private void ElementViewerRow_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = isSelected ? selectHoverColor: hoverColor;
        }

        private void ElementViewerRow_MouseLeave(object sender, EventArgs e)
        {
            BackColor = isSelected ? selectColor : normalColor;
        }

        private void ElementViewerRow_Click(object sender, EventArgs e)
        {
            //changer le texte lors du hover du nom de la ligne
            if(sender != this)
            {
                OnClick(e);
            }
        }

        private void ElementViewerRow_DoubleClick(object sender, EventArgs e)
        {
            //ouverture
            if (sender != this)
            {
                OnDoubleClick(e);
            }
            else
            {
                element.Open(elementViewer);
            }
        }
    }
}
