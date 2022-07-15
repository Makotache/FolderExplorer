using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExplorer
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                Application.Run(new Properties_form(args[0]));
            }
            else
            {
                //Application.Run(new Properties_form());
                Application.Run(new FolderExplorer_form());
            }
        }
    }
}
