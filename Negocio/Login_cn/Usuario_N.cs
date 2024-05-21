using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.LoginConexion;
using Soporte.Cache;

namespace Negocio.Login_cn
{
    public class Usuario_N
    {

        DatosUsuario userdatos = new DatosUsuario();

        //Atributos
        private int id;
        private string userName;
        private string password;
        private string nombreCompleto;
        private string email;
        private string rol;

        public Usuario_N(int id, string userName, string password, string nombreCompleto, string email, string rol)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.nombreCompleto = nombreCompleto;
            this.email = email;
            this.rol = rol;
        }

        public Usuario_N()
        {
            //Constructor vacio
        }


        public string EditarPerfilUsuario()
        {

            DatosUsuario datosusuario = new DatosUsuario();

            try
            {
                datosusuario.EditarPerfil(id, userName, nombreCompleto, password, email);
                //Actualizar los datos del login
                LoginUsuario(userName, password);
                return "TU PERFIL SE ACTUALIZO CORRECTAMENTE";
            }
            catch (Exception ex)
            {

                return "NOMBRE DE USUARIO YA ESTA EN USO, INTENTE CON OTRO";
            }

            

        }





        public bool LoginUsuario(string usuario, string pass)
        {
            return userdatos.Login(usuario, pass);
        }

        //
        public string RecuperarPassword(string userRequeresting)
        {
            DatosUsuario datosUsuario = new DatosUsuario();
            return datosUsuario.RecuperarPassword(userRequeresting);
        }







        //Seguridad y permisos
        public void VerificarRol()
        {
            if (CacheDeInicioDeSesion.Rol == Roles.Administrador)
            {

            }
            if (CacheDeInicioDeSesion.Rol == Roles.Empleado)
            {
                
            }
        }

    }


   
    

}
