using Presentacion.Metodos.RegistroLibros;
using Presentacion.Metodos.Stock.DatosDeTablas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.Entrada
{
    //Metodo para cancelar el registro de una entrada
    public static class CancelarOperacionRegistroStockEntrada
    {
        public static void CancelarEntrada(Button btnNuevaEntrada, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal, DataGridView dgvLibrosStock, DataGridView dgvEntradaStock, DataGridView dgvSalidaStock, TextBox txtCantidad, RichTextBox rtComentarios)
        {
            if (MessageBox.Show("Deseas cancelar el registro de Stock de Entrada?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                btnNuevaEntrada.Visible = true;
                btnCancelar.Visible = false;
                panelContenedor.Visible = false;
                panelPrincipal.Size = new Size(1020, 632);
                dgvLibrosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSalidaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Llamada del método para ver stock
                DatosLoaderStock.CargarDatosStock(dgvLibrosStock);
                // Llamada al método para limpiar los campos de registro de stock de entrada
                LimpiarCamposRegistroStockEntrada.LimpiarCampos(txtCantidad, rtComentarios);
            }
            
        }
    }
}
