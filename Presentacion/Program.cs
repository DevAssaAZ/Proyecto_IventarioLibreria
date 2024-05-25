using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Login;
using Presentacion.MenuPrincipal;
using Presentacion.Modulos.RegistroClientes;
using Presentacion.Modulos.RegistroLibros;

namespace Presentacion
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
            //Application.Run(new Login_());
           Application.Run(new RegistroLibro());

        }
    }
}
