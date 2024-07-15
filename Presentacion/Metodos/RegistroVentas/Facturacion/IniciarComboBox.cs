using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class IniciarComboBox
    {
        public static void ComboBoxSeleccionar(ComboBox cbDescuento, ComboBox cbPago)
        {
            cbDescuento.SelectedIndex = 0;

            cbPago.SelectedIndex = 0;


        }
    }
}
