using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    public delegate void RowEventHandler(object sender, RowEventArgs e);


    public class RowEventArgs : EventArgs
    {
        //public int index { get; private set; }
        public Element element { get; private set; }

        public RowEventArgs(Element element)
        {
            //this.index = index;
            this.element = element;
        }
    }
}
