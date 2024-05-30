using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Usuarios_cn
{
    //CLASE BASE
     public abstract class Usuario_N
    {
        protected int id;
        protected string userName;
        protected string password;
        protected string nombreCompleto;
        protected string email;
        protected string rol;



        public Usuario_N(int id, string nombreCompleto, string email, string userName, string password, string rol)
        {
            this.Id = id;
            this.NombreCompleto = nombreCompleto;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.Rol = rol;
        }

        //Constructores
        public Usuario_N(string nombreCompleto, string email, string userName, string password, string rol)
        {

            this.NombreCompleto = nombreCompleto;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.Rol = rol;
        }
  

        public Usuario_N(int id)
        {
            this.Id = id;
        }

        public Usuario_N(string userName)
        {
            this.UserName = userName;
        }


        public Usuario_N()
        {
            //Constructor vacio
        }



        //set y get
        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Email { get => email; set => email = value; }
        public string Rol { get => rol; set => rol = value; }





    }
}
