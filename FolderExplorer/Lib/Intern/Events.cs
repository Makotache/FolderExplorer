using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer.Lib.Intern
{
    public class RowEventArgs : EventArgs
    {
        public int index;
        public Element element;
    }
}
