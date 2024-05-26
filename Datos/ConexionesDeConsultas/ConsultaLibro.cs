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
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        // Método para mostrar libros
        public DataTable MostrarLibros()
        {
            string query = "SELECT * FROM TB_LIBROS";
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
                throw new Exception("Error al mostrar los libros: " + ex.Message);
            }
        }

        // Método para insertar libro
        public bool InsertarLibro(string titulo, string autor, int anio, int cantidad, decimal precio)
        {
            string query = "INSERT INTO TB_LIBROS (TITULO, AUTOR, ANIO, CANTIDAD, PRECIO) VALUES (@Titulo, @Autor, @Anio, @Cantidad, @Precio)";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Autor", autor);
                        command.Parameters.AddWithValue("@Anio", anio);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Precio", precio);

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
            string query = "UPDATE TB_LIBROS SET TITULO = @Titulo, AUTOR = @Autor, ANIO = @Anio, CANTIDAD = @Cantidad, PRECIO = @Precio WHERE ID = @ID";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Autor", autor);
                        command.Parameters.AddWithValue("@Anio", anio);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@ID", id);

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
            string query = "DELETE FROM TB_LIBROS WHERE ID = @ID";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ID", id);

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
