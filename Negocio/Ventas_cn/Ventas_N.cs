using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ventas_cn
{
    public abstract class Ventas_N
    {
        protected int id;
        protected int libroId;
        protected int usuarioId;
        protected int clienteId;
        protected int cantidad;
        protected decimal precioTotal;
        protected DateTime fecha;

        public Ventas_N(int id, int libroId, int usuarioId, int clienteId, int cantidad, decimal precioTotal, DateTime fecha)
        {
            this.Id = id;
            this.LibroId = libroId;
            this.UsuarioId = usuarioId;
            this.ClienteId = clienteId;
            this.Cantidad = cantidad;
            this.PrecioTotal = precioTotal;
            this.Fecha = fecha;
        }

        public Ventas_N(int libroId, int usuarioId, int clienteId, int cantidad, decimal precioTotal, DateTime fecha)
        {
            this.LibroId = libroId;
            this.UsuarioId = usuarioId;
            this.ClienteId = clienteId;
            this.Cantidad = cantidad;
            this.PrecioTotal = precioTotal;
            this.Fecha = fecha;
        }

        public Ventas_N(int id)
        {
            this.Id = id;
        }

        public Ventas_N()
        {
            // Constructor vacío
        }

        // Propiedades con getters y setters
        public int Id { get => id; set => id = value; }
        public int LibroId { get => libroId; set => libroId = value; }
        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
