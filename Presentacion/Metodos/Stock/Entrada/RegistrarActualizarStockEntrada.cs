using Negocio.Stock_cn.StockEntrada;
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
    public static class RegistrarActualizarStockEntrada
    {
        public static void RegistrarActualizarStock(ref int idLibro, TextBox txtCantidad, DateTimePicker dtFecha, TextBox txtProvedor, RichTextBox rtComentarios, DataGridView dgvLibrosStock, DataGridView dgvEntradaStock, Button btnNuevaEntrada, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal, DataGridView dgvSalidaStock)
        {
            try
            {
                MetodosStockEntrada entrada = new MetodosStockEntrada();
                entrada.IdLibro = idLibro;
                entrada.Cantidad = Convert.ToInt32(txtCantidad.Text);
                // Obtener la fecha seleccionada del DateTimePicker
                DateTime fechaSeleccionada = dtFecha.Value;
                // Convertir la fecha a una cadena con el formato deseado "año-mes-día"
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
                entrada.Fecha = Convert.ToDateTime(fechaFormateada);
                entrada.Proveedor = txtProvedor.Text;
                entrada.Comentarios = rtComentarios.Text;

                if (entrada.InsertarStockEntrada())
                {
                    MessageBox.Show("Stock actualizado");
                    //Llamada del método para ver stock
                    DatosLoaderStock.CargarDatosStock(dgvLibrosStock);
                    //Llamada del método para ver stock de entrada
                    DatosLoaderStockEntrada.CargarDatosStockEntrada(dgvEntradaStock);
                    //Llamada al método para limpiar los campos de registro de stock de entrada
                    LimpiarCamposRegistroStockEntrada.LimpiarCampos(txtCantidad, rtComentarios);

                    btnNuevaEntrada.Visible = true;
                    btnCancelar.Visible = false;
                    panelContenedor.Visible = false;
                    panelPrincipal.Size = new Size(1020, 632);
                    dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvLibrosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSalidaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Error al registrar el stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar el stock: " + ex.Message);
            }
        }
    }
}
