using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool MouseOverControl(Control control)
        {
            return control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));
        }


        public static bool StringContainString(string strToVerify, string withIt, bool ignoreCase)
        {
            if (ignoreCase)
            {
                return strToVerify.IndexOf(withIt, StringComparison.OrdinalIgnoreCase) > -1;
            }
            else
            {
                return strToVerify.IndexOf(withIt) > -1;
            }
        }

        public static bool StringContainLatinLetter(string str, string customCharacter, bool ignoreCase = true, bool withAccent = true)
        {
            const string specialLetter = "àãä" + "éêèë" + "ç" + "îïì" + "õòöô" + "ùûü" + "ÿ";
            string letter = "abcdefghijklmnopqrstuvwxyz" + specialLetter;

            letter += customCharacter;

            for (int i = str.Length - 1; i > -1; i--)
            {
                if (!StringContainString(letter, str[i].ToString(), ignoreCase))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
