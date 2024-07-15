using Negocio.Ventas_cn.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class DescuentoAplicar
    {
        public static void AplicarDescuento(TextBox txtDescuentoAplicar, TextBox txtPrecioCantidad, TextBox txtPrecio, TextBox txtDescuento, TextBox txtPrecioTotal)
        {
            CalculoFacturacion calculo = new CalculoFacturacion();
            try
            {
                decimal porcentajeDescuento = Convert.ToDecimal(txtDescuentoAplicar.Text);
                decimal precioTotal = Convert.ToDecimal(txtPrecioCantidad.Text);
                decimal descuentoCalculado = calculo.CalcularDescuento(precioTotal, porcentajeDescuento);
                decimal precioConDescuento = precioTotal - descuentoCalculado;
                txtPrecio.Text = txtPrecioCantidad.Text;
                txtDescuento.Text = descuentoCalculado.ToString("F2");
                txtPrecioTotal.Text = precioConDescuento.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un porcentaje de descuento válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el descuento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
