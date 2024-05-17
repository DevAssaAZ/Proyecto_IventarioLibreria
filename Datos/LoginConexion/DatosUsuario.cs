using Datos.ConexionSQL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LoginConexion
{
    public class DatosUsuario: ConnectionToSql
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
                        return true;
                    }
                    else
                    
                        return false;
                    
                }
            }
        }
    }
}
