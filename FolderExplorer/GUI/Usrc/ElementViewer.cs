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
    public partial class ElementViewer : UserControl
    {
        private readonly static Cursor vsplit_Cursor = Cursors.VSplit;
        private readonly static Cursor default_Cursor = Cursors.Default;
        private readonly List<ElementViewerHeader> elementViewerHeader_lsts = new List<ElementViewerHeader>();
        //move header
        private readonly List<Point> intersectionEvh_lsts = new List<Point>();
        private int indexMoveHeader = -1;
        private int mouse_pos_x = 0;

        public ElementViewer()
        {
            InitializeComponent();
        }

        private void ElementViewer_usrc_Load(object sender, EventArgs e)
        {
            AddHeader(name_evh_usrc, new object[] { });
            AddHeader(lastWriteTime_evh_usrc, new object[] { });
            AddHeader(type_evh_usrc, new object[] { });
            AddHeader(size_evh_usrc, new object[] { });
            moveHeader_timer.Enabled = true;           
        }

        //maj de la liste des intersections
        private void ActualizeIntersectionEvh_lsts(int index, int pos)
        {
            int gap = 0;
            if (index < intersectionEvh_lsts.Count - 1)
            {
                gap = intersectionEvh_lsts[index + 1].X - intersectionEvh_lsts[index].X;
            }
            intersectionEvh_lsts[index] = new Point(pos, 0);

            for (int i = index + 1; i < intersectionEvh_lsts.Count; i++)
            {
                pos += gap;
                if (i < intersectionEvh_lsts.Count - 1)
                {
                    gap = intersectionEvh_lsts[i + 1].X - intersectionEvh_lsts[i].X;
                }
                intersectionEvh_lsts[i] = new Point(pos, 0);
            }
        }

        #region Timer
        //sert a bouger les en-têtes
        private void MoveHeader_Tick(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left && Cursor.Current == vsplit_Cursor)
            {
                int tmp_mouse_pos_x = this.PointToClient(Cursor.Position).X;
                //Console.WriteLine($"mouse_pos_x => '{mouse_pos_x}'");

                int index = indexMoveHeader == -1 ? CPCS.GetIndexMostCloseWidth(intersectionEvh_lsts, tmp_mouse_pos_x) : indexMoveHeader;

                int previous_header_end_pos = 0;
                for (int i = 0; i < index; i++)
                {
                    ElementViewerHeader evh_previous = elementViewerHeader_lsts[i];
                    
                    previous_header_end_pos = evh_previous.Location.X + evh_previous.Size.Width;
                }

                //evh_actual
                ElementViewerHeader evh_actual = elementViewerHeader_lsts[index];
                if (evh_actual.MinimumSize.Width + evh_actual.Location.X < tmp_mouse_pos_x)
                {
                    indexMoveHeader = index;
                    mouse_pos_x = tmp_mouse_pos_x;

                    evh_actual.Size = new Size(mouse_pos_x - previous_header_end_pos, ElementViewerHeader.SizeHeight);

                    if (index < elementViewerHeader_lsts.Count - 1)
                    {
                        previous_header_end_pos = mouse_pos_x;
                        for (int i = index + 1; i < elementViewerHeader_lsts.Count; i++)
                        {
                            //next_evh 
                            ElementViewerHeader next_evh = elementViewerHeader_lsts[i];
                            next_evh.leftCursor = vsplit_Cursor;
                            next_evh.Location = new Point(previous_header_end_pos, 0);
                            previous_header_end_pos = next_evh.Location.X + next_evh.Size.Width;
                        }
                    }
                }
            }
            else if(indexMoveHeader != -1)
            {
                ActualizeIntersectionEvh_lsts(indexMoveHeader, mouse_pos_x);
                indexMoveHeader = -1;
            }
        }

        public void EndTimerMoveHeader()
        {
            moveHeader_timer.Enabled = false;
        }
        #endregion
        
        #region Header

        public void AddHeader(ElementViewerHeader evh, object[] filter)
        {
            evh.filter_comboBox.Items.Add(filter);
            evh.rightCursor = vsplit_Cursor;

            int x = 0;
            if (elementViewerHeader_lsts.Count > 0)
            {
                ElementViewerHeader evh_previous = elementViewerHeader_lsts[elementViewerHeader_lsts.Count - 1];
                evh_previous.leftCursor = vsplit_Cursor;
                x = evh_previous.Location.X + evh_previous.Size.Width;
            }
            intersectionEvh_lsts.Add(new Point(x + evh.Size.Width, 0));
            evh.Location = new Point(x, 0);
            elementViewerHeader_lsts.Add(evh);
        }

        public void AddHeader(string name, object[] filter)
        {
            ElementViewerHeader evh = new ElementViewerHeader();
            evh.Name = name;
            evh.text = name;
            AddHeader(evh, filter);
        }

        public void RemoveHeader(ElementViewerHeader evh)
        {
            elementViewerHeader_lsts[elementViewerHeader_lsts.Count - elementViewerHeader_lsts.IndexOf(evh) - 1].leftCursor = default_Cursor;
            elementViewerHeader_lsts.Remove(evh);
            intersectionEvh_lsts.Remove(new Point(evh.Location.X, 0));
        }

        public void RemoveHeader(string name)
        {
            foreach(ElementViewerHeader evh in elementViewerHeader_lsts)
            {
                if(evh.Name == name)
                {
                    RemoveHeader(evh);
                }
            }
        }

        #endregion

       
    }
}
