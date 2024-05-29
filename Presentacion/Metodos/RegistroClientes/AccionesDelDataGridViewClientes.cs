using Negocio.Clientes_cn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroClientes
{
    public static class AccionesDelDataGridViewClientes
    {
        //Metodo para seleccionar los registros y realizar acciones (Eliminar, actualizar, Ver)
        public static void AccionesTablaClientes(DataGridView dgvInformacion, DataGridViewCellEventArgs e, TextBox txtNombre, TextBox txtApellido, TextBox txtCedula, TextBox txtEdad, TextBox txtCorreo, ref string idCliente, Button btnNuevo, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal, Button btnRegistrarCliente)
        {
            MetodosCliente obj_cliente = new MetodosCliente();
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvInformacion.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {
                        if (dgvInformacion.Columns[e.ColumnIndex].Name == "EDITAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                txtNombre.Text = row.Cells["NOMBRE"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Nombre"
                                txtApellido.Text = row.Cells["APELLIDO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Apellido"
                                txtCedula.Text = row.Cells["CEDULA"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Cedula"
                                txtEdad.Text = row.Cells["EDAD"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Edad"
                                txtCorreo.Text = row.Cells["CORREO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Correo"
                                idCliente = row.Cells["ID"].Value.ToString();
                                btnNuevo.Visible = false;
                                btnCancelar.Visible = true;
                                dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                panelContenedor.Visible = true;
                                panelPrincipal.Size = new Size(437, 463);
                                btnRegistrarCliente.Text = "Actualizar";
                            }
                        }
                        else if (dgvInformacion.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                idCliente = row.Cells["ID"].Value.ToString();
                                obj_cliente.Id = Convert.ToInt32(idCliente);
                                if (MessageBox.Show("Esta seguro de Eliminar a este usuario? ", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (obj_cliente.EliminarCliente())
                                    {
                                        MessageBox.Show("Eliminado con éxito");
                                        // Llamada al método para cargar datos de cliente en el formulario
                                        DatosLoaderClientes.CargarDatosClientes(dgvInformacion);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Eliminar el usuario");
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
