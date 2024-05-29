using Presentacion.Metodos.RegistroClientes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroLibros
{
    public static class CancelarOperacionRegistroLibro
    {
        //Metodo para el boton cancelar de libros
        public static void Cancelar(Button btNuevo, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal, DataGridView dgvLibro)
        {
            if (MessageBox.Show("Deseas cancelar el registro de Libros?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                btNuevo.Visible = true;
                btnCancelar.Visible = false;
                panelContenedor.Visible = false;
                panelPrincipal.Size = new Size(1020, 632);
                dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Llamada la metodo de Cargar datos de libros
                DatosLoaderLibros.CargarDatosLibros(dgvLibro);
            }


        }

    }
}
