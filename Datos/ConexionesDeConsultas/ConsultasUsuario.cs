using Datos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos.CrudConexiones
{
    public class ConsultasUsuario : ConnectionToSql
    {


        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        //Metodo para mostrar
        public DataTable MostrarUsuarios()
        {
            string query = "SELECT * FROM TB_LOGIN";
            try
            {
                command.Connection = AbrirConexion();
                command.CommandText = query;
                leer = command.ExecuteReader();
                tabla.Load(leer);
                CerrarConexion();
                return tabla;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los usuarios: " + ex.Message);
            }


        }
    }
}
