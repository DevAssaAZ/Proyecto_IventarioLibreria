using Datos.ConexionesDeConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInventarioPruebas.Test
{
    [TestClass]
    public class ConsultasVentasTest
    {
        private readonly string connectionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";
        private ConsultasVenta _consultasVenta;

        [TestInitialize]
        public void Setup()
        {
            _consultasVenta = new ConsultasVenta();
        }

        [TestMethod]
        public void MostrarVentas_ReturnsDataTable()
        {
            // Act
            DataTable result = _consultasVenta.MostrarVentas();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0, "No se devolvieron filas de MostrarVentas.");
        }

        [TestMethod]
        public void InsertarVenta_ValidData_ReturnsTrue()
        {
            // Arrange
            int usuarioId = 1;
            int clienteId = 1;
            int libroId = 1;
            int cantidad = 1;
            decimal precioTotal = 1000m;

            // Act
            bool result = _consultasVenta.InsertarVenta(usuarioId, clienteId, libroId, cantidad, precioTotal);

            // Assert
            Assert.IsTrue(result, "InsertarVenta no devolvió verdadero para datos válidos.");
        }

        [TestMethod]
        public void EditarVenta_ValidData_ReturnsTrue()
        {
            // Arrange
            int ventaId = 5;//8
            int usuarioId = 1;
            int clienteId = 1;
            int libroId = 1;
            int cantidad = 1;
            decimal precioTotal = 500m;

            // Act
            bool result = _consultasVenta.EditarVenta(ventaId, usuarioId, clienteId, libroId, cantidad, precioTotal);

            // Assert
            Assert.IsTrue(result, "EditarVenta no devolvió verdadero para datos válidos.");
        }

        [TestMethod]
        public void EliminarVenta_ValidId_ReturnsTrue()
        {
            // Arrange
            int ventaId = 20;//18

            // Act
            bool result = _consultasVenta.EliminarVenta(ventaId);

            // Assert
            Assert.IsTrue(result, "EliminarVenta no devolvió verdadero para una identificación válida.");
        }
    }
}
