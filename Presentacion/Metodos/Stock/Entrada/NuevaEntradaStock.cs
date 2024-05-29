using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.Entrada
{
    public static class NuevaEntradaStock
    {
        //Metodo para el boton de nueva entrada para el stock
        public static void NuevaEntrada(Button btnNuevaEntrada, Button btnCancelar, ComboBox cbLibros, DataGridView dgvLibrosStock, DataGridView dgvEntradaStock, DataGridView dgvSalidaStock, Panel panelContenedor, Panel panelPrincipal, TextBox txtCantidad, RichTextBox rtComentarios)
        {
            btnNuevaEntrada.Visible = false;
            btnCancelar.Visible = true;
            cbLibros.Visible = true;
            dgvLibrosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSalidaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panelContenedor.Visible = true;
            panelPrincipal.Size = new Size(499, 483);
            //Llamada al método para limpiar los campos de registro de stock de entrada
            LimpiarCamposRegistroStockEntrada.LimpiarCampos(txtCantidad, rtComentarios);
        }
    }
}
