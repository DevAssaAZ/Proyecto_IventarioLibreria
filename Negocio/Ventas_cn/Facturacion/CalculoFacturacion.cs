using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ventas_cn.Facturacion
{
    public class CalculoFacturacion
    {
        //Metodo para realizar descuentos
        public decimal CalcularDescuento(decimal precioTotal, decimal porcentajeDescuento)
        {
            return precioTotal * (porcentajeDescuento / 100);
        }
    }
}
