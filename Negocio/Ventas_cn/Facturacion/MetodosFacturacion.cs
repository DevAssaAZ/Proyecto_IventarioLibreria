using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.ConexionesDeConsultas;
using Datos.ConexionesDeConsultas.Ventas.Facturacion;

namespace Negocio.Ventas_cn.Facturacion
{
    public class MetodosFacturacion : Facturacion_N
    {
        private ConsultasDeFacturacion facturacion = new ConsultasDeFacturacion();

        public DataTable ObtenerInformacionVenta(int ventaId)
        {
            return facturacion.ObtenerInformacionVenta(ventaId);
        }



        public DataTable MostrarFacturaciones()
        {
            return facturacion.MostrarFacturaciones();
        }


        public bool InsertarFacturacion()
        {
            try
            {
                facturacion.InsertarFacturacion(NumFactura, Cedula, Cliente, Libro, Cantidad, PrecioCantidad, Detalles, Descuento, PrecioTotal, MetodoDePago);
                return true;
            }
            catch (Exception ex)
            {
                // Aquí podrías manejar el error de alguna forma, como registrar el error en un log
                Console.WriteLine("Error al registrar la facturación: " + ex.Message);
                return false;
            }
        }


        public bool EliminarFacturacion()
        {
            return facturacion.EliminarFacturacion(Id);
        }

    }
}
