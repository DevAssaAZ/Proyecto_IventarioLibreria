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
    }
}
