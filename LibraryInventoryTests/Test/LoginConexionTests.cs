using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.LoginConexion;
using Datos.ConexionSQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BibliotecaInventarioPruebas.Test
{
    [TestClass]
    public class LoginConexionTests
    {
        private readonly string connectionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";

        [TestMethod]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            var loginConexion = new LoginConexion();
            string usuario = "System01";
            string password = "sistema2024";

            // Act
            bool result = loginConexion.Login(usuario, password);

            // Debugging Output
            Console.WriteLine($"Login Result: {result}");
            Console.WriteLine($"Usuario: {usuario}");
            Console.WriteLine($"Contraseña: {password}");

            // Assert
            Assert.IsTrue(result, "El resultado del inicio de sesión debería ser verdadero.");
        }

        [TestMethod]
        public void Login_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            var loginConexion = new LoginConexion();
            string usuario = "invalidUser";
            string password = "System01";

            // Act
            bool result = loginConexion.Login(usuario, password);

            // Assert
            Assert.IsFalse(result, "El resultado del inicio de sesión debería ser falso.");
        }
    }
}
