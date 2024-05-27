
using Datos.ConexionesDeConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ventas_cn
{
    public class MetodosVenta : Ventas_N
    {
        ConsultasVenta consultasVenta = new ConsultasVenta();

        // Método para mostrar Ventas
        public DataTable MostrarVentas()
        {
            return consultasVenta.MostrarVentas();
        }

        // Método para registrar una venta
        public bool RegistrarVenta()
        {
            return consultasVenta.InsertarVenta(LibroId, UsuarioId, ClienteId, Cantidad, PrecioTotal);
        }

        public bool EditarVenta()
        {
            try
            {
                return consultasVenta.EditarVenta(Id, LibroId, UsuarioId, ClienteId, Cantidad, PrecioTotal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar venta: " + ex.Message);
            }
        }

        public bool EliminarVenta()
        {
            return consultasVenta.EliminarVenta(Id);
        }


    }
}
