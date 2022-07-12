using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    internal static class Size_Manager
    {

        public static Decimal division(int xtaille, int xnombre)
        {
            Decimal retour = xtaille / xnombre;
            return retour;
        }

        public static int otoko(int xtailleo)
        {
            int xtailleko = Decimal.ToInt32(Decimal.Round(division(xtailleo, 1024)));
            return xtailleko;
        }

        public static int otomo(int xtailleo)
        {
            int xtailleko = Decimal.ToInt32(Decimal.Round(division(xtailleo, 1048576)));
            return xtailleko;
        }

        public static int otogo(int xtailleo)
        {
            int xtailleko = Decimal.ToInt32(Decimal.Round(division(xtailleo, 1073741824)));
            return xtailleko;
        }

    }
}
