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

            // Configurar las columnas manualmente
            dgvVenta.Columns.Clear();

            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Usuario", DataPropertyName = "Usuario" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cliente", DataPropertyName = "Cliente" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cedula", DataPropertyName = "Cedula" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Libro", DataPropertyName = "Libro" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Precio", DataPropertyName = "Precio" });
            dgvVenta.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cantidad", DataPropertyName = "Cantidad" });

            // Asegurar la recarga de datos y la configuración de columnas
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
                decimal precioTotal = Convert.ToDecimal(txtPrecio.Text) * cantidad;

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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgvVenta.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0)
                    {
                        // Obtener los valores de las celdas
                        object usuarioValue = row.Cells["Usuario"].Value;
                        object clienteValue = row.Cells["Cliente"].Value;
                        object libroValue = row.Cells["Libro"].Value;

                        // Imprimir los valores en la consola para depurar
                        Console.WriteLine("Usuario: " + usuarioValue);
                        Console.WriteLine("Cliente: " + clienteValue);
                        Console.WriteLine("Libro: " + libroValue);

                        // Resto del código para convertir los valores a números...
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


        private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        {
            try
            {
                MetodosVenta venta_N = new MetodosVenta();
                int libroId = Convert.ToInt32(cmbLibros.SelectedValue);
                int usuarioId = Convert.ToInt32(cmbUsuario.SelectedValue);
                int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                int cantidad = Convert.ToInt32(txtCantidadDisponible.Text);
                decimal precioTotal = Convert.ToDecimal(txtPrecio.Text) * cantidad;

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
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dgvVenta.CurrentRow != null)
                {
                    // Obtener el ID de la venta seleccionada
                    int ventaId = Convert.ToInt32(dgvVenta.CurrentRow.Cells["VentaId"].Value);

                    // Obtener los datos de los controles del formulario
                    int usuarioId = Convert.ToInt32(cmbUsuario.SelectedValue);
                    int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                    int libroId = Convert.ToInt32(cmbLibros.SelectedValue);
                    int cantidad = Convert.ToInt32(txtCantidadDisponible.Text);
                    decimal precioTotal = Convert.ToDecimal(txtPrecio.Text);

                    // Crear instancia de MetodosVenta y actualizar la venta
                    MetodosVenta venta_N = new MetodosVenta();
                    bool resultado = venta_N.ActualizarVenta(ventaId, libroId, usuarioId, clienteId, cantidad, precioTotal);

                    if (resultado)
                    {
                        MessageBox.Show("Venta actualizada exitosamente.");

                        // Actualizar los datos en el DataGridView
                        dgvVenta.CurrentRow.Cells["Usuario"].Value = usuarioId;
                        dgvVenta.CurrentRow.Cells["Cliente"].Value = clienteId;
                        dgvVenta.CurrentRow.Cells["Libro"].Value = libroId;
                        dgvVenta.CurrentRow.Cells["Cantidad"].Value = cantidad;
                        dgvVenta.CurrentRow.Cells["Precio"].Value = precioTotal;

                        // Limpiar los controles del formulario después de la actualización
                        LimpiarCampos();

                        // Recargar datos del DataGridView si es necesario
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la venta.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una venta para guardar los cambios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
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
    }
}
