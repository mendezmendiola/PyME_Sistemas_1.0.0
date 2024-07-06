using App_Contabilidad.Catalogos;
using App_Contabilidad.Principal;
using System;
using System.Windows.Forms;

namespace App_Contabilidad
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal_Contabilidad());
        }
    }
}
