using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    /*
    public class CustomEvent
    {
        
        public delegate void CustomEventHandler(CustomEventArgs e);
        public List<CustomEventArgs> customEvents_lst { get; private set; }

        public CustomEvent()
        {
            customEvents_lst = new List<CustomEventArgs>();
        }

        public void AddListener(CustomEventArgs e)
        {
            customEvents_lst.Add(e);
        }

        public void Invoke()
        {
            foreach (CustomEventArgs e in customEvents_lst)
            {
                //e.
            }
        }

    }

    public class CustomEventArgs
    {
        public CustomEventArgs()
        {

        }
    }
    */


    #region Row

    public delegate void RowEventHandler(object sender, RowEventArgs e);

    public class RowEventArgs : EventArgs
    {
        public ElementViewerRow elementViewerRow { get; private set; }

        public RowEventArgs(ElementViewerRow elementViewerRow)
        {
            this.elementViewerRow = elementViewerRow;
        }
    }

    #endregion

    #region Header

    public delegate void HeaderEventHandler(object sender, HeaderEventArgs e);

    public class HeaderEventArgs : EventArgs
    {
        public ElementViewerHeader elementViewerHeader { get; private set; }

        public HeaderEventArgs(ElementViewerHeader elementViewerHeader)
        {
            this.elementViewerHeader = elementViewerHeader;
        }
    }

    #endregion

    #region DoubleClick

    public delegate void DoubleClickHandler(DoubleClickArgs e);

    public class DoubleClickArgs : EventArgs
    {
        public object[] parameters { get; private set; }

        public DoubleClickArgs(object[] parameters)
        {
            this.parameters = parameters;
        }
    }

    #endregion
}
