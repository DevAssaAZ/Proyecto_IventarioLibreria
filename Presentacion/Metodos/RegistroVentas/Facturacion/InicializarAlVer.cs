using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class InicializarAlVer
    {
        public static void InitializeForm(Form form, TextBox txtCedula, TextBox txtCliente, TextBox txtLibro, TextBox txtCantidad, TextBox txtPrecioCantidad, TextBox txtPrecioTotal, TextBox txtDescuento, TextBox txtPrecio, RichTextBox rtbDetalles, ComboBox cbPago, TextBox txtFactura, Button btnProcesar, Button btnAplicar, ComboBox cbDescuento, TextBox txtDescuentoAplicar, Label lblDescuento, string cedula, string cliente, string libro, string cantidad, string precio_cantidad, string detalles, string descuento, string precio_total, string metodo_pago, string num_factura)
        {
            txtCedula.Text = cedula;
            txtCliente.Text = cliente;
            txtLibro.Text = libro;
            txtCantidad.Text = cantidad;
            txtPrecioCantidad.Text = precio_cantidad;
            txtPrecioTotal.Text = precio_total;
            txtDescuento.Text = descuento;
            txtPrecio.Text = precio_cantidad;
            rtbDetalles.Text = detalles;
            cbPago.Text = metodo_pago;
            txtFactura.Text = num_factura;
            btnProcesar.Visible = false;
            btnAplicar.Visible = false;
            cbPago.Enabled = false;
            cbDescuento.Enabled = false;
            txtDescuentoAplicar.Visible = false;
            rtbDetalles.ReadOnly = true;
            lblDescuento.Visible = false;
        }
    }
}
