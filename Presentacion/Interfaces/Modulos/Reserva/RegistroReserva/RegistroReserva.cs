using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Clientes_cn;
using Negocio.Libros_cn;
using Negocio.Reserva_cn;
using Soporte.Cache;
using Presentacion.Metodos.AbrirYCerrarFormularios;


namespace Presentacion.Interfaces.Modulos.Reserva.RegistroReserva
{
    public partial class RegistroReserva : Form
    {
        MetodoReserva obj_reserva = new MetodoReserva();
        private int idUsuario;
        private int idLibro;
        private int idCliente;
        private int idReservaSeleccionada; // Variable para mantener el ID de la reserva seleccionada

        public RegistroReserva()
        {
            InitializeComponent();
        }

        private void RegistroReserva_Load(object sender, EventArgs e)
        {
            CargarDatos();
            usuarioproceso();
            LlenarComboBoxLibros();
            LlenarComboBoxClientes();
        }

        private void CargarDatos()
        {
            try
            {
                DataTable dt = obj_reserva.MostrarReservas();
                dgvReservas.DataSource = dt;
                dgvReservas.ClearSelection();
                dgvReservas.AutoGenerateColumns = false;

                // Asegurarse de que las columnas estén bien configuradas
                dgvReservas.Columns["ID"].DataPropertyName = "ID";
                dgvReservas.Columns["USUARIO_ID"].DataPropertyName = "USUARIO_ID";
                dgvReservas.Columns["CLIENTE_ID"].DataPropertyName = "CLIENTE_ID";
                dgvReservas.Columns["LIBRO_ID"].DataPropertyName = "LIBRO_ID";
                dgvReservas.Columns["CANTIDAD"].DataPropertyName = "CANTIDAD";
                dgvReservas.Columns["PRECIOTOTAL"].DataPropertyName = "PRECIOTOTAL";
                dgvReservas.Columns["FECHA_RESERVA"].DataPropertyName = "FECHA_RESERVA";
                dgvReservas.Columns["ESTADO"].DataPropertyName = "ESTADO";
                dgvReservas.Columns["VER"].DataPropertyName = "VER";
                dgvReservas.Columns["EDITAR"].DataPropertyName = "EDITAR";
                dgvReservas.Columns["ELIMINAR"].DataPropertyName = "ELIMINAR";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void usuarioproceso()
        {
            txtUsuario.Text = CacheDeInicioDeSesion.NombreCompleto;
            idUsuario = CacheDeInicioDeSesion.IdUser;
        }

        private void LlenarComboBoxLibros()
        {
            try
            {
                MetodosLibros libro_N = new MetodosLibros();
                DataTable tablaLibros = libro_N.MostrarLibros();

                comboLibros.DisplayMember = "TITULO";
                comboLibros.ValueMember = "ID";
                comboLibros.DataSource = tablaLibros;

                comboLibros.SelectedIndexChanged += new EventHandler(comboLibros_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de libros: " + ex.Message);
            }
        }

        private void comboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;
                textPrecio.Text = selectedRow["PRECIO"].ToString();
                idLibro = Convert.ToInt32(selectedRow["ID"]);


            }
        }

        private void LlenarComboBoxClientes()
        {
            try
            {
                MetodosCliente cliente_N = new MetodosCliente();
                DataTable tablaClientes = cliente_N.MostrarClientes();

                DataTable tablaClientesConcat = new DataTable();
                tablaClientesConcat.Columns.Add("ID", typeof(int));
                tablaClientesConcat.Columns.Add("NombreCompleto", typeof(string));
                tablaClientesConcat.Columns.Add("CEDULA", typeof(string));

                foreach (DataRow row in tablaClientes.Rows)
                {
                    string nombreCompleto = row["APELLIDO"].ToString() + " " + row["NOMBRE"].ToString();
                    string cedulaCliente = row["CEDULA"].ToString();
                    tablaClientesConcat.Rows.Add(row["ID"], nombreCompleto, cedulaCliente);
                }

                comboClientes.DisplayMember = "NombreCompleto";
                comboClientes.ValueMember = "ID";
                comboClientes.DataSource = tablaClientesConcat;

                comboClientes.SelectedIndexChanged += new EventHandler(comboClientes_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de clientes: " + ex.Message);
            }
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;
                string cedulaClienteSeleccionado = selectedRow.Row["CEDULA"].ToString();
                textCedula.Text = cedulaClienteSeleccionado;
                idCliente = Convert.ToInt32(selectedRow["ID"]);
            }
        }

        private bool ValidarFecha(string fechaStr, out DateTime fecha)
        {
            return DateTime.TryParseExact(fechaStr, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fecha);
        }


        private void botonRegistrarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textCantidad.Text) || string.IsNullOrEmpty(textPrecio.Text) ||
                    string.IsNullOrEmpty(textFecha.Text) || comboEstado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de registrar la reserva.");
                    return;
                }

