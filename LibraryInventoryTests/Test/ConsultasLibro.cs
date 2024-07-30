using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos.LoginConexion;
using Datos.ConexionesDeConsultas;
using System.Data;


namespace BibliotecaInventarioPruebas.Test
{
    [TestClass]
    public class ConsultasLibroTests
    {
        private readonly string connectionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";

        [TestMethod]
        public void InsertarLibro_ValidData_ReturnsTrue()
        {
            // Arrange
            var consultasLibro = new ConsultasLibro();
            string titulo = "Nuevo Libro " + Guid.NewGuid().ToString(); // Título único
            string autor = "Autor Prueba";
            int anio = 2024;
            int cantidad = 10;
            decimal precio = 29.99m;

            // Act
            bool result = consultasLibro.InsertarLibro(titulo, autor, anio, cantidad, precio);

            // Debugging Output
            Console.WriteLine($"Insertar Result: {result}");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Año: {anio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio: {precio}");

            // Assert
            Assert.IsTrue(result, "El resultado de insertar el libro debería ser verdadero.");
        }

        [TestMethod]
        public void MostrarLibros_ReturnsDataTable()
        {
            // Arrange
            var consultasLibro = new ConsultasLibro();

            // Act
            DataTable result = consultasLibro.MostrarLibros();

            // Debugging Output
            Console.WriteLine($"MostrarLibros Result: {result.Rows.Count} rows returned.");

            // Assert
            Assert.IsNotNull(result, "El resultado de mostrar los libros no debería ser nulo.");
            Assert.IsTrue(result.Rows.Count > 0, "Debería haber al menos un libro en la base de datos.");
        }

        [TestMethod]
        public void EditarLibro_ValidData_ReturnsTrue()
        {
            // Arrange
            var consultasLibro = new ConsultasLibro();
            int id = 25; // Asegúrate de que este ID existe en la base de datos
            string titulo = "Libroeditadoporpruebas";
            string autor = "Autor Editado";
            int anio = 2025;
            int cantidad = 5;
            decimal precio = 29.99m;

            // Act
            bool result = consultasLibro.EditarLibro(id, titulo, autor, anio, cantidad, precio);

            // Debugging Output
            Console.WriteLine($"Editar Result: {result}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Anio: {anio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio: {precio}");

            // Assert
            Assert.IsTrue(result, "El resultado de editar el libro debería ser verdadero.");
        }

        [TestMethod]
        public void EliminarLibro_ValidId_ReturnsTrue()
        {
            // Arrange
            var consultasLibro = new ConsultasLibro();
            int id = 32; // Asegúrate de que este ID existe en la base de datos

            // Act
            bool result = consultasLibro.EliminarLibro(id);

            // Debugging Output
            Console.WriteLine($"Eliminar Result: {result}");
            Console.WriteLine($"ID: {id}");

            // Assert
            Assert.IsTrue(result, "El resultado de eliminar el libro debería ser verdadero.");
        }

    }
}
