using Negocio.Ventas_cn;
using Negocio.Ventas_cn.Facturacion;
using Presentacion.Interfaces.Modulos.Ventas.Facturacion;
using Presentacion.Metodos.AbrirYCerrarFormularios;
using Presentacion.Metodos.RegistroVentas.Facturacion;
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

        public facturacion( string id, string num_factura, string cedula, string cliente, string libro, string cantidad, string precio_cantidad, string detalles, string descuento, string precio_total, string metodo_pago, string estado)
        {
            InitializeComponent();
            //Llamada del metodo Para Mostrar los campos llenos al darle a la opcion de Ver, en el historial de facturacion
            InicializarAlVer.InitializeForm(this, txtCedula, txtCliente, txtLibro, txtCantidad, txtPrecioCantidad, txtPrecioTotal, txtDescuento, txtPrecio, rtbDetalles, cbPago, txtFactura, btnProcesar, btnAplicar, cbDescuento, txtDescuentoAplicar, lblDescuento, cedula, cliente, libro, cantidad, precio_cantidad, detalles, descuento, precio_total, metodo_pago, num_factura);

        }





        public facturacion(int ventaId)
        {
            InitializeComponent();
            //Llamada del metodo que me muestra los datos de la venta en la facturacion
            VentasFacturacion.MostrarInformacionVenta(ventaId, txtCedula, txtCliente, txtLibro, txtCantidad, txtPrecioCantidad, txtFactura);
            //Llamada del metodo para tener un item de inicio en los combobox
            IniciarComboBox.ComboBoxSeleccionar(cbDescuento, cbPago);
        }

        public facturacion()
        {
            InitializeComponent();
            //Llamada del metodo para tener un item de inicio en los combobox
            IniciarComboBox.ComboBoxSeleccionar(cbDescuento, cbPago);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Llamada al metodo para cerrar formularios
            CerrarFormularios.Cerrarform(this);
        }

        private void cbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llamada para el metodo Si el ítem seleccionado es "Aplica", activar los botones
            ComboBoxDescuentos.HandleDescuentoSelectedIndexChanged(cbDescuento, lblDescuento, txtDescuentoAplicar, btnAplicar, txtPrecioCantidad, txtPrecio, txtDescuento, txtPrecioTotal, descuentoCalculado, precioConDescuento);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para Aplicar los descuentos
            DescuentoAplicar.AplicarDescuento(txtDescuentoAplicar, txtPrecioCantidad, txtPrecio, txtDescuento, txtPrecioTotal);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para procesar (insertar) La factura
            ProcesarFactura.ProcesarFacturacion(cbDescuento, cbPago, txtFactura, txtCedula, txtCliente, txtLibro, txtCantidad, txtPrecioCantidad, rtbDetalles, txtDescuento, txtPrecioTotal);
        }
    }
}
