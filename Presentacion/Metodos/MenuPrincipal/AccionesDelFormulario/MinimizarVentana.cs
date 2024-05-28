using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.AccionesDelFormulario
{
    public static class MinimizarVentana
    {
        // Método para minimizar la ventana
        public static void Minimizar(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

    }
}
