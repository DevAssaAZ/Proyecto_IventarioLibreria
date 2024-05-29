using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Presentacion.Metodos.MenuPrincipal.AccionesDelFormulario
{
    public static class RestaurarVentana
    {
        // Método para restaurar la ventana
        public static void Restaurar(Form form, int LX, int LY, PictureBox btnRestaurar, PictureBox btnMaximizar)
        {
            form.Size = new Size(1300, 682);
            form.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

    }
}
