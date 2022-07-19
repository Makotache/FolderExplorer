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
    public partial class Personnalisation_form : Form
    {
        public Personnalisation_form()
        {
            InitializeComponent();
            Pan_Dispo.AllowDrop = true;
            Pan_Final.AllowDrop = true;

            Pan_Dispo.DragEnter += panel_DragEnter;
            Pan_Final.DragEnter += panel_DragEnter;

            Pan_Dispo.DragDrop += panel_DragDrop;
            Pan_Final.DragDrop += panel_DragDrop;

            button1.MouseDown += button1_MouseDown;
            button2.MouseDown += button2_MouseDown;
        }

        void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1, DragDropEffects.Move);
        }

        void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.DoDragDrop(button2, DragDropEffects.Move);
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }
    }
}
