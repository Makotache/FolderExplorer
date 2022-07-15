using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    internal static class Size_Manager
    {

        public static Double division(long xtaille, long xnombre)
        {
            Double retour = (double)(xtaille) / xnombre;
            return retour;
        }

        public static Double otoko_double(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1024), 2);
        }

        public static Double otomo_double(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1048576), 2);
        }

        public static Double otogo_double(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1073741824), 2);
        }

        public static Double ototo_double(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1099511627776), 2);
        }

        public static string otoko_string(long xtailleo)
        {
            double xtempdivision = division(xtailleo, 1024);
            double xtempmathround = Math.Round(xtempdivision, 2);
            return Math.Round(division(xtailleo, 1024), 2).ToString()+" Ko";
        }

        public static string otomo_string(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1048576), 2).ToString()+" Mo";
        }

        public static string otogo_string(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1073741824), 2).ToString()+" Go";
        }

        public static string ototo_string(long xtailleo)
        {
            return Math.Round(division(xtailleo, 1099511627776), 2).ToString()+" To";
        }

        public static string convertsize(long xtaille, SizeType xtype)
        {
            string retour = "";
            switch (xtype)
            {
                case SizeType.o:
                    switch (xtaille)
                    {
                        case < 1024:
                            //octets
                            retour = xtaille.ToString() + " Octets";
                            break;
                        case < 1024576:
                            retour = otoko_string(xtaille);
                            //ko
                            break;
                        case < 1073741824:
                            //Mo
                            retour = otomo_string(xtaille);
                            break;
                        case < 1099511627776:
                            //Go
                            retour = otogo_string(xtaille);
                            break;
                    }
                    break;
            }       
            return retour;
        }
    }

    public enum SizeType
    {
        o,
        ko,
        mo,
        go
    }
}
