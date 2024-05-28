using Presentacion.MenuPrincipal.Logo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Metodos.AbrirYCerrarFormularios;

namespace Presentacion.Metodos.AbrirYCerrarFormularios.MostrarLogo
{
    public static class MostrarLogo
    {
        //Metodo Para mostrar el logo
        public static void MostrarLogo1(Panel panelContenedor)
        {
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, new MarcaLogo());
        }

    }
}
