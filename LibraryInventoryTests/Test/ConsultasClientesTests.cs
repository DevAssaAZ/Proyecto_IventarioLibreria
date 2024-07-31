using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos.ConexionesDeConsultas;
using Negocio.Clientes_cn;
using System.Data;

namespace BibliotecaInventarioPruebas.Test
{
    [TestClass]
    public class MetodosClientesTest
    {
        private readonly string connectionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";

        [TestMethod]
        public void InsertarCliente_ValidData_ReturnsTrue()
        {
            // Arrange
            var metodoCliente = new MetodosCliente();
            metodoCliente.Nombre = "ClientePrueba";
            metodoCliente.Apellido = "ApellidoPrueba";
            metodoCliente.Cedula = "1239709070";
            metodoCliente.Edad = 30;
            metodoCliente.Correo = "cliente@prueba.com";

            // Act
            bool result = metodoCliente.InsertarClientes();

            // Debugging Output
            Console.WriteLine($"Insertar Result: {result}");
            Console.WriteLine($"Nombre: {metodoCliente.Nombre}");
            Console.WriteLine($"Apellido: {metodoCliente.Apellido}");
            Console.WriteLine($"Cedula: {metodoCliente.Cedula}");
            Console.WriteLine($"Edad: {metodoCliente.Edad}");
            Console.WriteLine($"Correo: {metodoCliente.Correo}");

            // Assert
            Assert.IsTrue(result, "El resultado de insertar el cliente debería ser verdadero.");
        }

        [TestMethod]
        public void MostrarClientes_ReturnsDataTable()
        {
            // Arrange
            var metodoCliente = new MetodosCliente();

            // Act
            DataTable result = metodoCliente.MostrarClientes();

            // Debugging Output
            Console.WriteLine($"MostrarClientes Result: {result.Rows.Count} rows returned.");

            // Assert
            Assert.IsNotNull(result, "El resultado de mostrar los clientes no debería ser nulo.");
            Assert.IsTrue(result.Rows.Count > 0, "Debería haber al menos un cliente en la base de datos.");
        }

        [TestMethod]
        public void EditarCliente_ValidData_ReturnsTrue()
        {
            // Arrange
            var metodoCliente = new MetodosCliente
            {
                Id = 7, // Asegúrate de que este ID exista en la base de datos y sea un cliente válido
                Nombre = "Nombre Editado",
                Apellido = "Apellido Editado",
                Cedula = "1234567020",
                Edad = 30,
                Correo = "correoeditado@example.com"
            };

            // Act
            bool result = metodoCliente.EditarClientes();

            // Debugging Output
            Console.WriteLine($"Editar Result: {result}");
            Console.WriteLine($"ID: {metodoCliente.Id}");
            Console.WriteLine($"Nombre: {metodoCliente.Nombre}");
            Console.WriteLine($"Apellido: {metodoCliente.Apellido}");
            Console.WriteLine($"Cedula: {metodoCliente.Cedula}");
            Console.WriteLine($"Edad: {metodoCliente.Edad}");
            Console.WriteLine($"Correo: {metodoCliente.Correo}");

            // Assert
            Assert.IsTrue(result, "El resultado de editar el cliente debería ser verdadero.");
        }

        [TestMethod]
        public void EliminarCliente_ValidId_ReturnsTrue()
        {
            // Arrange
            var metodoCliente = new MetodosCliente
            {
                Id = 23 // Asegúrate de que este ID existe en la base de datos
            };

            // Act
            bool result = metodoCliente.EliminarCliente();

            // Debugging Output
            Console.WriteLine($"Eliminar Result: {result}");
            Console.WriteLine($"ID: {metodoCliente.Id}");

            // Assert
            Assert.IsTrue(result, "El resultado de eliminar el cliente debería ser verdadero.");
        }
    }
}
