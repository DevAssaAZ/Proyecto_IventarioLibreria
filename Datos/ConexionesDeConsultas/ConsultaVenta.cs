using Datos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ConexionesDeConsultas
{
    public class ConsultasVenta : ConnectionToSql
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        // Método para mostrar usuarios
        public DataTable MostrarUsuariosConsulta()
        {
            string query = "SELECT ID, USUARIO FROM TB_LOGIN";
            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                } // La conexión se cerrará automáticamente al salir del bloque 'using'
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los usuarios: " + ex.Message);
            }
        }

        // Método para mostrar clientes
        public DataTable MostrarClientes()
        {
            string query = "SELECT Id, Nombre FROM Clientes"; // Usar los nombres de columna reales
            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                } // La conexión se cerrará automáticamente al salir del bloque 'using'
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los clientes: " + ex.Message);
            }
        }

        // Método para registrar una venta
        public bool RegistrarVenta(int libroId, int usuarioId, int clienteId, int cantidad, decimal precioTotal)
        {
            string query = @"
            INSERT INTO TB_VENTAS (UsuarioId, ClienteId, LibroId, Cantidad, PrecioTotal)
            VALUES (@UsuarioId, @ClienteId, @LibroId, @Cantidad, @PrecioTotal)";

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                throw new Exception("Error al registrar la venta: " + ex.Message);
            }
        }

        // Método para mostrar ventas
        public DataTable MostrarVentas()
        {
            string query = @"
            SELECT 
                v.Id AS VentaId, 
                u.Usuario AS Usuario, 
                c.Nombre AS Cliente, 
                c.Cedula, 
                l.Titulo AS Libro, 
                v.PrecioTotal AS Precio, 
                v.Cantidad
            FROM 
                TB_VENTAS v
            JOIN 
                TB_LOGIN u ON v.UsuarioId = u.Id
            JOIN 
                Clientes c ON v.ClienteId = c.Id
            JOIN 
                TB_LIBROS l ON v.LibroId = l.Id";

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al mostrar ventas: " + ex.Message);
            }
        }
    }
}
