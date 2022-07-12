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
        public readonly List<ElementViewerHeader> elementViewerHeader_lst = new List<ElementViewerHeader>();
        public readonly List<ElementViewerRow> elementViewerRow_lst = new List<ElementViewerRow>();
        private string path;

        //move header
        public readonly List<Point> intersectionEvh_lst = new List<Point>();
        private int indexMoveHeader = -1;
        private int mouse_pos_x = 0;

        //event
        //public event RowEventHandler rowAdded;
        //public event RowEventHandler rowRemoved;

        private EventHandler _onHeaderResize;
        public event EventHandler HeaderResize
        {
            add
            {
                _onHeaderResize += value;
            }
            remove
            {
                _onHeaderResize -= value;
            }
        }

        public ElementViewer()
        {
            InitializeComponent();
        }

        public ElementViewer(string path)
        {
            InitializeComponent();
            this.path = path;
        }


        private void ElementViewer_usrc_Load(object sender, EventArgs e)
        {
            Element[] elements = Element.GetElements(path);
            for (int i = 0; i < elements.Length; i++)
            {
                AddRow(elements[i]);
            }

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
            if (index < intersectionEvh_lst.Count - 1)
            {
                gap = intersectionEvh_lst[index + 1].X - intersectionEvh_lst[index].X;
            }
            intersectionEvh_lst[index] = new Point(pos, 0);

            for (int i = index + 1; i < intersectionEvh_lst.Count; i++)
            {
                pos += gap;
                if (i < intersectionEvh_lst.Count - 1)
                {
                    gap = intersectionEvh_lst[i + 1].X - intersectionEvh_lst[i].X;
                }
                intersectionEvh_lst[i] = new Point(pos, 0);
            }
        }
        
        private void AddRow(Element element)
        {
            ElementViewerRow evr = new ElementViewerRow(element, false, this);
            
            int y = elementViewerRow_lst.Count * (ElementViewerRow.heightRow + 1) + 1;
            evr.Location = new Point(0, y);

            //voir la tailles des labels
            if(intersectionEvh_lst.Count > 0)
            {
                evr.Size = new Size(intersectionEvh_lst[intersectionEvh_lst.Count - 1].X, ElementViewerRow.heightRow);
            }
            /*else
            {
                evr.Size = new Size(0, 0);
            }*/

            elementViewerRow_lst.Add(evr);
            containerRow_panel.Controls.Add(evr);
        }
        private void RemoveRow(ElementViewerRow evr)
        {
            elementViewerRow_lst.Remove(evr);
            containerRow_panel.Controls.Remove(evr);
        }

        #region Timer
        //sert a bouger les en-têtes
        private void MoveHeader_Tick(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left && Cursor.Current == vsplit_Cursor)
            {
                int tmp_mouse_pos_x = this.PointToClient(Cursor.Position).X;
                //Console.WriteLine($"mouse_pos_x => '{mouse_pos_x}'");

                int index = indexMoveHeader == -1 ? CPCS.GetIndexMostCloseWidth(intersectionEvh_lst, tmp_mouse_pos_x) : indexMoveHeader;

                int previous_header_end_pos = 0;
                for (int i = 0; i < index; i++)
                {
                    ElementViewerHeader evh_previous = elementViewerHeader_lst[i];
                    
                    previous_header_end_pos = evh_previous.Location.X + evh_previous.Size.Width;
                }

                //evh_actual
                ElementViewerHeader evh_actual = elementViewerHeader_lst[index];
                if (evh_actual.MinimumSize.Width + evh_actual.Location.X < tmp_mouse_pos_x)
                {
                    indexMoveHeader = index;
                    mouse_pos_x = tmp_mouse_pos_x;

                    evh_actual.Size = new Size(mouse_pos_x - previous_header_end_pos, ElementViewerHeader.SizeHeight);

                    if (index < elementViewerHeader_lst.Count - 1)
                    {
                        previous_header_end_pos = mouse_pos_x;
                        for (int i = index + 1; i < elementViewerHeader_lst.Count; i++)
                        {
                            //next_evh 
                            ElementViewerHeader next_evh = elementViewerHeader_lst[i];
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
                OnHeaderResize(null);
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
            if (elementViewerHeader_lst.Count > 0)
            {
                ElementViewerHeader evh_previous = elementViewerHeader_lst[elementViewerHeader_lst.Count - 1];
                x = evh_previous.Location.X + evh_previous.Size.Width;
                evh.leftCursor = vsplit_Cursor;
            }
            intersectionEvh_lst.Add(new Point(x + evh.Size.Width, 0));
            evh.Location = new Point(x, 0);
            elementViewerHeader_lst.Add(evh);
            elementViewerRow_lst.ForEach(r => r.AddColumn(evh));
        }

        public void AddHeader(string name, object[] filter)
        {
            ElementViewerHeader evh = new ElementViewerHeader();
            evh.Name = name;
            this.Controls.Add(evh);
            AddHeader(evh, filter);
        }

        public void RemoveHeader(ElementViewerHeader evh)
        {
            elementViewerHeader_lst[elementViewerHeader_lst.Count - elementViewerHeader_lst.IndexOf(evh) - 1].leftCursor = default_Cursor;
            elementViewerHeader_lst.Remove(evh);
            this.Controls.Remove(evh);
            intersectionEvh_lst.Remove(new Point(evh.Location.X, 0));
        }

        public void RemoveHeader(string name)
        {
            foreach(ElementViewerHeader evh in elementViewerHeader_lst)
            {
                if(evh.Name == name)
                {
                    RemoveHeader(evh);
                }
            }
        }

        #endregion

        //event
        protected virtual void OnHeaderResize(EventArgs e)
        {
            _onHeaderResize?.Invoke(this, e);
        }

    }
}
