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
using Presentacion.Metodos.RegistroClientes;


namespace Presentacion.Modulos.RegistroClientes
{
    public partial class RegistroCliente : Form
    {
        private string idCliente = null;
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void dgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llamada del metodo para las acciones de la tabla de clientes
            AccionesDelDataGridViewClientes.AccionesTablaClientes(dgvInformacion, e, txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, ref idCliente, btnNuevo, btnCancelar, panelContenedor, panelPrincipal, btnRegistrarCliente);
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

            // Llamada al metodo para cargar datos de cliente enel formulario
            DatosLoaderClientes.CargarDatosClientes(dgvInformacion);
            //Llamada del Metodo para limpiar campos
            LimpiarCamposdeRegistro.LimpiarCampos(txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, dgvInformacion);

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para registrar y actualizar clientes
            RegistrarActualizarClientes.RegistrarActualizarCliente(btnRegistrarCliente, idCliente, txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, dgvInformacion, panelContenedor, panelPrincipal, btnNuevo, btnCancelar);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para un nuevo registo
            NuevoRegistroCliente.NuevoRegistro(btnNuevo, btnCancelar, dgvInformacion, panelContenedor, txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, panelPrincipal);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para cancelar operaciones
            CancelarOperacionRegistroCliente.Cancelar(btnNuevo, btnCancelar, panelContenedor, panelPrincipal, dgvInformacion);
        }
    }
}
