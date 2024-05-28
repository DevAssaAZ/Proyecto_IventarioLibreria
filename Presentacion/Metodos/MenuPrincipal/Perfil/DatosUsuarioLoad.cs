using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal
{
    public static class DatosUsuarioLoad
    {
        //Metodo para cargar informacion del usuario que ingreso en el perfil
        public static void LoadDatosUsuario(Label lbRol, Label lbNombre, Label lbEmail)
        {
            lbRol.Text = CacheDeInicioDeSesion.Rol;
            lbNombre.Text = CacheDeInicioDeSesion.NombreCompleto;
            lbEmail.Text = CacheDeInicioDeSesion.Email;
        }

    }
}
