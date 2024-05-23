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
    public class LoginConexion: ConnectionToSql
    {

        

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



    }

}
