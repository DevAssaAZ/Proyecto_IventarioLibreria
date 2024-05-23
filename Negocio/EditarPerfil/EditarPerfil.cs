using Datos.ConexionPerfilEdit;
using Negocio.Login_cn;
using Negocio.Usuarios_cn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EditarPerfil
{
    public class EditarPerfil: Usuario_N
    {

        public EditarPerfil(int id, string nombreCompleto, string email, string userName, string password, string rol)
        {
            this.Id = id;
            this.NombreCompleto = nombreCompleto;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.Rol = rol;
        }

        public EditarPerfil()
        {
            //Constructor vacio
        }

        public string EditarPerfilUsuario()
        {

            PerfilEdit edit = new PerfilEdit();
            MetodosLogin login = new MetodosLogin();

            try
            {
                edit.EditarPerfil(Id, UserName, NombreCompleto, Password, Email);
                //Actualizar los datos del login
                login.LoginUsuario(UserName, Password);
                return "TU PERFIL SE ACTUALIZO CORRECTAMENTE";
            }
            catch (Exception ex)
            {

                return "NOMBRE DE USUARIO YA ESTA EN USO, INTENTE CON OTRO";
            }



        }



    }
}
