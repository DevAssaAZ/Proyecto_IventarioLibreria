using Datos.ConexionesDeConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio.Clientes_cn
{
    public class MetodosCliente : Clientes_N
    {
  

        ConsultasCliente consultasCliente = new ConsultasCliente();

        //Metodo para mostrar Cliente
        public DataTable MostrarClientes()
        {
            return consultasCliente.MostrarClientes();
        }

        public string ObtenerCedulaPorId(int id)
        {
            return consultasCliente.ObtenerCedulaPorId(id);
        }

        //Metodo para insertar Cliente
        public bool InsertarClientes()
        {
            return consultasCliente.InsertarCliente( Nombre, Apellido, Cedula, Edad, Correo);
        }


        //Metodo para Cliente para editar cliente
        public bool EditarClientes()
        {
            return consultasCliente.EditarCliente(Id, Nombre, Apellido, Cedula, Edad, Correo);
        }


        //Metodo para eliminar cliente
        public bool EliminarCliente()
        {
            return consultasCliente.EliminarCliente(Id);
        }

        // Este método actualiza un cliente en la base de datos
        public bool ActualizarCliente()
        {
            try
            {
                return consultasCliente.EditarCliente(Id, Nombre, Apellido, Cedula, Edad, Correo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

    }
}
