using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.DatosDelStock
{
    public static class CondicionesParaCantidad
    {
        //Metodo para dar un formato de color a la celdas de cantidad dependiendo de la cantidad que halla en stock
        public static void FormatearCeldaCantidad(DataGridViewCellFormattingEventArgs e, DataGridView dgvLibrosStock)
        {
            if (dgvLibrosStock.Columns[e.ColumnIndex].Name == "CANTIDAD")
            {
                if (Convert.ToInt32(e.Value) <= 100000)
                {
                    e.CellStyle.BackColor = Color.LimeGreen;


                    if (Convert.ToInt32(e.Value) <= 10)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
