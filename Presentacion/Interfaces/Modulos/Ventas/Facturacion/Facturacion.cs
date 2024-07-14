using Negocio.Ventas_cn;
using Negocio.Ventas_cn.Facturacion;
using Presentacion.Metodos.AbrirYCerrarFormularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.RegistroVentas.Facturacion
{
    public partial class facturacion : Form
    {
        MetodosFacturacion factura = new MetodosFacturacion();
        private decimal descuentoCalculado;
        private decimal precioConDescuento;
        public facturacion(int ventaId)
        {
            InitializeComponent();
            MostrarInformacionVenta(ventaId);
            ComboBoxSeleccionar();
        }

        public facturacion()
        {
            InitializeComponent();
            ComboBoxSeleccionar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Llamada al metodo para cerrar formularios
            CerrarFormularios.Cerrarform(this);
        }

        private void MostrarInformacionVenta(int ventaId)
        {
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
        private string GenerateRandomInvoiceNumber()
        {
            Random random = new Random();
            int invoiceNumber = random.Next(100000000, 1000000000); // Generar un número de 9 dígitos
            return invoiceNumber.ToString();
        }

        private void ComboBoxSeleccionar()
        {
            cbDescuento.SelectedIndex = 0;

            cbPago.SelectedIndex = 0;


        }

        private void cbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el ítem seleccionado es "Aplica", activar los botones
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

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CalculoFacturacion calculo = new CalculoFacturacion();
            try
            {
                decimal porcentajeDescuento = Convert.ToDecimal(txtDescuentoAplicar.Text);
                decimal precioTotal = Convert.ToDecimal(txtPrecioCantidad.Text);
                descuentoCalculado = calculo.CalcularDescuento(precioTotal, porcentajeDescuento);
                precioConDescuento = precioTotal - descuentoCalculado;
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
