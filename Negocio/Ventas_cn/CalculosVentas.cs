using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ventas_cn
{
    public class CalculosVentas : Ventas_N
    {
        public decimal CalculoVentas(decimal precio, decimal cantidad)
        {
            return precio * cantidad;
        }


    }
}
