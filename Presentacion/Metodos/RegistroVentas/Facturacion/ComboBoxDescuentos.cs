using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class ComboBoxDescuentos
    {
        // Método para manejar el evento SelectedIndexChanged del ComboBox de descuento
        public static void HandleDescuentoSelectedIndexChanged(ComboBox cbDescuento, Label lblDescuento, TextBox txtDescuentoAplicar, Button btnAplicar, TextBox txtPrecioCantidad, TextBox txtPrecio, TextBox txtDescuento, TextBox txtPrecioTotal, decimal descuentoCalculado, decimal precioConDescuento)
        {
            

            // Si el ítem seleccionado es "APLICA", activar los botones y campos de texto
            if (cbDescuento.SelectedItem.ToString() == "APLICA")
            {
                lblDescuento.Enabled = true;
                txtDescuentoAplicar.Enabled = true;
                btnAplicar.Enabled = true;
                txtPrecio.Text = txtPrecioCantidad.Text;
                txtDescuento.Text = descuentoCalculado.ToString("F2");
                txtPrecioTotal.Text = precioConDescuento.ToString("F2");
            }
            else if (cbDescuento.SelectedItem.ToString() == "SELECCIONAR")
            {
                lblDescuento.Enabled = false;
                txtDescuentoAplicar.Enabled = false;
                btnAplicar.Enabled = false;
                txtDescuentoAplicar.Text = "";
                txtPrecio.Text = "";
                txtPrecioTotal.Text = "";
                txtDescuento.Text = "";
            }
            else
            {
                lblDescuento.Enabled = false;
                txtDescuentoAplicar.Enabled = false;
                btnAplicar.Enabled = false;
                txtDescuento.Text = "";
                txtDescuentoAplicar.Text = "";
                txtPrecio.Text = txtPrecioCantidad.Text;
                txtPrecioTotal.Text = txtPrecioCantidad.Text;
            }
        }
    }
}
