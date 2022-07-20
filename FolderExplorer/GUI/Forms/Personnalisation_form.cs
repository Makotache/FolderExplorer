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

           
            button1.MouseDown += button1_MouseDown;
            button1.MouseMove += button1_MouseMove;
            button1.MouseUp += button1_MouseUp;
            //button2.MouseDown += button2_MouseDown;
        }

        //void button1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    button1.DoDragDrop(button1, DragDropEffects.Move);
        //}

        //void button2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    button2.DoDragDrop(button2, DragDropEffects.Move);
        //}

        //void panel_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;
        //}

        //void panel_DragDrop(object sender, DragEventArgs e)
        //{
        //    ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        //}
        bool isDragged = false;
        Point ptOffset;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = button1.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = button1.Location.X - ptStartPosition.X;
                ptOffset.Y = button1.Location.Y - ptStartPosition.Y;
            }
            else
            {
                isDragged = false;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                Point newPoint = button1.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                button1.Location = newPoint;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }
    }
}
