using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.AccionesDelFormulario
{
    public static class Exit
    {

        // Método para salir del programa
        public static void Salir()
        {
            if (MessageBox.Show("Seguro que desea cerrar el programa?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
