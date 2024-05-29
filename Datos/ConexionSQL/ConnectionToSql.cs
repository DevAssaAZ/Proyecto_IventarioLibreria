
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos.ConexionSQL
{
    //Clase Base
    public abstract class ConnectionToSql
    {
        private readonly string conexionString;
        public ConnectionToSql()
        {
            //conexionString = "server=DESKTOP-4J9EM3K\\SQLEXPRESS; database=PROYECTO_INVENTARIO; user=SA; password=12345678;";
            //conexionString = "server=DESKTOP-H040T0U; database=PROYECTO_INVENTARIO; user=SA; password=evita;";
            //conexionString = "server=DESKTOP-4J9EM3K\\SQLEXPRESS; database=PROYECTO_INVENTARIO; user=SA; password=12345678;";
            conexionString = "server=LAPTOP-49A9F0A5\\SQLEXPRESS; database=PROYECTO_INVENTARIO; user=SA; password=onepiece123;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }


        protected SqlConnection AbrirConexion()
        {
            SqlConnection Conexion = new SqlConnection(conexionString);
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }


        protected SqlConnection CerrarConexion()
        {
            SqlConnection Conexion = new SqlConnection(conexionString);
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
