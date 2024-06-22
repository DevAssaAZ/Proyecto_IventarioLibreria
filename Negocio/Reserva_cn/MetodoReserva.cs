using Datos.ConexionesDeConsulta.Reserva;
using Negocio.Usuarios_cn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Reserva_cn
{
    public class MetodosReservas : Reserva_N
    {
        ConsultaReserva consultasReserva = new ConsultaReserva();

        // Método para mostrar reservas
        public DataTable MostrarReservas()
        {
            return consultasReserva.MostrarReservas();
        }

        // Método para insertar reserva
        public bool InsertarReserva()
        {
            return consultasReserva.InsertarReserva(UsuarioId, LibroId, FechaReserva, Estado);
        }

        // Método para editar reserva
        public bool EditarReserva()
        {
            return consultasReserva.EditarReserva(Id, UsuarioId, LibroId, FechaReserva, Estado);
        }

        // Método para eliminar reserva
        public bool EliminarReserva()
        {
            return consultasReserva.EliminarReserva(Id);
        }
    }
}
