using Negocio.Clientes_cn;
using Negocio.Libros_cn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroLibros
{
    public static class DatosLoaderLibros
    {
        //Metodo para cargar datos en el formulario de Libros
        public static void CargarDatosLibros(DataGridView dgvLibro)
        {
            MetodosLibros libro_N = new MetodosLibros();
            DataTable dt = libro_N.MostrarLibros();
            dgvLibro.DataSource = dt;
            dgvLibro.ClearSelection();
            dgvLibro.AutoGenerateColumns = false;
            dgvLibro.Columns["ID"].DisplayIndex = 0;
            dgvLibro.Columns["TITULO"].DisplayIndex = 1;
            dgvLibro.Columns["AUTOR"].DisplayIndex = 2;
            dgvLibro.Columns["ANIO"].DisplayIndex = 3;
            dgvLibro.Columns["CANTIDAD"].DisplayIndex = 4;
            dgvLibro.Columns["PRECIO"].DisplayIndex = 5;
            dgvLibro.Columns["Ver"].DisplayIndex = 6;
            dgvLibro.Columns["Editar"].DisplayIndex = 7;
            dgvLibro.Columns["Eliminar"].DisplayIndex = 8;
        }

    }
}
