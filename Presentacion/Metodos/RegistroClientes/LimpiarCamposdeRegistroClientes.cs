using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroClientes
{
    public static class LimpiarCamposdeRegistroClientes
    {
        //Metodo para limpiar los campos de la pantalla de registros
        public static void LimpiarCampos(TextBox txtNombre, TextBox txtApellido, TextBox txtCedula, TextBox txtEdad, TextBox txtCorreo, DataGridView dgvInformacion)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            dgvInformacion.ClearSelection();
        }

    }
}
