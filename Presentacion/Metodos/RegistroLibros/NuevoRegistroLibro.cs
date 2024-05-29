using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroLibros
{
    public static class NuevoRegistroLibro
    {
        //Metodo para el boton de nuevo registro (habilita la ventana de registro)
        public static void NuevoRegistro(Button btNuevo, Button btnCancelar, DataGridView dgvLibro, Panel panelContenedor, Panel panelPrincipal, TextBox txtTitulo, TextBox txtAutor, TextBox txtAnio, TextBox txtCantidad, TextBox txtPrecio)
        {
            btNuevo.Visible = false;
            btnCancelar.Visible = true;
            dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panelContenedor.Visible = true;
            // Llamada del método para limpiar los campos de los registros
            LimpiarCamposRegistroLibros.LimpiarCampos(txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio);
            panelPrincipal.Size = new Size(517, 478);
        }
    }
}
