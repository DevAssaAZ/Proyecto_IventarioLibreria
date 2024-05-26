using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Libros_cn
{
    public abstract class Libros_N
    {
        protected int id;
        protected string titulo;
        protected string autor;
        protected int anio;
        protected int cantidad;
        protected decimal precio;

        public Libros_N(int id, string titulo, string autor, int anio, int cantidad, decimal precio)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Anio = anio;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public Libros_N(string titulo, string autor, int anio, int cantidad, decimal precio)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Anio = anio;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public Libros_N(int id)
        {
            this.Id = id;
        }

        public Libros_N()
        {
            // Constructor vacío
        }

        // Propiedades con getters y setters
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
