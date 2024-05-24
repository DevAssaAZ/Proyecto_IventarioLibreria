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


        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        //Metodo para mostrar
        public DataTable MostrarUsuarios()
        {
            string query = "SELECT * FROM TB_LOGIN";
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
                throw new Exception("Error al mostrar los usuarios: " + ex.Message);
            }


        }


        //Metodo para insertar
        public bool InsertarUsuario(string rol, string usuario, string contraseña, string nombreCompleto, string email)
        {
            string query = "INSERT INTO TB_LOGIN (ROL, USUARIO, CONTRASEÑA, APELLIDOS_NOMBRES, CORREO_ELECTRONICO) VALUES (@Rol, @Usuario, @Password, @NombreCompleto, @Email)";
            try
            {
                using (var conexion = GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Rol", rol);
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Password", contraseña);
                        command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                        command.Parameters.AddWithValue("@Email", email);

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
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update TB_LOGIN set USUARIO = @user, CONTRASEÑA = @pass, APELLIDOS_NOMBRES = @NombreCompleto, CORREO_ELECTRONICO = @email, ROL = @rol where ID = @id";
                    command.Parameters.AddWithValue("@user", username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    command.Parameters.AddWithValue("@email", mail);
                    command.Parameters.AddWithValue("rol", rol);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    int resultado = command.ExecuteNonQuery();
                    return resultado > 0;
                    

                }
            }
        }



        //Eliminar
        public bool EliminarUsuario(int idUsuario)
        {
            string query = "DELETE TB_LOGIN WHERE ID = "+idUsuario;
            try
            {
                using (var conexion = GetConnection())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = query;
                        command.CommandType = CommandType.Text;
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





    }
}
