using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clientes_cn
{
    public abstract class Clientes_N
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string cedula;
        protected int edad;
        protected string correo;

        public Clientes_N(int id, string nombre, string apellido, string cedula, int edad, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Edad = edad;
            this.Correo = correo;
        }

        public Clientes_N(string nombre, string apellido, string cedula, int edad, string correo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Edad = edad;
            this.Correo = correo;
        }

        public Clientes_N(int id)
        {
            this.Id = id;
        }

        public Clientes_N()
        {
            //Constructor vacio
        }

        //set y get
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }





    }
}
