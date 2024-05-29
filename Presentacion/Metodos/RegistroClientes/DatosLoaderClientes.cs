using Negocio.Clientes_cn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion.Metodos.RegistroClientes
{
    public static class DatosLoaderClientes
    {
        //Metodo para cargar datos en el formulario de clientes
        public static void CargarDatosClientes(DataGridView dgvInformacion)
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


    }
}
