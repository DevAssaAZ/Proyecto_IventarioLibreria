using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Clientes_cn;
using Negocio.Libros_cn;
using Negocio.Usuarios_cn;
using Negocio.Ventas_cn;

namespace Presentacion.Modulos.RegistroVentas
{
    public partial class RegistroVentas : Form
    {
        private MetodosLibros _metodosLibros;
        private MetodosVenta _metodosVenta;
        private MetodosCliente _metodosCliente;
        private MetodosUsuario _metodosUsuario;
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();
        private string VentaId = null;
        private MetodosVenta obj_venta = new MetodosVenta();

        public RegistroVentas()
        {
            InitializeComponent();
            _metodosLibros = new MetodosLibros(); // Inicializa la clase de métodos de libros
            _metodosVenta = new MetodosVenta();   // Inicializa la clase de métodos de ventas
            _metodosCliente = new MetodosCliente();   // Inicializa la clase de métodos de clientes
            _metodosUsuario = new MetodosUsuario();   // Inicializa la clase de métodos de usuarios
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvVenta.AutoGenerateColumns = false;

            dgvVenta.Columns.Clear();

            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Usuario", DataPropertyName = "Usuario" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cliente", DataPropertyName = "Cliente" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cedula", DataPropertyName = "Cedula" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Libro", DataPropertyName = "Libro" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Precio", DataPropertyName = "Precio" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cantidad", DataPropertyName = "Cantidad" });

            // Agregar columnas de edición y eliminación
            dgvVenta.Columns.Add(new DataGridViewButtonColumn() { Name = "EDITAR", Text = "Editar", UseColumnTextForButtonValue = true });
            dgvVenta.Columns.Add(new DataGridViewButtonColumn() { Name = "ELIMINAR", Text = "Eliminar", UseColumnTextForButtonValue = true });

