using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.MenusDesplegables
{
    public static class MenuHider
    {
        //Metodo para esconder los paneles desplegables
        public static void HideMenu(Panel panelSubInventario, Panel panelClientes, Panel panelVentas)
        {
            if (panelSubInventario.Visible)
                panelSubInventario.Visible = false;
            if (panelClientes.Visible)
                panelClientes.Visible = false;
            if (panelVentas.Visible)
                panelVentas.Visible = false;
        }


    }
}
