using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.AplicarRoles
{
    public static class RolesPermisos
    {
        //Metodo para aplicar permisos de rol a ciertos botones
        public static void AplicarRolesPermisos(string rol, Button btnRegistroUsuarios, Button btnLibros)
        {
            if (rol == Roles.Empleado)
            {
                btnRegistroUsuarios.Enabled = false;
                btnRegistroUsuarios.Visible = false;
                btnLibros.Enabled = false;
                btnLibros.Visible = false;
            }
        }

    }
}
