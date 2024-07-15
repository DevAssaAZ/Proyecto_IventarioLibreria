using Negocio.Ventas_cn.Facturacion;
using Presentacion.Modulos.RegistroVentas.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class ProcesarFactura
    {
        public static void ProcesarFacturacion(ComboBox cbDescuento, ComboBox cbPago, TextBox txtFactura, TextBox txtCedula, TextBox txtCliente, TextBox txtLibro, TextBox txtCantidad, TextBox txtPrecioCantidad, RichTextBox rtbDetalles, TextBox txtDescuento, TextBox txtPrecioTotal)
        {
            facturacion form = new facturacion();
            try
            {
                // Validar que se haya seleccionado una opción en el ComboBox de descuento
                if (cbDescuento.Text == "SELECCIONAR")
                {
                    MessageBox.Show("Por favor, seleccione si aplica o no un descuento.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya seleccionado una opción en el ComboBox de método de pago
                if (cbPago.Text == "SELECCIONAR")
                {
                    MessageBox.Show("Por favor, seleccione un método de pago.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MetodosFacturacion facturacion = new MetodosFacturacion();
                facturacion.NumFactura = txtFactura.Text;
                facturacion.Cedula = txtCedula.Text;
                facturacion.Cliente = txtCliente.Text;
                facturacion.Libro = txtLibro.Text;
                facturacion.Cantidad = Convert.ToInt32(txtCantidad.Text);
                facturacion.PrecioCantidad = Convert.ToDecimal(txtPrecioCantidad.Text);
                facturacion.Detalles = rtbDetalles.Text;

                // Convertir el descuento solo si no es "NO APLICA"
                facturacion.Descuento = cbDescuento.Text == "NO APLICA" ? 0 : Convert.ToDecimal(txtDescuento.Text);

                facturacion.PrecioTotal = Convert.ToDecimal(txtPrecioTotal.Text);
                facturacion.MetodoDePago = cbPago.Text;

                if (facturacion.InsertarFacturacion())
                {
                    MessageBox.Show("Facturación registrada con éxito.");
                    // Si deseas cerrar el formulario después de procesar la facturación, puedes pasar una referencia del formulario a este método y cerrarlo aquí.
                  
                    form.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la facturación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la facturación: " + ex.Message);
            }
        }

    }
}
