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

        // Método para mostrar usuarios
        public DataTable MostrarUsuarios()
        {
            return consultasVenta.MostrarUsuariosConsulta();
        }

        // Método para mostrar clientes
        public DataTable MostrarClientes()
        {
            return consultasVenta.MostrarClientes();
        }

        // Método para registrar una venta
        public bool RegistrarVenta(int libroId, int usuarioId, int clienteId, int cantidad, decimal precioTotal)
        {
            return consultasVenta.RegistrarVenta(libroId, usuarioId, clienteId, cantidad, precioTotal);
        }
        public DataTable MostrarVentas()
        {
            return consultasVenta.MostrarVentas();
        }

        public bool ActualizarVenta(int ventaId, int libroId, int usuarioId, int clienteId, int cantidad, decimal precioTotal)
        {
            try
            {
                return consultasVenta.ActualizarVenta(ventaId, libroId, usuarioId, clienteId, cantidad, precioTotal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar venta: " + ex.Message);
            }
        }

        public bool EliminarVenta(int id)
        {
            return consultasVenta.EliminarVenta(Id);
        }


    }
}
