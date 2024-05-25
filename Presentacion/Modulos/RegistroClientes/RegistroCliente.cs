using Negocio.Clientes_cn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion.Modulos.RegistroClientes
{
    public partial class RegistroCliente : Form
    {
        DataTable dt = new DataTable();
        public RegistroCliente()
        {
            InitializeComponent();
            dgvInformacion.SelectionChanged += dgvInformacion_SelectionChanged;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dgvInformacion.Columns.Add("nombre", "Nombre");
            dgvInformacion.Columns.Add("apellido", "Apellido");
            dgvInformacion.Columns.Add("cedula", "Cedula");
            dgvInformacion.Columns.Add("edad", "Edad");
            dgvInformacion.Columns.Add("correo", "Correo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvInformacion.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {
                        txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Nombre"
                        txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Apellido"
                        txtCedula.Text = row.Cells["Cedula"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Cedula"
                        txtEdad.Text = row.Cells["Edad"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Edad"
                        txtCorreo.Text = row.Cells["Correo"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Correo"
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

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarCampos();
            dgvInformacion.ClearSelection();

        }

        private void CargarDatos()
        {
            MetodosCliente cliente_N = new MetodosCliente();
            DataTable dt = cliente_N.MostrarClientes();
            dgvInformacion.DataSource = dt;
            dgvInformacion.ClearSelection();
            dgvInformacion.AutoGenerateColumns = false;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MetodosCliente cliente_N = new MetodosCliente();
                cliente_N.Nombre =txtNombre.Text;
                cliente_N.Apellido = txtApellido.Text;
                cliente_N.Cedula = txtCedula.Text;
                cliente_N.Edad = Convert.ToInt32(txtEdad.Text);
                cliente_N.Correo = txtCorreo.Text;
                cliente_N.InsertarClientes();

                // Limpia los TextBox después de la inserción
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtEdad.Clear();
                txtCorreo.Clear();

                // Vuelve a cargar los datos en el DataGridView
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInformacion.CurrentRow != null)
                {
                    MetodosCliente cliente = new MetodosCliente();
                    cliente.Id = Convert.ToInt32(dgvInformacion.CurrentRow.Cells["Id"].Value);
                    MetodosCliente cliente_N = new MetodosCliente();
                    cliente_N.EliminarCliente(cliente.Id);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();

                    // Limpia los TextBox después de la eliminación
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCedula.Clear();
                    txtEdad.Clear();
                    txtCorreo.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un cliente para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dgvInformacion.CurrentRow != null)
                {
                    // Obtener el ID del cliente seleccionado
                    int id = Convert.ToInt32(dgvInformacion.CurrentRow.Cells["Id"].Value);

                    // Obtener los datos de los TextBox
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string cedula = txtCedula.Text;
                    int edad = int.Parse(txtEdad.Text);
                    string correo = txtCorreo.Text;

                    // Actualizar el cliente en la base de datos
                    MetodosCliente cliente_N = new MetodosCliente();
                    cliente_N.ActualizarCliente();

                    // Actualizar los datos en el DataGridView
                    dgvInformacion.CurrentRow.Cells["Nombre"].Value = nombre;
                    dgvInformacion.CurrentRow.Cells["Apellido"].Value = apellido;
                    dgvInformacion.CurrentRow.Cells["Cedula"].Value = cedula;
                    dgvInformacion.CurrentRow.Cells["Edad"].Value = edad;
                    dgvInformacion.CurrentRow.Cells["Correo"].Value = correo;

                    MessageBox.Show("Cambios guardados correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila para guardar los cambios.");
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
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            dgvInformacion.ClearSelection();
        }

        private void dgvInformacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInformacion.CurrentRow != null)
            {
                txtNombre.Text = dgvInformacion.CurrentRow.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtApellido.Text = dgvInformacion.CurrentRow.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                txtCedula.Text = dgvInformacion.CurrentRow.Cells["Cedula"].Value?.ToString() ?? string.Empty;
                txtEdad.Text = dgvInformacion.CurrentRow.Cells["Edad"].Value?.ToString() ?? string.Empty;
                txtCorreo.Text = dgvInformacion.CurrentRow.Cells["Correo"].Value?.ToString() ?? string.Empty;
            }
        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
