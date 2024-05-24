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



        public MetodosUsuario(string nombreCompleto, string email, string userName, string password, string rol)
        {
  
            this.NombreCompleto = nombreCompleto;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.Rol = rol;
        }
        public MetodosUsuario()
        {

        }









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
                return obj_usuario.EditarUsuario(Convert.ToInt32(id), UserName, Password, NombreCompleto, Email, Rol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
            
        }




    }
}
