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


        // Método para mostrar clientes
        public DataTable MostrarClientes()
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("MostrarClientes", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        SqlDataReader leer = command.ExecuteReader();
                        DataTable tabla = new DataTable();
                        tabla.Load(leer);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los clientes: " + ex.Message);
            }
        }

        // Método para insertar cliente
        public bool InsertarCliente(string nombre, string apellido, string cedula, int edad, string correo)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("InsertarCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@cedula", cedula);
                        command.Parameters.AddWithValue("@edad", edad);
                        command.Parameters.AddWithValue("@correo", correo);

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
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EditarCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@cedula", cedula);
                        command.Parameters.AddWithValue("@edad", edad);
                        command.Parameters.AddWithValue("@correo", correo);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar cliente: " + ex.Message);
            }
        }

        // Método para eliminar cliente
        public bool EliminarCliente(int id)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EliminarCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }

    }
}
