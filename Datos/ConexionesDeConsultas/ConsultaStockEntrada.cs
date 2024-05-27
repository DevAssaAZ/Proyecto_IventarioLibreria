using Datos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos.ConexionesDeConsultas
{
    public class ConsultaStockEntrada: ConnectionToSql
    {

        //Metodo para mostrar
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();
        public DataTable MostrarStockEntrada()
        {
            string storedProcedure = "MostrarEntrada";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (var command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        conexion.Open();
                        using (var leer = command.ExecuteReader())
                        {
                            tabla.Load(leer);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar el stock de entrada: " + ex.Message);
            }

            return tabla;
        }



        //Insertar stock de entrada
        public bool InsertarStockEntrada(int idLibro, int Cantidad, DateTime Fecha, string proveedor, string comentarios)
        {
            string storedProcedure = "RegistrarEntrada";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@libro_id", idLibro);
                        command.Parameters.AddWithValue("@cantidad", Cantidad);
                        command.Parameters.AddWithValue("@fecha", Fecha);
                        command.Parameters.AddWithValue("@proveedor", proveedor);
                        command.Parameters.AddWithValue("@comentarios", comentarios);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Stock de entrada: " + ex.Message);
            }
        }



        // Método para eliminar Stock
        public bool EliminarStockEntrada(int id)
        {
            string storedProcedure = "EliminarEntrada";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@entrada_id", id);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Stock de entrada: " + ex.Message);
            }
        }






    }
}
