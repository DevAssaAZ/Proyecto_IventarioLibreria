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
    public static class VentasFacturacion
    {

        public static void MostrarInformacionVenta(int ventaId, TextBox txtCedula, TextBox txtCliente, TextBox txtLibro, TextBox txtCantidad, TextBox txtPrecioCantidad, TextBox txtFactura)
        {
            MetodosFacturacion factura = new MetodosFacturacion();
            DataTable dt = factura.ObtenerInformacionVenta(ventaId);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtCedula.Text = row["CEDULA"].ToString();
                txtCliente.Text = row["ClienteNombre"].ToString();
                txtLibro.Text = row["LibroTitulo"].ToString();
                txtCantidad.Text = row["CANTIDAD"].ToString();
                txtPrecioCantidad.Text = row["PRECIOTOTAL"].ToString();
                txtFactura.Text = GenerateRandomInvoiceNumber();
            }
        }

        private static string GenerateRandomInvoiceNumber()
        {
            Random random = new Random();
            return random.Next(100000000, 999999999).ToString();
        }
    }
}
