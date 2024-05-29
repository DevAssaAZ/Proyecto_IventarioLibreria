using Negocio.Libros_cn;
using Negocio.Stock_cn.StockEntrada;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.Entrada
{
    public static class DatosLoaderStockEntrada
    {
        //Metodo para mostrar la tabla de entradas de stock
        public static void CargarDatosStockEntrada(DataGridView dgvEntradaStock)
        {
            MetodosStockEntrada entrada = new MetodosStockEntrada();
            DataTable dt = entrada.MostrarStockEntrada();
            dgvEntradaStock.DataSource = dt;
            dgvEntradaStock.ClearSelection();
            dgvEntradaStock.AutoGenerateColumns = false;
            dgvEntradaStock.Columns["ID"].DisplayIndex = 0;
            dgvEntradaStock.Columns["ID_LIBRO"].DisplayIndex = 1;
            dgvEntradaStock.Columns["CANTIDAD"].DisplayIndex = 2;
            dgvEntradaStock.Columns["FECHA"].DisplayIndex = 3;
            dgvEntradaStock.Columns["PROVEEDOR"].DisplayIndex = 4;
            dgvEntradaStock.Columns["COMENTARIOS"].DisplayIndex = 5;
            dgvEntradaStock.Columns["Editar"].DisplayIndex = 6;
            dgvEntradaStock.Columns["Eliminar"].DisplayIndex = 7;
        }
    }
}
