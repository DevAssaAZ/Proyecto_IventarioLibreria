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

        //Atributos         //Cambio de 21052024anthony solo a publico para que funcione
        public int id;
        public string userName;
        public string password;
        public string nombreCompleto;
        public string email;
        public string rol;

        public Usuario_N(int id, string nombreCompleto, string email, string userName, string password, string rol)
        {
            this.id = id;
            this.nombreCompleto = nombreCompleto;
            this.email = email;
            this.userName = userName;
            this.password = password;
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

        //Cambio de 21052024anthony
        public bool CrearUsuario(Usuario_N usuario)
        {
            try
            {
                return userdatos.CrearUsuario(usuario.rol, usuario.nombreCompleto, usuario.email, usuario.userName, usuario.password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario: " + ex.Message);
            }
        }



    }





}
