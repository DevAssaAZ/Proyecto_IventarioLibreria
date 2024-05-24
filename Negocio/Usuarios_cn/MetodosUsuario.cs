using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.CrudConexiones;
using Negocio.Login_cn;

namespace Negocio.Usuarios_cn
{
    public class MetodosUsuario : Usuario_N
    {


        private ConsultasUsuario obj_usuario = new ConsultasUsuario();


        //Metodo para mostrar en tabla
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = obj_usuario.MostrarUsuarios();
            return tabla;
        }

        
        //Metodo Insertar Usuarios
        public bool InsertarUsuario()
        {
           
            try
            {
                return obj_usuario.InsertarUsuario(Rol, UserName, Password, NombreCompleto, Email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Insertar usuario: " + ex.Message);
            }
        }


        //Metodo Editar Usuarios
        public bool EditarUsuario()
        {

            try
            {
                return obj_usuario.EditarUsuario(Convert.ToInt32(Id), UserName, Password, NombreCompleto, Email, Rol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
            
        }

        //Metodo Eliminar Usuario
        public bool EliminarUsuario()
        {

            try
            {
                return obj_usuario.EliminarUsuario(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar: " + ex.Message);
            }

        }


    }
}
