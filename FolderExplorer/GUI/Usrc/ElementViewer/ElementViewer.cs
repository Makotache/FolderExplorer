﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private readonly FolderExplorer_form folderExplorer;

        //path
        public string path { get; private set; }
        public string parentFolder 
        { 
            get
            {
                string[] arr = path.Split('/');
                return path.Replace("/" + arr[arr.Length - 1], arr.Length > 2 ? "" : "/");    
            }
        }
        public readonly List<string> leavedFolder_lst = new List<string>();

        //move header
        public readonly List<Point> intersectionEvh_lst = new List<Point>();
        public readonly List<ElementViewerHeader> elementViewerHeader_lst = new List<ElementViewerHeader>();
        private int indexMoveHeader = -1;
        private int mouse_pos_x = 0;

        //row
        public readonly List<ElementViewerRow> elementViewerRow_lst = new List<ElementViewerRow>();
        public readonly List<ElementViewerRow> selectedRows_lst = new List<ElementViewerRow>();
        private ElementViewerRow lastSelectedRow;

        //select field
        private SelectField selectField = new SelectField();
        private bool selectMode = false;

        //timer
        private MouseButtons lastButtons = MouseButtons.None;

        //event
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

        public ElementViewer(FolderExplorer_form folderExplorer, string path)
        {
            InitializeComponent();

            this.folderExplorer = folderExplorer;

            AddHeader(name_evh_usrc, new object[] { });
            AddHeader(lastWriteTime_evh_usrc, new object[] { });
            AddHeader(type_evh_usrc, new object[] { });
            AddHeader(size_evh_usrc, new object[] { });
            refresh_timer.Enabled = true;

            LoadPath(path);
        }

        public void LoadPath(string path, bool forceLoad = false, bool backButton = false)
        {            
            if (!forceLoad && (String.IsNullOrEmpty(path) || path == this.path)) 
            { return; }
            /*else if (this.path != "" && !backButton)
            { leavedFolder_lst.Add(this.path); }*/
            this.path = path;

            elementViewerRow_lst.ForEach(r => containerRow_panel.Controls.Remove(r));
            elementViewerRow_lst.Clear();
            selectedRows_lst.Clear();
            lastSelectedRow = null;

            try
            {
                List<Element> elements = Element.GetElements(path).ToList();
                elements.ForEach(e => AddRow(e));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"\n\n(Message temporaire)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LoadPath(parentFolder);
            }
            
        }

        #region Row

        private void AddRow(Element element)
        {
            ElementViewerRow evr = new ElementViewerRow(element, false, this);

            int y = elementViewerRow_lst.Count * (ElementViewerRow.heightRow + 1) + 1 - this.containerRow_panel.VerticalScroll.Value;
            evr.Location = new Point(0, y);
            evr.Click += Evr_Click;

            elementViewerHeader_lst.ForEach(h => evr.AddColumn(h));

            evr.Size = new Size(intersectionEvh_lst.Last().X, ElementViewerRow.heightRow);

            elementViewerRow_lst.Add(evr);
            containerRow_panel.Controls.Add(evr);
        }

        private void RemoveRow(ElementViewerRow evr)
        {
            //repositionner les autres éléments en fonction de la suppression de celui-ci
            elementViewerRow_lst.Remove(evr);
            containerRow_panel.Controls.Remove(evr);
        }

        private void Evr_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            /*if(sender == containerRow_panel && mouseEvent.Button == MouseButtons.Left)
            {

                mouseEvent.Location()

                /*if (Control.ModifierKeys != Keys.Control)
                {
                    selectedRows_lst.ForEach(r => r.isSelected = false);
                    selectedRows_lst.Clear();

                    //il faut relacher pour ca
                }
            }
            else */
            if(sender is ElementViewerRow evr && mouseEvent.Button == MouseButtons.Left)
            {
                void Shift()
                {
                    int indexStart;
                    if (lastSelectedRow != null)
                    { indexStart = elementViewerRow_lst.IndexOf(lastSelectedRow); }
                    else
                    { indexStart = 0; }

                    int indexEnd = elementViewerRow_lst.IndexOf(evr);
                    int tmp = 0;
                    if (indexEnd < indexStart)
                    {
                        tmp = indexStart;
                        indexStart = indexEnd;
                        indexEnd = tmp;
                    }

                    List<ElementViewerRow> lst = elementViewerRow_lst.GetRange(indexStart, indexEnd - indexStart + 1);
                    lst.ForEach(r => r.isSelected = true);

                    selectedRows_lst.AddRange(lst);
                }

           
                if (Control.ModifierKeys == (Keys.Shift | Keys.Control))
                {
                    Shift();
                }
                else if (Control.ModifierKeys == Keys.Control)
                {
                    selectedRows_lst.Add(evr);
                    evr.isSelected = true;
                }
                else // shift ou rien
                {
                    selectedRows_lst.ForEach(r => r.isSelected = false);
                    selectedRows_lst.Clear();

                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        Shift();
                    }
                    else
                    {
                        evr.isSelected = true;
                        selectedRows_lst.Add(evr);
                    }
                }
                lastSelectedRow = evr;
            }
            else if(mouseEvent.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                MenuItem open = new MenuItem("Ouvrir", new EventHandler(this.OpenElement));
                //open.Tag = 
                cm.MenuItems.Add(open);
                cm.MenuItems.Add("Propriétés", new EventHandler(this.OpenProperties));
                cm.Show(containerRow_panel, containerRow_panel.PointToClient(Cursor.Position), LeftRightAlignment.Left);

                //si plusieurs lignes sont sélectionné ET
                //(QUE on appui sur shift OU QUE notre souris est sur l'une des lignes sélectionné
                if (selectedRows_lst.Count > 0 && 
                    (Control.ModifierKeys == Keys.Shift || selectedRows_lst.Where(r => CPCS.MouseOverControl(r)).Count() > 0))
                {
                    //menu clic droit
                    Console.WriteLine("Menu clic droit sur fichier(s)/dossier(s)");
                }
                else //dossier actuel
                {
                    Console.WriteLine("Menu clic droit sur dossier actuel");
                }
            }
        }

        #region Menu Clic Droit
        
        private void OpenElement(object sender, EventArgs e)
        {
            //Console.WriteLine("OpenElement");
            switch (selectedRows_lst.Count)
            {
                case 1:
                    selectedRows_lst[0].element.Open(this);
                    break;

                case > 1:
                    break;
            }
        }

        public void OpenProperties(object sender, EventArgs e)
        {
            //Console.WriteLine("OpenProperties");
            switch (selectedRows_lst.Count)
            {
                case 1:
                    string path = selectedRows_lst[0].element.fullPath;
                    if (Program.DebugMode)
                    {
                        (new Properties_form(path)).Show();
                    }
                    else
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = Process.GetCurrentProcess().MainModule.FileName;
                        process.StartInfo.Arguments = '"' + path + '"';
                        process.Start();
                    }
                    break;

                case > 1:
                    selectedRows_lst.ForEach(r => r.isSelected = false);
                    selectedRows_lst.Clear();
                    //voir dans le cas où on as plusieurs fichier(s)/dossier(s)
                    break;
            }
        }

        #endregion
        #endregion

        #region Timer

        //sert a bouger les en-têtes
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //la fenetre active doit etre celle ci
            if(folderExplorer.ContainsFocus)
            {
                //la souris doit ce trouver dans le formulaire
                if (folderExplorer.ClientRectangle.Contains(folderExplorer.PointToClient(Cursor.Position)))
                {
                    //redimensionnement des en-têtes
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
                    else if (indexMoveHeader != -1)
                    {
                        ActualizeIntersectionEvh_lsts(indexMoveHeader, mouse_pos_x);
                        indexMoveHeader = -1;
                        OnHeaderResize(null);
                    }

                    //touche souris "dossier parent" / "dossier quitter"
                    if(Control.MouseButtons == MouseButtons.None)
                    {
                        if (lastButtons == MouseButtons.XButton1)
                        {
                            leavedFolder_lst.Add(this.path);
                            LoadPath(parentFolder);
                        }
                        else if (lastButtons == MouseButtons.XButton2)
                        {
                            if (leavedFolder_lst.Count > 0)
                            {
                                string path = leavedFolder_lst[leavedFolder_lst.Count - 1];
                                leavedFolder_lst.Remove(path);
                                LoadPath(path, backButton: true);
                            }
                        }
                    }
                }//la souris doit ce trouver dans le formulaire          

                //selection avec un "drag" de la souris
                if (indexMoveHeader == -1 && Control.MouseButtons == MouseButtons.Left && (selectMode || (!selectMode && this.GetChildAtPoint(this.PointToClient(Cursor.Position)) == containerRow_panel)))
                {
                    Point mouse_pos = containerRow_panel.PointToClient(Cursor.Position);
                    if (!selectMode)
                    {
                        selectMode = true;
                        selectField.startPos = mouse_pos;
                        containerRow_panel.Controls.Add(selectField);
                    }
                    //containerRow_panel.Controls.SetChildIndex(selectField, 0);
                    selectField.BringToFront();
                    selectField.ResizeField(mouse_pos);

                    //voir pour desactiver le changement de la taille automatique du containerRow_panel
                }
                else if (selectMode)
                {
                    selectMode = false;
                    containerRow_panel.Controls.Remove(selectField);
                }

                lastButtons = Control.MouseButtons;
            }//la fenetre active doit etre celle ci
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

        public void EndTimerMoveHeader()
        {
            refresh_timer.Enabled = false;
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
            foreach (ElementViewerHeader evh in elementViewerHeader_lst)
            {
                if (evh.Name == name)
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
