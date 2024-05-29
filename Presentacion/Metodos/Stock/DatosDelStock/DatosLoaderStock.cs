using Negocio.Libros_cn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion.Metodos.Stock.DatosDeTablas
{
    public static class DatosLoaderStock
    {
        //Metodo para ver la tabla de libros con su stock
        public static void CargarDatosStock(DataGridView dgvLibrosStock)
        {
            MetodosLibros libro_N = new MetodosLibros();
            DataTable dt = libro_N.MostrarLibros();
            dgvLibrosStock.DataSource = dt;
            dgvLibrosStock.ClearSelection();
            dgvLibrosStock.AutoGenerateColumns = false;

            dgvLibrosStock.Columns["CANTIDAD"].HeaderText = "STOCK";
            dgvLibrosStock.Columns["ANIO"].HeaderText = "AÑO";

            dgvLibrosStock.Columns["ID"].DisplayIndex = 0;
            dgvLibrosStock.Columns["TITULO"].DisplayIndex = 1;
            dgvLibrosStock.Columns["AUTOR"].DisplayIndex = 2;
            dgvLibrosStock.Columns["ANIO"].DisplayIndex = 3;
            dgvLibrosStock.Columns["PRECIO"].DisplayIndex = 4;
            dgvLibrosStock.Columns["CANTIDAD"].DisplayIndex = 5;
        }
    }
}
