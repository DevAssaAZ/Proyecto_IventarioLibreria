using Datos.ConexionesDeConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio.Clientes_cn
{
    public class Cliente_N
    {
        ConsultasCliente consultasCliente = new ConsultasCliente();

        public DataTable MostrarClientes()
        {
            return consultasCliente.MostrarClientes();
        }

        public bool InsertarClientes( string nombre, string apellido, string cedula, int edad, string correo)
        {
            return consultasCliente.InsertarCliente( nombre, apellido, cedula, edad, correo);
        }

        public bool EditarClientes(int id, string nombre, string apellido, string cedula, int edad, string correo)
        {
            return consultasCliente.EditarCliente(id, nombre, apellido, cedula, edad, correo);
        }

        public bool EliminarCliente(int id)
        {
            return consultasCliente.EliminarCliente(id);
        }

        // Este método actualiza un cliente en la base de datos
        public bool ActualizarCliente(int id, string nombre, string apellido, string cedula, int edad, string correo)
        {
            try
            {
                return consultasCliente.EditarCliente(id, nombre, apellido, cedula, edad, correo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }
    }
}
