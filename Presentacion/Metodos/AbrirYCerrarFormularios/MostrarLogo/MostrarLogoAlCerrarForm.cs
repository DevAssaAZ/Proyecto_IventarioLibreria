using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Metodos.AbrirYCerrarFormularios;

namespace Presentacion.Metodos.AbrirYCerrarFormularios.MostrarLogo
{
    public static class MostrarLogoAlCerrarForm
    {
        //Metodo para mostrar el logo al cerrar un formulario
        public static void MostrarLogoAlCerrarFormulario( object sender, FormClosedEventArgs e, Panel panelContenedor)
        {
            MostrarLogo.MostrarLogo1(panelContenedor);
        }




    }
}
