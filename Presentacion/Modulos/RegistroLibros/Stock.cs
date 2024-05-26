using Negocio.Libros_cn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.RegistroLibros
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }


        private void CargarDatos()
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

        private void Stock_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvLibrosStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvLibrosStock.Columns[e.ColumnIndex].Name == "CANTIDAD")
            {
                if(Convert.ToInt32(e.Value) <=100000)
                {
                    e.CellStyle.BackColor = Color.LimeGreen;


                    if (Convert.ToInt32(e.Value) <= 10)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                }





            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
