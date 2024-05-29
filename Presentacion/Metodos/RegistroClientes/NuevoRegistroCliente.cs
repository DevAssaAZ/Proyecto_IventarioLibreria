using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroClientes
{
    public static class NuevoRegistroCliente
    {
        //Metodo para el boton de nuevo registro que abre la ventana de registro
        public static void NuevoRegistro(Button btnNuevo, Button btnCancelar, DataGridView dgvInformacion, Panel panelContenedor, TextBox txtNombre, TextBox txtApellido, TextBox txtCedula, TextBox txtEdad, TextBox txtCorreo, Panel panelPrincipal)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;
            dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panelContenedor.Visible = true;

            // Llamada del Método para limpiar campos
            LimpiarCamposdeRegistroClientes.LimpiarCampos(txtNombre, txtApellido, txtCedula, txtEdad, txtCorreo, dgvInformacion);

            panelPrincipal.Size = new Size(437, 463);
        }

    }
}
