using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceSystemController
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string routePROJECT = Path.Combine(Application.StartupPath, ""); /* Absorbe el ruta del proyecto */
            string route = routePROJECT.Replace("bin\\Debug", "Data");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(route));    
        }
    }
}
