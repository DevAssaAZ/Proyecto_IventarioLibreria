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
            string query = @"
            UPDATE TB_VENTAS 
            SET UsuarioId = @UsuarioId, ClienteId = @ClienteId, LibroId = @LibroId, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal
            WHERE Id = @VentaId";

            try
            {
                using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VentaId", ventaId);
                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        command.Parameters.AddWithValue("@ClienteId", clienteId);
                        command.Parameters.AddWithValue("@LibroId", libroId);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@PrecioTotal", precioTotal);

                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la venta: " + ex.Message);
            }
        }

    }
}
