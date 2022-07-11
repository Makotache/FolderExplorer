using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderExplorer
{
    internal static class Maj_Min
    {

        public static string PremiereLettreMaj(string xtexte)
        {
            string xretour;
            xretour = xtexte.Substring(0, 1).ToUpper() + xtexte.Substring(1, xtexte.Length-1).ToLower();
            return xretour;
        }

        public static string ToutMaj(string xtexte)
        {
            string xretour;
            xretour = xtexte.ToUpper();
            return xretour;
        }

        public static string Toutmin(string xtexte)
        {
            string xretour;
            xretour = xtexte.ToLower();
            return xretour;
        }

        public static string PremiereLettreMin(string xtexte)
        {
            string xretour;
            xretour = xtexte.Substring(0, 1).ToLower() + xtexte.Substring(1, xtexte.Length-1).ToUpper();
            return xretour;
        }

    }
}
