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
    public static class AccionesDelDataViewGriedStockEntrada
    {
        //Metodo para realizar acciones en la tabla de stock de entrada (Ver, Eliminar, Actualizar)
        public static void AccionesTablaEntradaStock(DataGridViewCellEventArgs e, DataGridView dgvEntradaStock, TextBox txtNombreLibro, TextBox txtCantidad, TextBox txtProvedor, RichTextBox rtComentarios, TextBox txtIdStock, Button btnNuevaEntrada, Button btnCancelar, Button btnRegistrarStockEntrada, ref string nombrelibro, DataGridView dgvLibrosStock, Panel panelContenedor, Panel panelPrincipal, ComboBox cbLibros)
        {
            MetodosStockEntrada obj_entrada = new MetodosStockEntrada();

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvEntradaStock.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {
                        if (dgvEntradaStock.Columns[e.ColumnIndex].Name == "Editar")
                        {
                            if (e.RowIndex >= 0)
                            {
                                txtNombreLibro.Text = nombrelibro;
                                txtCantidad.Text = row.Cells["CANTIDAD"].Value?.ToString() ?? string.Empty;
                                txtProvedor.Text = row.Cells["PROVEEDOR"].Value?.ToString() ?? string.Empty;
                                rtComentarios.Text = row.Cells["COMENTARIOS"].Value?.ToString() ?? string.Empty;
                                txtIdStock.Text = row.Cells["ID"].Value.ToString();
                                btnNuevaEntrada.Visible = false;
                                btnCancelar.Visible = true;
                                dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                panelContenedor.Visible = true;
                                panelPrincipal.Size = new Size(437, 463);
                                btnRegistrarStockEntrada.Text = "Actualizar";
                                btnRegistrarStockEntrada.Enabled = false;
                                cbLibros.Visible = false;
                            }
                        }
                        else if (dgvEntradaStock.Columns[e.ColumnIndex].Name == "Eliminar")
                        {
                            if (e.RowIndex >= 0)
                            {
                                string idStock = row.Cells["ID"].Value.ToString();
                                obj_entrada.Id = Convert.ToInt32(idStock);
                                if (MessageBox.Show("¿Está seguro de eliminar este stock?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (obj_entrada.EliminarStockEntrada())
                                    {
                                        MessageBox.Show("Stock eliminado con éxito");
                                        //Llamada del método para ver stock
                                        DatosLoaderStock.CargarDatosStock(dgvLibrosStock);
                                        //Llamada del método para ver stock de entrada
                                        DatosLoaderStockEntrada.CargarDatosStockEntrada(dgvEntradaStock);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar el stock");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fila seleccionada está vacía.");
                    }
                }
                else
                {
                    MessageBox.Show("La fila o la columna seleccionada no son válidas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }
    }
}
