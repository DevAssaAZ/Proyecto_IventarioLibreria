using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.LoginConexion;
using Negocio.Usuarios_cn;
using Soporte.Cache;

namespace Negocio.Login_cn
{
    public class MetodosLogin: Usuario_N
    {

        LoginConexion userdatos = new LoginConexion();


        public MetodosLogin(int id, string nombreCompleto, string email, string userName, string password, string rol)
        {
            this.Id = id;
            this.NombreCompleto = nombreCompleto;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.Rol = rol;
        }

        public MetodosLogin()
        {
            //Constructor vacio
        }


        

        public bool LoginUsuario(string usuario, string pass)
        {
            return userdatos.Login(usuario, pass);
        }

        //
        public string RecuperarPassword(string userRequeresting)
        {
            LoginConexion datosUsuario = new LoginConexion();
            return datosUsuario.RecuperarPassword(userRequeresting);
        }

    
       


    }





}
