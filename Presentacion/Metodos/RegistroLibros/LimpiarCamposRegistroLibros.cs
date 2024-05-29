using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroLibros
{
    public static class LimpiarCamposRegistroLibros
    {
        public static void LimpiarCampos(TextBox txtTitulo, TextBox txtAutor, TextBox txtAnio, TextBox txtCantidad, TextBox txtPrecio)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

    }
}
