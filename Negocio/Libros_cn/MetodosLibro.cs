using Datos.ConexionesDeConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio.Libros_cn
{
    public class MetodosLibros : Libros_N
    {
        ConsultasLibro consultasLibro = new ConsultasLibro();

        // Método para mostrar libros
        public DataTable MostrarLibros()
        {
            return consultasLibro.MostrarLibros();
        }

        // Método para insertar libro
        public bool InsertarLibros()
        {
            return consultasLibro.InsertarLibro(Titulo, Autor, Anio, Cantidad, Precio);
        }

        // Método para editar libro
        public bool EditarLibros()
        {
            return consultasLibro.EditarLibro(Id, Titulo, Autor, Anio, Cantidad, Precio);
        }

        // Método para eliminar libro
        public bool EliminarLibro(int id)
        {
            return consultasLibro.EliminarLibro(id);
        }

        // Método para actualizar libro
        public bool ActualizarLibro()
        {
            try
            {
                return consultasLibro.EditarLibro(Id, Titulo, Autor, Anio, Cantidad, Precio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar libro: " + ex.Message);
            }
        }
    }
}
