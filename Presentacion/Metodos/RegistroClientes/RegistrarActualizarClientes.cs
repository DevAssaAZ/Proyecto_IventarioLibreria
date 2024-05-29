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
    public static class RegistrarActualizarClientes
    {
        //Metodo Para actualizar y registrar Clientes
        public static void RegistrarActualizarCliente(Button btnRegistrarCliente, string idCliente, TextBox txtNombre, TextBox txtApellido, TextBox txtCedula, TextBox txtEdad, TextBox txtCorreo, DataGridView dgvInformacion, Panel panelContenedor, Panel panelPrincipal, Button btnNuevo, Button btnCancelar)
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
                        MessageBox.Show("Cliente Registrado Con Exito");
                        // Llamada al método para cargar datos de cliente en el formulario
                        DatosLoaderClientes.CargarDatosClientes(dgvInformacion);
                        // Llamada del método para limpiar campos
                        LimpiarCamposdeRegistroClientes.LimpiarCampos(txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, dgvInformacion);
                        btnNuevo.Visible = true;
                        btnCancelar.Visible = false;
                        panelContenedor.Visible = false;
                        panelPrincipal.Size = new Size(1020, 632);
                        dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el cliente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al comprobar cliente: " + ex.Message);
                }
            }
            else if (btnRegistrarCliente.Text == "Actualizar")
            {
                try
                {
                    cliente_N.Id = Convert.ToInt32(idCliente);
                    cliente_N.Nombre = txtNombre.Text;
                    cliente_N.Apellido = txtApellido.Text;
                    cliente_N.Cedula = txtCedula.Text;
                    cliente_N.Edad = Convert.ToInt32(txtEdad.Text);
                    cliente_N.Correo = txtCorreo.Text;

                    // Lógica para actualizar los datos en la base de datos
                    bool resultado = cliente_N.EditarClientes();
                    if (resultado)
                    {
                        MessageBox.Show("Datos del cliente actualizados con éxito.");
                        // Llamada al método para cargar datos de cliente en el formulario
                        DatosLoaderClientes.CargarDatosClientes(dgvInformacion);
                        // Llamada del método para limpiar campos
                        LimpiarCamposdeRegistroClientes.LimpiarCampos(txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, dgvInformacion);
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
        }
    }
}