            CargarDatos();
        }

        private void RegistroVentas_Load(object sender, EventArgs e)
        {
            CargarTitulosLibros();
            CargarUsuarios();
            CargarClientes();
        }

        private void CargarTitulosLibros()
        {
            try
            {
                DataTable dt = _metodosLibros.MostrarLibros();
                cmbLibros.DisplayMember = "TITULO";
                cmbLibros.ValueMember = "ID";
                cmbLibros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar títulos de libros: " + ex.Message);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                DataTable dtUsuarios = _metodosUsuario.MostrarUsuarios();
                cmbUsuario.DataSource = dtUsuarios;
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = _metodosVenta.MostrarClientes();
                cmbCliente.DisplayMember = "NOMBRE";
                cmbCliente.ValueMember = "ID";
                cmbCliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void LlenarCamposLibro(int libroId)
        {
            try
            {
                DataTable dt = _metodosLibros.ObtenerLibroPorId(libroId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtPrecio.Text = row["PRECIO"].ToString();
                    txtCantidadDisponible.Text = row["CANTIDAD"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del libro: " + ex.Message);
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                MetodosVenta venta_N = new MetodosVenta();
                int libroId = Convert.ToInt32(cmbLibros.SelectedValue);
                int usuarioId = Convert.ToInt32(cmbUsuario.SelectedValue);
                int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                int cantidad = Convert.ToInt32(txtCantidadDisponible.Text);
                decimal precioTotal = Convert.ToDecimal(txtPrecio.Text);

                bool resultado = venta_N.RegistrarVenta(libroId, usuarioId, clienteId, cantidad, precioTotal);

                if (resultado)
                {
                    MessageBox.Show("Venta registrada exitosamente.");

                    // Limpia los TextBox y ComboBox después de la inserción
                    LimpiarCampos();

                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbLibros.SelectedItem;
                int libroId = Convert.ToInt32(selectedRow["Id"]);
                LlenarCamposLibro(libroId);
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbCliente.SelectedItem;
                int clienteId = Convert.ToInt32(selectedRow["Id"]);
                LlenarCamposCedula(clienteId);
            }
        }

        private void LlenarCamposCedula(int cedulaId)
        {
            try
            {
                string cedula = _metodosCliente.ObtenerCedulaPorId(cedulaId);
                txtCedula.Text = cedula;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del cliente: " + ex.Message);
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        {
            try
            {
                MetodosVenta venta_N = new MetodosVenta();

                if (btnRegistrarVenta.Text == "Registrar Venta")
                {
                    int libroId = Convert.ToInt32(cmbLibros.SelectedValue);
                    int usuarioId = Convert.ToInt32(cmbUsuario.SelectedValue);
                    int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                    int cantidad = Convert.ToInt32(txtCantidadDisponible.Text);
                    decimal precioTotal = Convert.ToDecimal(txtPrecio.Text) * cantidad;

                    // Lógica para registrar la venta
                    bool resultado = venta_N.RegistrarVenta(libroId, usuarioId, clienteId, cantidad, precioTotal);

                    if (resultado)
                    {
                        MessageBox.Show("Venta registrada exitosamente.");

                        // Limpia los TextBox y ComboBox después de la inserción
                        LimpiarCampos();

                        // Vuelve a cargar los datos en el DataGridView
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la venta.");
                    }
                }
                else if (btnRegistrarVenta.Text == "Actualizar")
                {
                    // Lógica para actualizar la venta
                    int ventaId = Convert.ToInt32(VentaId);
                    int libroId = Convert.ToInt32(cmbLibros.SelectedValue);
                    int usuarioId = Convert.ToInt32(cmbUsuario.SelectedValue);
                    int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                    int cantidad = Convert.ToInt32(txtCantidadDisponible.Text);
                    decimal precioTotal = Convert.ToDecimal(txtPrecio.Text) * cantidad;

                    bool resultado = venta_N.ActualizarVenta(ventaId, libroId, usuarioId, clienteId, cantidad, precioTotal);

                    if (resultado)
                    {
                        MessageBox.Show("Venta actualizada exitosamente.");

                        // Limpia los TextBox y ComboBox después de la actualización
                        LimpiarCampos();

                        // Vuelve a cargar los datos en el DataGridView
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la venta.");
                    }

                    // Cambia el texto del botón de nuevo a "Registrar"
                    btnRegistrarVenta.Text = "Registrar Venta";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la venta: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            cmbLibros.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            txtCedula.Clear();
            txtPrecio.Clear();
            txtCantidadDisponible.Clear();
        }

        private void CargarDatos()
        {
            // Cargar datos en el DataGridView
            dgvVenta.DataSource = _metodosVenta.MostrarVentas();

            // Cargar datos en cmbCliente
            cmbCliente.DataSource = _metodosCliente.MostrarClientes();
            cmbCliente.ValueMember = "Id";
            cmbCliente.DisplayMember = "Nombre";

            // Cargar datos en cmbUsuario
            cmbUsuario.DataSource = _metodosUsuario.MostrarUsuarios();
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.DisplayMember = "Nombre";

            // Cargar datos en cmbLibro
            cmbLibros.DataSource = _metodosLibros.MostrarLibros();
            cmbLibros.ValueMember = "Id";
            cmbLibros.DisplayMember = "Titulo";
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCantidadDisponible_TextChanged(object sender, EventArgs e)
        {
        }

        private void fechaVenta_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                MessageBox.Show("Campos reseteados. Listo para ingresar una nueva venta.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al resetear los campos: " + ex.Message);
            }
        }

        private void dgvVenta_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgvVenta.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0)
                    {
                        if (dgvVenta.Columns[e.ColumnIndex].Name == "EDITAR")
                        {
                            cmbLibros.Text = row.Cells["Libro"].Value?.ToString() ?? string.Empty;
                            txtCantidadDisponible.Text = row.Cells["Cantidad"].Value?.ToString() ?? string.Empty;
                            txtPrecio.Text = row.Cells["Precio"].Value?.ToString() ?? string.Empty;

                            string ventaId = row.Cells[0].Value?.ToString();
                            VentaId = ventaId;

                            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            panelContenedor.Visible = true;
                            btnRegistrarVenta.Text = "Actualizar";
                        }
                        if (dgvVenta.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                VentaId = row.Cells[0].Value.ToString();
                                obj_venta.Id = Convert.ToInt32(VentaId);
                                if (!string.IsNullOrEmpty(VentaId))
                                {
                                    if (MessageBox.Show("¿Está seguro de eliminar esta venta?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        if (_metodosVenta.EliminarVenta(Convert.ToInt32(VentaId)))
                                        {
                                            MessageBox.Show("Venta eliminada correctamente.");
                                            CargarDatos();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al eliminar la venta.");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El ID de la venta no es válido.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al manejar la acción: " + ex.Message);
            }
        }
    }
}
