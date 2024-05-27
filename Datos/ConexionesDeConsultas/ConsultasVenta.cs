using Datos.ConexionSQL;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ConexionesDeConsultas
{
    public class ConsultasVenta : ConnectionToSql
    {
        //Metodo para Mostrar Ventas 
        public DataTable MostrarVentas()
        {
            string storedProcedure = "MostrarVentas";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable tabla = new DataTable();
                        tabla.Load(reader);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar las ventas: " + ex.Message);
            }
        }


        //Metodo para insertar la venta
        public bool InsertarVenta(int usuario_id, int cliente_id, int libro_id, int cantidad, decimal precio_total)
        {
            string storedProcedure = "InsertarVenta";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@usuario_id", usuario_id);
                        command.Parameters.AddWithValue("@cliente_id", cliente_id);
                        command.Parameters.AddWithValue("@libro_id", libro_id);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precio_total", precio_total);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la venta y actualizar el stock: " + ex.Message);
            }
        }



        //Metodo para editar ventas 
        public bool EditarVenta(int venta_id, int usuario_id, int cliente_id, int libro_id, int cantidad, decimal precio_total)
        {
            string storedProcedure = "EditarVenta";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@venta_id", venta_id);
                        command.Parameters.AddWithValue("@usuario_id", usuario_id);
                        command.Parameters.AddWithValue("@cliente_id", cliente_id);
                        command.Parameters.AddWithValue("@libro_id", libro_id);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@precio_total", precio_total);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la venta: " + ex.Message);
            }
        }




        //Metodo para eliminar ventas
        public bool EliminarVenta(int venta_id)
        {
            string storedProcedure = "EXEC EliminarVenta @venta_id";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@venta_id", venta_id);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la venta: " + ex.Message);
            }
        }








    }
}
