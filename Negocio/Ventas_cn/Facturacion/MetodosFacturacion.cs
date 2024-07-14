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
    public class MetodosFacturacion
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

    }
}
