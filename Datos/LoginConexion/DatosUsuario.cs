using Datos.ConexionSQL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soporte.Cache;
using System.Data;

namespace Datos.LoginConexion
{
    public class DatosUsuario: ConnectionToSql
    {

        //Metodo para editar perfil
        public void EditarPerfil(int id, string username, string nombreCompleto, string password, string mail)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update TB_LOGIN set USUARIO = @user, CONTRASEÑA = @pass, APELLIDOS_NOMBRES = @NombreCompleto, CORREO_ELECTRONICO = @email where ID = @id";
                    command.Parameters.AddWithValue("@user",username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    command.Parameters.AddWithValue("@email", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }




        public bool Login(string usuario, string pass)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from TB_LOGIN where USUARIO = @user and CONTRASEÑA = @pass";
                    command.Parameters.AddWithValue("@user", usuario);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    //Si la consulta existe o no existe
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheDeInicioDeSesion.IdUser = reader.GetInt32(0);
                            CacheDeInicioDeSesion.UserName = reader.GetString(1);
                            CacheDeInicioDeSesion.Password = reader.GetString(2);
                            CacheDeInicioDeSesion.NombreCompleto = reader.GetString(3);
                            CacheDeInicioDeSesion.Email = reader.GetString(4);
                            CacheDeInicioDeSesion.Rol = reader.GetString(5);

                        }
                        return true;
                    }
                    else
                    
                        return false;
                    
                }
            }
        }

        //
        public string RecuperarPassword(string userRequeresting)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from TB_LOGIN where APELLIDOS_NOMBRES = @user or CORREO_ELECTRONICO =@mail";
                    command.Parameters.AddWithValue("@user", userRequeresting);
                    command.Parameters.AddWithValue("@mail", userRequeresting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3);
                        string userMail = reader.GetString(4);
                        string accountPassword = reader.GetString(2);

                        var mailService = new EmailServices.SystemSoportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: SOLICITUD DE RECUPERACION DE CONTRASEÑA",
                            body: "Hola, " + userName + "\nTu peticion de restablecer tu contraseña fue aceptada.\n" +
                            "Tu contraseña es: " + accountPassword + "\nCambia tu contraseña una vez que ingreses al sistema.",
                            recipientMail: new List<string> {userMail}

                            );
                        return "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                            "Por favor, revisa tu correo " + userMail + "\nCambia tu contraseña una vez que ingreses al sistema.";
                    }
                    else
                        return "Lo sentimos, no tiene una cuenta sociada a este nombre de usuario o correo electronico";

                }
            }
        }





        //Administrar permisos segun el rol
        public void VerificarRol()
        {
            if(CacheDeInicioDeSesion.Rol == Roles.Administrador)
            {

            }
            if(CacheDeInicioDeSesion.Rol == Roles.Empleado)
            {

            }
        }





        

        public bool CrearUsuario(string rol, string usuario, string contraseña, string nombreCompleto, string email)
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
                        int result = command.ExecuteNonQuery();
                        return result > 0;
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
