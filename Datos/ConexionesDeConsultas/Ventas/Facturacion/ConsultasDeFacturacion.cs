using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos.ConexionSQL;

namespace Datos.ConexionesDeConsultas.Ventas.Facturacion
{
    public class ConsultasDeFacturacion : ConnectionToSql
    {
        //Metodo para traer la informacion del cliente
        public DataTable ObtenerInformacionVenta(int ventaId)
        {
            using (var conexion = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerInformacionVenta", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaID", ventaId);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
            }
        }

        //Metodo para mostrar las facturaciones
        public DataTable MostrarFacturaciones()
        {
            using (var conexion = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarFacturaciones", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
