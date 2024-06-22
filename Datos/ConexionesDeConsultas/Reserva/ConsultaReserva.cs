using Datos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ConexionesDeConsulta.Reserva
{
    public class ConsultaReserva : ConnectionToSql
    {
        // Método para mostrar reservas
        public DataTable MostrarReservas()
        {
            string storedProcedure = "MostrarReservas";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(storedProcedure, conexion))
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
            catch (SqlException sqlEx)
            {
                throw new Exception("Error al mostrar las reservas: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar las reservas: " + ex.Message);
            }
        }

        // Método para insertar reserva
        public bool InsertarReserva(int usuarioId, int libroId, DateTime fechaReserva, string estado)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("InsertarReserva", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@usuarioId", usuarioId);
                        command.Parameters.AddWithValue("@libroId", libroId);
                        command.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                        command.Parameters.AddWithValue("@estado", estado);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear reserva: " + ex.Message);
            }
        }

        // Método para editar reserva
        public bool EditarReserva(int id, int usuarioId, int libroId, DateTime fechaReserva, string estado)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EditarReserva", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@usuarioId", usuarioId);
                        command.Parameters.AddWithValue("@libroId", libroId);
                        command.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                        command.Parameters.AddWithValue("@estado", estado);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar reserva: " + ex.Message);
            }
        }

        // Método para eliminar reserva
        public bool EliminarReserva(int id)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EliminarReserva", conexion))
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
                throw new Exception("Error al eliminar reserva: " + ex.Message);
            }
        }
    }
}
