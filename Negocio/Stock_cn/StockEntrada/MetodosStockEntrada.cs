using Datos.ConexionesDeConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Stock_cn.StockEntrada
{
    public class MetodosStockEntrada:StockEntrada
    {

        ConsultaStockEntrada consultasEntrada = new ConsultaStockEntrada();

        // Método para mostrar Stock Entrada
        public DataTable MostrarStockEntrada()
        {
            return consultasEntrada.MostrarStockEntrada();
        }

        // Método para insertar Stock Entrada
        public bool InsertarStockEntrada()
        {
            return consultasEntrada.InsertarStockEntrada(IdLibro, Cantidad, Fecha, Proveedor, Comentarios);
        }


        // Método para eliminar Stock Entrada
        public bool EliminarStockEntrada()
        {
            return consultasEntrada.EliminarStockEntrada(Id);
        }


    }
}
