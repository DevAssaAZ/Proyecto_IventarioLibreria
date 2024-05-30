using Datos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos.CrudConexiones
{
    public class ConsultasUsuario : ConnectionToSql
    {

        //Metodo para mostrar
        public DataTable MostrarUsuarios()
        {
            string storedProcedure = "MostrarUsuarios";
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
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los usuarios: " + ex.Message);
            }
        }


        //Metodo para insertar
        public bool InsertarUsuario(string rol, string usuario, string contraseña, string nombreCompleto, string email)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("InsertarUsuario", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                        command.Parameters.AddWithValue("@email", email);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario: " + ex.Message);
            }
        }


        //Editar
        public bool EditarUsuario(int id, string username, string password, string nombreCompleto, string mail, string rol)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EditarUsuario", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@usuario", username);
                        command.Parameters.AddWithValue("@contraseña", password);
                        command.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                        command.Parameters.AddWithValue("@email", mail);
                        command.Parameters.AddWithValue("@rol", rol);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar usuario: " + ex.Message);
            }
        }



        //Eliminar
        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EliminarUsuario", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", idUsuario);

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }





    }
}
