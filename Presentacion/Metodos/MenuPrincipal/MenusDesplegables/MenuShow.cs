using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.MenuPrincipal.MenusDesplegables
{
    public static class MenuShow
    {
        //Metodo para mostrar los paneles de los botones 
        public static void ShowMenu(Panel subMenu, Panel panelSubInventario, Panel panelClientes, Panel panelVentas)
        {
            if (subMenu.Visible == false)
            {
                
                MenuHider.HideMenu(panelSubInventario, panelClientes, panelVentas);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


    }
}
