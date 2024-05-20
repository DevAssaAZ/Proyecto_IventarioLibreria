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
            conexionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }
    }
}
