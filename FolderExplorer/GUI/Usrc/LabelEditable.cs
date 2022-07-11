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
