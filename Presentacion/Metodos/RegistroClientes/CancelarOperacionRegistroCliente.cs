using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroClientes
{
    public static class CancelarOperacionRegistroCliente
    {
        //Metodo para el boton cancelar
        public static void Cancelar(Button btnNuevo, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal, DataGridView dgvInformacion)
        {
            if (MessageBox.Show("Deseas cancelar el registro de Cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                btnNuevo.Visible = true;
                btnCancelar.Visible = false;
                panelContenedor.Visible = false;
                panelPrincipal.Size = new Size(1020, 632);
                dgvInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Llamada al método para cargar datos de cliente en el formulario
                DatosLoaderClientes.CargarDatosClientes(dgvInformacion);
            }


        }

    }
}
