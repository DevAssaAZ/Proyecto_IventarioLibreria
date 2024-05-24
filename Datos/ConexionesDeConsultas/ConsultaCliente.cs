using Datos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ConexionesDeConsultas
{
    public class ConsultasCliente : ConnectionToSql
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        // Método para mostrar clientes
        public DataTable MostrarClientes()
        {
            string query = "SELECT Id, Nombre, Apellido, Cedula, Edad, Correo FROM Clientes";
            try
            {
                command.Connection = AbrirConexion();
                command.CommandText = query;
                leer = command.ExecuteReader();
                tabla.Load(leer);
                CerrarConexion();
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los clientes: " + ex.Message);
            }
        }

        // Método para insertar cliente
        public bool InsertarCliente(string nombre, string apellido, string cedula, int edad, string correo)
        {
            string query = "INSERT INTO Clientes (Nombre, Apellido, Cedula, Edad, Correo) VALUES (@Nombre, @Apellido, @Cedula, @Edad, @Correo)";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@Correo", correo);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
        }

        // Método para editar cliente
        public bool EditarCliente(int id, string nombre, string apellido, string cedula, int edad, string correo)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, Edad = @Edad, Correo = @Correo WHERE ID = @ID";
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Cedula", cedula);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@ID", id);
                    command.CommandType = CommandType.Text;
                    int resultado = command.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }

        // Método para eliminar cliente
        public bool EliminarCliente(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "DELETE FROM Clientes WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", id);
                    command.CommandType = CommandType.Text;
                    int resultado = command.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }
    }
}
