using System;
using System.Collections.Generic;
using System.Data;
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

       
        private int id;
        private string userName;
        private string password;
        private string nombreCompleto;
        private string email;
        private string rol;


        //set y get
        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Email { get => email; set => email = value; }
        public string Rol { get => rol; set => rol = value; }

        public Usuario_N(int id, string nombreCompleto, string email, string userName, string password, string rol)
        {
            this.Id = id;
            this.NombreCompleto = nombreCompleto;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.Rol = rol;
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
                datosusuario.EditarPerfil(Id, UserName, NombreCompleto, Password, Email);
                //Actualizar los datos del login
                LoginUsuario(UserName, Password);
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







        ////Seguridad y permisos
        //public void VerificarRol()
        //{
        //    if (CacheDeInicioDeSesion.Rol == Roles.Administrador)
        //    {

        //    }
        //    if (CacheDeInicioDeSesion.Rol == Roles.Empleado)
        //    {
                
        //    }
        //}


        //Cambio de 21052024anthony
        public bool CrearUsuario(Usuario_N usuario)
        {
            try
            {
                return userdatos.CrearUsuario(usuario.Rol, usuario.UserName, usuario.Password, usuario.NombreCompleto, usuario.Email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario: " + ex.Message);
            }
        }


    }





}
