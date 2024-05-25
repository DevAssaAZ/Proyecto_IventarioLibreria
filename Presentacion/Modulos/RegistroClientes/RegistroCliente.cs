using Negocio.Clientes_cn;
using Negocio.Usuarios_cn;
using Presentacion.Login;
using Presentacion.Modulos.RegistroUsuarios;
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
        MetodosCliente obj_cliente = new MetodosCliente();
        private string idCliente = null;
        public RegistroCliente()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                        if (dgvInformacion.Columns[e.ColumnIndex].Name == "ELIMINAR")
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
                                        CargarDatos();

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

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            
            CargarDatos();
            LimpiarCampos();

        }

        private void CargarDatos()
        {
            MetodosCliente cliente = new MetodosCliente();
            DataTable dt = cliente.MostrarClientes();
            dgvInformacion.DataSource = dt;
            dgvInformacion.ClearSelection();
            dgvInformacion.AutoGenerateColumns = false;
            dgvInformacion.Columns["ID"].DisplayIndex = 0;
            dgvInformacion.Columns["NOMBRE"].DisplayIndex = 1;
            dgvInformacion.Columns["APELLIDO"].DisplayIndex = 2;
            dgvInformacion.Columns["CEDULA"].DisplayIndex = 3;
            dgvInformacion.Columns["EDAD"].DisplayIndex = 4;
            dgvInformacion.Columns["CORREO"].DisplayIndex = 5;
            dgvInformacion.Columns["Ver"].DisplayIndex = 6;
            dgvInformacion.Columns["Editar"].DisplayIndex = 7;
            dgvInformacion.Columns["Eliminar"].DisplayIndex = 8;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            MetodosCliente cliente_N = new MetodosCliente();

            if (btnRegistrarCliente.Text == "Registrar")
            {
                try
                {

                    cliente_N.Nombre = txtNombre.Text;
                    cliente_N.Apellido = txtApellido.Text;
                    cliente_N.Cedula = txtCedula.Text;
                    cliente_N.Edad = Convert.ToInt32(txtEdad.Text);
                    cliente_N.Correo = txtCorreo.Text;
                    

                   

                    if (cliente_N.InsertarClientes())
                    {
                        MessageBox.Show("Registrado con éxito");
                        // Vuelve a cargar los datos en el DataGridView
                        CargarDatos();
                        // Limpia los TextBox después de la inserción
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtCedula.Clear();
                        txtEdad.Clear();
                        txtCorreo.Clear();
                        btnNuevo.Visible = true;
                        btnCancelar.Visible = false;
                        panelContenedor.Visible = false;
                        panelPrincipal.Size = new Size(1020, 632);
                        dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al comprobar usuario: " + ex.Message);
                }
            }
            if (btnRegistrarCliente.Text == "Actualizar")
            {
                cliente_N.Id = Convert.ToInt32(idCliente);
                cliente_N.Nombre = txtNombre.Text;
                cliente_N.Apellido = txtApellido.Text;
                cliente_N.Cedula = txtCedula.Text;
                cliente_N.Edad = Convert.ToInt32(txtEdad.Text);
                cliente_N.Correo = txtCorreo.Text;


                try
                {
                    // Lógica para actualizar los datos en la base de datos
                    bool resultado = cliente_N.EditarClientes() ;
                    if (resultado)
                    {
                        MessageBox.Show("Datos actualizados con éxito.");
                        // Vuelve a cargar los datos en el DataGridView
                        CargarDatos();
                        // Limpia los TextBox después de la inserción
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtCedula.Clear();
                        txtEdad.Clear();
                        txtCorreo.Clear();
                        btnNuevo.Visible = true;
                        btnCancelar.Visible = false;
                        panelContenedor.Visible = false;
                        panelPrincipal.Size = new Size(1020, 632);
                        dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                btnRegistrarCliente.Text = "Registrar";

            }






            try
            {
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible =false;
            btnCancelar.Visible = true;
            dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panelContenedor.Visible = true;
            LimpiarCampos();
            panelPrincipal.Size = new Size(437, 463);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = true;
            btnCancelar.Visible = false;
            panelContenedor.Visible = false;
            panelPrincipal.Size = new Size(1020, 632);
            dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarDatos();
        }
    }
}
