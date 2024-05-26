using Negocio.Clientes_cn;
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
    public partial class RegistroLibro : Form
    {
        MetodosLibros obj_libro = new MetodosLibros();
        private string idLibro = null;

        public RegistroLibro()
        {
            InitializeComponent();
        }


        private void CargarDatos()
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

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {

            MetodosLibros libro_N = new MetodosLibros();

            if (btnRegistrarLibro.Text == "Registrar")
            {
                try
                {

                    
                    libro_N.Titulo = txtTitulo.Text;
                    libro_N.Autor = txtAutor.Text;
                    libro_N.Anio = Convert.ToInt32(txtAnio.Text);
                    libro_N.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    libro_N.Precio = Convert.ToDecimal(txtPrecio.Text);




                    if (libro_N.InsertarLibros())
                    {
                        MessageBox.Show("Registrado con éxito");
                        // Vuelve a cargar los datos en el DataGridView
                        CargarDatos();
                        // Limpia los TextBox después de la inserción
                        LimpiarCampos();
                        btNuevo.Visible = true;
                        btnCancelar.Visible = false;
                        panelContenedor.Visible = false;
                        panelPrincipal.Size = new Size(1020, 632);
                        dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el libro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al comprobar Libro: " + ex.Message);
                }
            }
            if (btnRegistrarLibro.Text == "Actualizar")
            {
                


                try

                {
                    libro_N.Id = Convert.ToInt32(idLibro);
                    libro_N.Titulo = txtTitulo.Text;
                    libro_N.Autor = txtAutor.Text;
                    libro_N.Anio = Convert.ToInt32(txtAnio.Text);
                    libro_N.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    libro_N.Precio = Convert.ToDecimal(txtPrecio.Text);


                    // Lógica para actualizar los datos en la base de datos
                    bool resultado = libro_N.EditarLibros();
                    if (resultado)
                    {
                        MessageBox.Show("Datos actualizados con éxito.");
                        // Vuelve a cargar los datos en el DataGridView
                        CargarDatos();
                        // Limpia los TextBox después de la inserción
                        LimpiarCampos();
                        btNuevo.Visible = true;
                        btnCancelar.Visible = false;
                        panelContenedor.Visible = false;
                        panelPrincipal.Size = new Size(1020, 632);
                        dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                    else
                    {
                        MessageBox.Show(" Error al actualizar el libro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                btnRegistrarLibro.Text = "Registrar";

            }

        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();;
        }


       

        private void RegistroLibro_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarCampos();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            btNuevo.Visible = false;
            btnCancelar.Visible = true;
            dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            panelContenedor.Visible = true;
            LimpiarCampos();
            panelPrincipal.Size = new Size(517, 478);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLibro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvLibro.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {


                        if (dgvLibro.Columns[e.ColumnIndex].Name == "EDITAR")
                        {
                            if (e.RowIndex >= 0)
                            {

                                txtTitulo.Text = row.Cells["TITULO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Titulo"
                                txtAutor.Text = row.Cells["AUTOR"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Autor"
                                txtAnio.Text = row.Cells["ANIO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Anio"
                                txtCantidad.Text = row.Cells["CANTIDAD"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Cantidad"
                                txtPrecio.Text = row.Cells["PRECIO"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Precio"
                                idLibro = row.Cells["ID"].Value.ToString();
                                btNuevo.Visible = false;
                                btnCancelar.Visible = true;
                                dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                panelContenedor.Visible = true;
                                panelPrincipal.Size = new Size(437, 463);
                                btnRegistrarLibro.Text = "Actualizar";

                            }

                        }
                        if (dgvLibro.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                idLibro = row.Cells["ID"].Value.ToString();
                                obj_libro.Id = Convert.ToInt32(idLibro);
                                if (MessageBox.Show("Esta seguro de Eliminar Este Libro? ", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    if (obj_libro.EliminarLibro())
                                    {
                                        MessageBox.Show("Libro eliminado con éxito");
                                        CargarDatos();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Eliminar el Libro");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btNuevo.Visible = true;
            btnCancelar.Visible = false;
            panelContenedor.Visible = false;
            panelPrincipal.Size = new Size(1020, 632);
            dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarDatos();
        }
    }
}
