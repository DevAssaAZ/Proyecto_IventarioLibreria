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



    public class ConsultasLibro : ConnectionToSql
    {



        // Método para mostrar libros
        public DataTable MostrarLibros()
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("MostrarLibros", conexion))
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
                throw new Exception("Error al mostrar los libros: " + ex.Message);
            }
        }

        // Método para insertar libro
        public bool InsertarLibro(string titulo, string autor, int anio, int cantidad, decimal precio)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("InsertarLibro", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@titulo", titulo);
                        command.Parameters.AddWithValue("@autor", autor);
                        command.Parameters.AddWithValue("@anio", anio);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precio", precio);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar libro: " + ex.Message);
            }
        }

        // Método para editar libro
        public bool EditarLibro(int id, string titulo, string autor, int anio, int cantidad, decimal precio)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EditarLibro", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@titulo", titulo);
                        command.Parameters.AddWithValue("@autor", autor);
                        command.Parameters.AddWithValue("@anio", anio);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precio", precio);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar libro: " + ex.Message);
            }
        }

        // Método para eliminar libro
        public bool EliminarLibro(int id)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EliminarLibro", conexion))
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
                throw new Exception("Error al eliminar libro: " + ex.Message);
            }
        }




    }
}
