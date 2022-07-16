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
    public partial class SelectField : UserControl
    {
        public Color borderColor { get; set; } = Color.FromArgb(0, 120, 215);

        public Color fieldColor { get; set; } = Color.FromArgb(0, 255, 255);

        private Rectangle border = new Rectangle(0, 0, 1, 1);

        public Point startPos { get; set; }

        public SelectField()
        {
            InitializeComponent();
        }

        private void SelectField_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(borderColor, 5);
            e.Graphics.DrawRectangle(pen, border);

            using (var brush = new SolidBrush(Color.FromArgb(50, fieldColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void SelectField_Resize(object sender, EventArgs e)
        {
            border = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
        }

        public void ResizeField(Point endCoord)
        {
            int x_size;
            int y_size;

            int x_location;
            int y_location;

            if (endCoord.X > startPos.X)
            {
                x_size = endCoord.X - startPos.X;
                x_location = startPos.X;
            }
            else
            {
                x_size = startPos.X - endCoord.X;
                x_location = endCoord.X;
            }

            if (endCoord.Y > startPos.Y)
            {
                y_size = endCoord.Y - startPos.Y;
                y_location = startPos.Y;
            }
            else
            {
                y_size = startPos.Y - endCoord.Y;
                y_location = endCoord.Y;
            }

            this.Size = new Size(x_size, y_size);
            this.Location = new Point(x_location, y_location);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }
    }
}
