using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.ConexionSQL
{
    //Clase Base
    public abstract class ConnectionToSql
    {
        private readonly string conexionString;
        public ConnectionToSql()
        {
            conexionString = "Server = DESKTOP-4J9EM3K\\SQLEXPRESS; DataBase = PROYECTO_INVENTARIO; integrated security = true"; hola uwu

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }
    }
}
