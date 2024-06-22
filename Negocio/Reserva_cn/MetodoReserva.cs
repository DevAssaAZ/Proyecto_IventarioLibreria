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
    public class MetodoReserva : Reserva_N
    {
        ConsultaReserva consultasReserva = new ConsultaReserva();

        // Método para mostrar reservas
        public DataTable MostrarReservas()
        {
            try
            {
                return consultasReserva.MostrarReservas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar reservas: " + ex.Message);
            }
        }

        // Método para insertar reserva
        public bool InsertarReserva(int usuarioId, int clienteId, int libroId, int cantidad, decimal precioTotal, DateTime fechaReserva, string estado)
        {
            try
            {
                return consultasReserva.InsertarReserva(usuarioId, clienteId, libroId, cantidad, precioTotal, fechaReserva, estado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar reserva: " + ex.Message);
            }
        }


        // Método para editar reserva
        public bool EditarReserva(int id, int usuarioId, int clienteId, int libroId, int cantidad, decimal precioTotal, DateTime fechaReserva, string estado)
        {
            try
            {
                return consultasReserva.EditarReserva(id, usuarioId, clienteId, libroId, cantidad, precioTotal, fechaReserva, estado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar reserva: " + ex.Message);
            }
        }

        // Método para eliminar reserva
        public bool EliminarReserva(int id)
        {
            try
            {
                return consultasReserva.EliminarReserva(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar reserva: " + ex.Message);
            }
        }


    }
}
