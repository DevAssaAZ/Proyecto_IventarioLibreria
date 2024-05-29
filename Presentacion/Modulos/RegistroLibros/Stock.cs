using Negocio.Libros_cn;
using Negocio.Login_cn;
using Negocio.Stock_cn.StockEntrada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.RegistroLibros
{
    public partial class Stock : Form
    {
        MetodosStockEntrada obj_entrada = new MetodosStockEntrada();
        private int idLibro;
        private string nombrelibro;
        private string idStock;
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


        private void CargarDatosStockEntrada()
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

        private void Stock_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarDatosStockEntrada();
            LlenarComboBox();
        }

        private void dgvLibrosStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvLibrosStock.Columns[e.ColumnIndex].Name == "CANTIDAD")
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            btnNuevaEntrada.Visible = false;
            btnCancelar.Visible = true;
            cbLibros.Visible = true;
            dgvLibrosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSalidaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panelContenedor.Visible = true;
            panelPrincipal.Size = new Size(499, 483);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevaEntrada.Visible = true;
            btnCancelar.Visible = false;
            panelContenedor.Visible = false;
            panelPrincipal.Size = new Size(1020, 632);
            dgvLibrosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalidaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarDatos();
        }


        private void LlenarComboBox()
        {

            try
            {
                MetodosLibros libro_N = new MetodosLibros();
                DataTable tablaLibros = libro_N.MostrarLibros();

                // Configurar el ComboBox
                cbLibros.DisplayMember = "TITULO";  // Columna que se mostrará en el ComboBox
                cbLibros.ValueMember = "ID";  // Columna que representará el valor de cada ítem (asumiendo que tienes una columna 'ID')
                cbLibros.DataSource = tablaLibros;

                // Suscribirse al evento SelectedIndexChanged
                cbLibros.SelectedIndexChanged += new EventHandler(cbLibros_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        private void cbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ComboBox que lanzó el evento
            ComboBox comboBox = (ComboBox)sender;

            // Asegurarse de que hay un elemento seleccionado
            if (comboBox.SelectedItem != null)
            {
                // Obtener el DataRowView del elemento seleccionado
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;

                // Mostrar el título del libro en el TextBox (asumiendo que hay una columna 'TITULO')
                txtNombreLibro.Text = selectedRow["TITULO"].ToString();
                nombrelibro = selectedRow["TITULO"].ToString();


                // Obtener la ID del libro 
                idLibro = Convert.ToInt32(selectedRow["ID"]);


            }
        }

        private void btnRegistrarStockEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                MetodosStockEntrada entrada = new MetodosStockEntrada();
                entrada.IdLibro = idLibro;
                entrada.Cantidad = Convert.ToInt32(txtCantidad.Text);
                // Obtener la fecha seleccionada del DateTimePicker
                DateTime fechaSeleccionada = dtFecha.Value;
                // Convertir la fecha a una cadena con el formato deseado "año-mes-día"
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
                entrada.Fecha = Convert.ToDateTime(fechaFormateada);
                entrada.Proveedor = txtProvedor.Text;
                entrada.Comentarios = rtComentarios.Text;


                if (entrada.InsertarStockEntrada())
                {
                    MessageBox.Show("Stock Actualizado");
                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();
                    CargarDatosStockEntrada();
                    // Limpia los TextBox después de la inserción
                    btnNuevaEntrada.Visible = true;
                    btnCancelar.Visible = false;
                    panelContenedor.Visible = false;
                    panelPrincipal.Size = new Size(1020, 632);
                    dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvLibrosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSalidaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                }
                else
                {
                    MessageBox.Show("Error al registrar el Stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar Stock: " + ex.Message);
            }
        }

        private void dgvEntradaStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {

                

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvEntradaStock.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {


                        if (dgvEntradaStock.Columns[e.ColumnIndex].Name == "Editar")
                        {
                            if (e.RowIndex >= 0)
                            {

                                txtNombreLibro.Text = nombrelibro;
                                txtCantidad.Text = row.Cells["CANTIDAD"].Value?.ToString() ?? string.Empty; 
                                //dtFecha = row.Cells["ANIO"].Value?.ToString() ?? string.Empty; 
                                txtProvedor.Text = row.Cells["PROVEEDOR"].Value?.ToString() ?? string.Empty;
                                rtComentarios.Text = row.Cells["COMENTARIOS"].Value?.ToString() ?? string.Empty; 
                                txtIdStock.Text = row.Cells["ID"].Value.ToString();
                                btnNuevaEntrada.Visible = false;
                                btnCancelar.Visible = true;
                                dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                panelContenedor.Visible = true;
                                panelPrincipal.Size = new Size(437, 463);
                                btnRegistrarStockEntrada.Text = "Actualizar";
                                btnRegistrarStockEntrada.Enabled = false;

                            }

                        }
                        if (dgvEntradaStock.Columns[e.ColumnIndex].Name == "Eliminar")
                        {
                            if (e.RowIndex >= 0)
                            {
                                idStock = row.Cells["ID"].Value.ToString();
                                obj_entrada.Id = Convert.ToInt32(idStock);
                                if (MessageBox.Show("Esta seguro de Eliminar Este Stock? ", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    if (obj_entrada.EliminarStockEntrada())
                                    {
                                        MessageBox.Show("Stock eliminado con éxito");
                                        CargarDatos();
                                        CargarDatosStockEntrada();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Eliminar el Stock");
                                    }

                                }

                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("La fila seleccionada está vacía.");
                    }
                }
                else
                {
                    MessageBox.Show("La fila o la columna seleccionada no son válidas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }
    }
}
