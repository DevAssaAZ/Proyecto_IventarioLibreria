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
            conexionString = "server=DESKTOP-4J9EM3K\\SQLEXPRESS; database=PROYECTO_INVENTARIO; user=SA; password=12345678;";
            //conexionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";
            //conexionString = "server=DESKTOP-4J9EM3K\\SQLEXPRESS; database=PROYECTO_INVENTARIO; user=SA; password=12345678;";

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }
    }
}
