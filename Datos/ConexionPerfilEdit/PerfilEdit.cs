using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.ConexionSQL;
using System.Data.SqlClient;
using System.Data;

namespace Datos.ConexionPerfilEdit
{
    public class PerfilEdit: ConnectionToSql
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
                    command.Parameters.AddWithValue("@user", username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    command.Parameters.AddWithValue("@email", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }




    }
}
