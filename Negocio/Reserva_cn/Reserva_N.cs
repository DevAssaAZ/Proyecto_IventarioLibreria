using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Reserva_cn
{
    public abstract class Reserva_N
    {
        protected int id;
        protected int usuarioId;
        protected int clienteId;
        protected int libroId;
        protected int cantidad;
        protected decimal precioTotal;
        protected DateTime fechaReserva;
        protected string estado;

        public Reserva_N(int id, int usuarioId, int clienteId, int libroId, int cantidad, decimal precioTotal, DateTime fechaReserva, string estado)
        {
            this.Id = id;
            this.UsuarioId = usuarioId;
            this.ClienteId = clienteId;
            this.LibroId = libroId;
            this.Cantidad = cantidad;
            this.PrecioTotal = precioTotal;
            this.FechaReserva = fechaReserva;
            this.Estado = estado;
        }

        public Reserva_N(int usuarioId, int clienteId, int libroId, int cantidad, decimal precioTotal, DateTime fechaReserva, string estado)
        {
            this.UsuarioId = usuarioId;
            this.ClienteId = clienteId;
            this.LibroId = libroId;
            this.Cantidad = cantidad;
            this.PrecioTotal = precioTotal;
            this.FechaReserva = fechaReserva;
            this.Estado = estado;
        }

        public Reserva_N(int id)
        {
            this.Id = id;
        }

        public Reserva_N()
        {
            // Constructor vacío
        }

        // Propiedades con getters y setters
        public int Id { get => id; set => id = value; }
        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public int LibroId { get => libroId; set => libroId = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
