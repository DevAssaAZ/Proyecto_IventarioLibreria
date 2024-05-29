using Negocio.Libros_cn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroLibros
{
    public static class AccionesDelDataViewGriedLibros
    {
        //Metodo para realizar acciones en los registros de la tabla de libros (Ver, Eliminar, Actualizar)
        public static void AccionesTablaLibros(DataGridView dgvLibro, DataGridViewCellEventArgs e, TextBox txtTitulo, TextBox txtAutor, TextBox txtAnio, TextBox txtCantidad, TextBox txtPrecio, ref string idLibro, Button btNuevo, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal, Button btnRegistrarLibro)
        {
            MetodosLibros obj_libro = new MetodosLibros();
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvLibro.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {
                        if (dgvLibro.Columns[e.ColumnIndex].Name == "EDITAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                txtTitulo.Text = row.Cells["TITULO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Titulo"
                                txtAutor.Text = row.Cells["AUTOR"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Autor"
                                txtAnio.Text = row.Cells["ANIO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Anio"
                                txtCantidad.Text = row.Cells["CANTIDAD"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Cantidad"
                                txtPrecio.Text = row.Cells["PRECIO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Precio"
                                idLibro = row.Cells["ID"].Value.ToString();
                                btNuevo.Visible = false;
                                btnCancelar.Visible = true;
                                dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                panelContenedor.Visible = true;
                                panelPrincipal.Size = new Size(437, 463);
                                btnRegistrarLibro.Text = "Actualizar";
                            }
                        }
                        else if (dgvLibro.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                idLibro = row.Cells["ID"].Value.ToString();
                                obj_libro.Id = Convert.ToInt32(idLibro);
                                if (MessageBox.Show("¿Está seguro de eliminar este libro?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (obj_libro.EliminarLibro())
                                    {
                                        MessageBox.Show("Libro eliminado con éxito");
                                        // Cargar datos al cargar el formulario
                                        DatosLoaderLibros.CargarDatosLibros(dgvLibro);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar el libro");
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
