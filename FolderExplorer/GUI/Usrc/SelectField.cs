using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer.GUI.Usrc
{
    public partial class SelectField : UserControl
    {
        public Color borderColor { get; set; } = Color.FromArgb(0, 120, 215);

        public Color fieldColor { get; set; } = Color.FromArgb(255, 0, 120, 215);

        private Rectangle border = new Rectangle(0, 0, 1, 1);

        public SelectField()
        {
            InitializeComponent();
        }

        private void SelectField_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(borderColor);
            Pen pen = new Pen(borderColor, 5);
            e.Graphics.DrawRectangle(pen, border);

            //Bitmap bitmap = new Bitmap(this.BackgroundImage);
            //bitmap.MakeTransparent(fieldColor);
        }

        private void SelectField_Resize(object sender, EventArgs e)
        {
            border = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
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
