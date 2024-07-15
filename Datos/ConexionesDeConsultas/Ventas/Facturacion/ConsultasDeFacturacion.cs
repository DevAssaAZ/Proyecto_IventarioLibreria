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

        //Metodo para insertar las facturas
        public void InsertarFacturacion(string numFactura, string cedula, string cliente, string libro, int cantidad, decimal precioCantidad, string detalles, decimal descuento, decimal precioTotal, string metodoDePago)
        {
            using (var conexion = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("InsertarFacturacion", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NumFactura", numFactura);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Cliente", cliente);
                    cmd.Parameters.AddWithValue("@Libro", libro);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@PrecioCantidad", precioCantidad);
                    cmd.Parameters.AddWithValue("@Detalles", detalles);
                    cmd.Parameters.AddWithValue("@Descuento", descuento);
                    cmd.Parameters.AddWithValue("@PrecioTotal", precioTotal);
                    cmd.Parameters.AddWithValue("@MetodoDePago", metodoDePago);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para Eliminar Facturas
        public bool EliminarFacturacion(int id)
        {
            using (var conexion = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("EliminarFacturacion", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);

                    conexion.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
