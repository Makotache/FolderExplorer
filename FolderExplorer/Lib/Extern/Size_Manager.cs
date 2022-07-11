using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    internal static class Size_Manager
    {
        public static int otoko(int xtailleo)
        {
            Decimal xtemp = xtailleo / 1024;
            int xtailleko = Decimal.ToInt32(Decimal.Round(xtemp));

            return xtailleko;
        }
    }
}
