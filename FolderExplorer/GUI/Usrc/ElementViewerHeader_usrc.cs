using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    public partial class ElementViewerHeader_usrc : UserControl
    {

        public const int SizeHeight = 21;
        //public event MouseEventHandler MouseUp { get; private set; }

        //public event MouseEventHandler MouseDown { get; private set; }

        public string text
        {
            get
            {
                return header_button.Text;
            }
            set
            {
                header_button.Text = value;
            }
        }

        public Cursor rightCursor
        {
            get
            {
                return rightDrag_panel.Cursor;
            }
            set
            {
                rightDrag_panel.Cursor = value;
            }
        }

        public Cursor leftCursor
        {
            get
            {
                return leftDrag_panel.Cursor;
            }
            set
            {
                leftDrag_panel.Cursor = value;
            }
        }

        public SortDirection sortDirection { get; set; } = SortDirection.None;

        public ElementViewerHeader_usrc()
        {
            InitializeComponent();
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, SizeHeight, specified);
        }

        private void header_button_Click(object sender, EventArgs e)
        {
            sortDirection = FoExEnums.NextSortDirection(sortDirection);
        }
    }
}