                int cantidad = Convert.ToInt32(textCantidad.Text);
                decimal precioTotal = Convert.ToDecimal(textPrecio.Text) * cantidad;
                DateTime fechaReserva;

                // Validar y convertir la fecha
                if (!ValidarFecha(textFecha.Text, out fechaReserva))
                {
                    MessageBox.Show("Formato de fecha no válido. Por favor, ingresa una fecha válida en formato yyyy-MM-dd.");
                    return;
                }

                string estado = comboEstado.SelectedItem.ToString();

                // Insertar la reserva
                bool isInserted = obj_reserva.InsertarReserva(idUsuario, idCliente, idLibro, cantidad, precioTotal, fechaReserva, estado);

                if (isInserted)
                {
                    MessageBox.Show("Reserva Registrada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Registrado correctamente, verifique en la tabla");
                    ActualizarDataGridView();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar la reserva: " + ex.Message);
            }
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0)
                    {
                        if (dgvReservas.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (MessageBox.Show("¿Está seguro de eliminar esta reserva?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int idReserva = Convert.ToInt32(row.Cells["ID"].Value);

                                if (obj_reserva.EliminarReserva(idReserva))
                                {
                                    MessageBox.Show("Reserva eliminada con éxito");
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("Reserva eliminado, verifique en la tabla");
                                    ActualizarDataGridView();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }
    
    private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0)
                    {
                        idReservaSeleccionada = Convert.ToInt32(row.Cells["ID"].Value);
                        textCantidad.Text = row.Cells["CANTIDAD"].Value.ToString();
                        textPrecio.Text = row.Cells["PRECIOTOTAL"].Value.ToString();
                        textFecha.Text = Convert.ToDateTime(row.Cells["FECHA_RESERVA"].Value).ToString("yyyy-MM-dd");
                        comboEstado.SelectedItem = row.Cells["ESTADO"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la reserva: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            textCantidad.Text = string.Empty;
            textPrecio.Text = string.Empty;
            textFecha.Text = string.Empty;
            comboEstado.SelectedIndex = -1;
            comboLibros.SelectedIndex = -1;
            comboClientes.SelectedIndex = -1;
            textCedula.Text = string.Empty;
        }

        private void ActualizarDataGridView()
        {
            try
            {
                DataTable dt = obj_reserva.MostrarReservas();
                dgvReservas.DataSource = dt;
                dgvReservas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }


        // Eventos de los TextBox y ComboBox vacíos
        private void txtCedula_TextChanged(object sender, EventArgs e) { }
        private void txtUsuario_TextChanged(object sender, EventArgs e) { }
        private void textPrecio_TextChanged(object sender, EventArgs e) { }
        private void textCantidad_TextChanged(object sender, EventArgs e) { }
        private void textFecha_TextChanged(object sender, EventArgs e) { }
        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e) { }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idReservaSeleccionada == 0)
                {
                    MessageBox.Show("No se ha seleccionado ninguna reserva para actualizar.");
                    return;
                }

                // Validar los campos nuevamente antes de actualizar
                if (!ValidarCamposRegistro())
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de actualizar la reserva.");
                    return;
                }

                // Obtener valores de los controles
                int cantidad = Convert.ToInt32(textCantidad.Text);
                decimal precioTotal = Convert.ToDecimal(textPrecio.Text) * cantidad;
                DateTime fechaReserva;

                // Validar y convertir la fecha
                if (!ValidarFecha(textFecha.Text, out fechaReserva))
                {
                    MessageBox.Show("Formato de fecha no válido. Por favor, ingresa una fecha válida en formato yyyy-MM-dd.");
                    return;
                }

                string estado = comboEstado.SelectedItem.ToString();

                // Actualizar la reserva
                bool isUpdated = obj_reserva.EditarReserva(idReservaSeleccionada, idUsuario, idCliente, idLibro, cantidad, precioTotal, fechaReserva, estado);

                if (isUpdated)
                {
                    MessageBox.Show("Reserva actualizada correctamente.");
                    ActualizarDataGridView();
                    LimpiarCampos();
                    botonRegistrarReserva.Text = "Registrar"; // Restaurar el texto del botón
                    idReservaSeleccionada = 0; // Reiniciar el ID de reserva seleccionada
                }
                else
                {
                    MessageBox.Show("Actualizado correctamente, verifique en la tabla");
                    ActualizarDataGridView();
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la reserva: " + ex.Message);
            }
        }
        private bool ValidarCamposRegistro()
        {
            return !string.IsNullOrEmpty(textCantidad.Text) &&
                   !string.IsNullOrEmpty(textPrecio.Text) &&
                   !string.IsNullOrEmpty(textFecha.Text) &&
                   comboEstado.SelectedItem != null &&
                   comboLibros.SelectedItem != null &&
                   comboClientes.SelectedItem != null;
        }
    }
}
