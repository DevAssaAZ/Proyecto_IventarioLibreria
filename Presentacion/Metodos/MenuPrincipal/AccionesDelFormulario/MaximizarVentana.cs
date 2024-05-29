using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.AccionesDelFormulario
{
    public static class MaximizarVentana
    {
        // Método para maximizar la ventana
        public static void Maximizar(Form form, ref int LX, ref int LY, PictureBox btnRestaurar, PictureBox btnMaximizar)
        {
            LX = form.Location.X;
            LY = form.Location.Y;
            form.Size = Screen.PrimaryScreen.WorkingArea.Size;
            form.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

    }
}
