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
    public partial class LabelEditable : UserControl
    {
        public new Color ForeColor
        {
            get { return visible_label.ForeColor; }
            set { visible_label.ForeColor = value; }
        }
        
        public new event MouseEventHandler MouseMove
        {
            add
            {
                Console.WriteLine("new event MouseMove");
                base.MouseMove += value;
                visible_label.MouseMove += value;
                edit_textBox.MouseMove += value;
            }
            remove
            {
                base.MouseMove -= value;
                visible_label.MouseMove -= value;
                edit_textBox.MouseMove -= value;
            }
        }

        public new event EventHandler MouseLeave
        {
            add
            {
                base.MouseLeave += value;
                visible_label.MouseLeave += value;
                edit_textBox.MouseLeave += value;
            }
            remove
            {
                base.MouseLeave -= value;
                visible_label.MouseLeave -= value;
                edit_textBox.MouseLeave -= value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                visible_label.Click += value;
                edit_textBox.Click += value;
            }
            remove
            {
                base.Click -= value;
                visible_label.Click -= value;
                edit_textBox.Click -= value;
            }
        }

        public new event EventHandler DoubleClick
        {
            add
            {
                base.DoubleClick += value;
                visible_label.DoubleClick += value;
                edit_textBox.DoubleClick += value;
            }
            remove
            {
                base.DoubleClick -= value;
                visible_label.DoubleClick -= value;
                edit_textBox.DoubleClick -= value;
            }
        }

        public LabelEditable()
        {
            InitializeComponent();
        }

        public void Init(string text)
        {
            visible_label.Text = text;
            edit_textBox.Text = text;
        }

        public void VisibleMode()
        {
            ChangeMode(false);
        }

        public void EditableMode()
        {
            edit_textBox.Text = visible_label.Text;
            ChangeMode(true);
        }

        private void ChangeMode(bool editableMode)
        {
            visible_label.Visible = !editableMode;
            edit_textBox.Visible = editableMode;
        }

        private void edit_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                visible_label.Text = edit_textBox.Text;
                VisibleMode();
            }
        }
    }
}
