using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    internal static class CPCS
    {
        public static List<T> ConvertIList<T>(IList<T> lst)
        {
            return lst.Where(x => x != null).ToList();
        }

        public static int GetIndexMostCloseWidth(List<Point> lst, int mouse_pos_x)
        {
            int tmp = int.MaxValue;
            int result = -1;
            for(int i = 0; i < lst.Count; i++)
            {
                if (Math.Abs(lst[i].X - mouse_pos_x) < tmp)
                {
                    tmp = Math.Abs(lst[i].X - mouse_pos_x); 
                    result = i;
                }
            }
            return result;
        }
    }
}
