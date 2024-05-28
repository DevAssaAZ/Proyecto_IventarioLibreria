using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.AccionesDelFormulario
{
    public static class SesionCerrada
    {
        // Método para cerrar sesión
        public static void CerrarSesion(Form form)
        {
            if (MessageBox.Show("Deseas cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                form.Close();
        }


    }
}
