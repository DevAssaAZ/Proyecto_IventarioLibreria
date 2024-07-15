using Negocio.Ventas_cn.Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class DatosLoaderFacturacion
    {
        public static void CargarDatos(DataGridView dgvFacturacion)
        {
            MetodosFacturacion fac = new MetodosFacturacion();
            DataTable dt = fac.MostrarFacturaciones();
            dgvFacturacion.DataSource = dt;
            dgvFacturacion.ClearSelection();
            dgvFacturacion.AutoGenerateColumns = false;

            dgvFacturacion.Columns["VER"].DisplayIndex = 0;
            dgvFacturacion.Columns["ELIMINAR"].DisplayIndex = 1;
            dgvFacturacion.Columns["ID"].DisplayIndex = 2;
            dgvFacturacion.Columns["NUM_FACTURA"].DisplayIndex = 3;
            dgvFacturacion.Columns["CEDULA"].DisplayIndex = 4;
            dgvFacturacion.Columns["CLIENTE"].DisplayIndex = 5;
            dgvFacturacion.Columns["LIBRO"].DisplayIndex = 6;
            dgvFacturacion.Columns["CANTIDAD"].DisplayIndex = 7;
            dgvFacturacion.Columns["PRECIO_CANTIDAD"].DisplayIndex = 8;
            dgvFacturacion.Columns["DETALLES"].DisplayIndex = 9;
            dgvFacturacion.Columns["DESCUENTO"].DisplayIndex = 10;
            dgvFacturacion.Columns["PRECIO_TOTAL"].DisplayIndex = 11;
            dgvFacturacion.Columns["METODO_DE_PAGO"].DisplayIndex = 12;
            dgvFacturacion.Columns["ESTADO"].DisplayIndex = 13;
        }
    }
}
