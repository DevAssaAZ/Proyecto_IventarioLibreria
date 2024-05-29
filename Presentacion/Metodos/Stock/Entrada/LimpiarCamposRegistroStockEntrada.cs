using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.Entrada
{
    public static class LimpiarCamposRegistroStockEntrada
    {
        //Metodo para limpiar los campos de registro de stock de entrada
        public static void LimpiarCampos(TextBox txtCantidad, RichTextBox rtComentarios)
        {
            txtCantidad.Clear();
            rtComentarios.Clear();
        }
    }
}
