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
        public RegistroLibro()
        {
            InitializeComponent();
            dgvLibro.SelectionChanged += dgvLibro_SelectionChanged;
        }


        private void CargarDatos()
        {
            MetodosLibros libro_N = new MetodosLibros();
            DataTable dt = libro_N.MostrarLibros();
            dgvLibro.DataSource = dt;
            dgvLibro.ClearSelection();
            dgvLibro.AutoGenerateColumns = false;
        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                MetodosLibros libro_N = new MetodosLibros();
                libro_N.Titulo = txtTitulo.Text;
                libro_N.Autor = txtAutor.Text;
                libro_N.Anio = Convert.ToInt32(txtAnio.Text);
                libro_N.Cantidad = Convert.ToInt32(txtCantidad.Text);
                libro_N.Precio = Convert.ToDecimal(txtPrecio.Text);
                libro_N.InsertarLibros();

                // Limpia los TextBox después de la inserción
                LimpiarCampos();

                // Vuelve a cargar los datos en el DataGridView
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar libro: " + ex.Message);
            }

        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            dgvLibro.ClearSelection();
        }

        private void dgvLibro_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibro.CurrentRow != null)
            {
                txtTitulo.Text = dgvLibro.CurrentRow.Cells["Titulo"].Value?.ToString() ?? string.Empty;
                txtAutor.Text = dgvLibro.CurrentRow.Cells["Autor"].Value?.ToString() ?? string.Empty;
                txtAnio.Text = dgvLibro.CurrentRow.Cells["Anio"].Value?.ToString() ?? string.Empty;
                txtCantidad.Text = dgvLibro.CurrentRow.Cells["Cantidad"].Value?.ToString() ?? string.Empty;
                txtPrecio.Text = dgvLibro.CurrentRow.Cells["Precio"].Value?.ToString() ?? string.Empty;
            }

        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvLibro.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {
                        txtTitulo.Text = row.Cells["Titulo"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Titulo"
                        txtAutor.Text = row.Cells["Autor"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Autor"
                        txtAnio.Text = row.Cells["Anio"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Anio"
                        txtCantidad.Text = row.Cells["Cantidad"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Cantidad"
                        txtPrecio.Text = row.Cells["Precio"].Value?.ToString() ?? string.Empty; // Accede al valor de la celda "Precio"
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

        private void RegistroLibro_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarCampos();
            dgvLibro.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibro.CurrentRow != null)
                {
                    MetodosLibros libro_N = new MetodosLibros();
                    int id = Convert.ToInt32(dgvLibro.CurrentRow.Cells["ID"].Value);
                    libro_N.EliminarLibro(id);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();

                    // Limpia los TextBox después de la eliminación
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un libro para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar libro: " + ex.Message);
            }

        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dgvLibro.CurrentRow != null)
                {
                    // Obtener el ID del libro seleccionado
                    int id = Convert.ToInt32(dgvLibro.CurrentRow.Cells["ID"].Value);

                    // Obtener los datos de los TextBox
                    MetodosLibros libro_N = new MetodosLibros
                    {
                        Id = id,
                        Titulo = txtTitulo.Text,
                        Autor = txtAutor.Text,
                        Anio = Convert.ToInt32(txtAnio.Text),
                        Cantidad = Convert.ToInt32(txtCantidad.Text),
                        Precio = Convert.ToDecimal(txtPrecio.Text)
                    };

                    // Actualizar el libro en la base de datos
                    libro_N.ActualizarLibro();

                    // Actualizar los datos en el DataGridView
                    dgvLibro.CurrentRow.Cells["Titulo"].Value = libro_N.Titulo;
                    dgvLibro.CurrentRow.Cells["Autor"].Value = libro_N.Autor;
                    dgvLibro.CurrentRow.Cells["Anio"].Value = libro_N.Anio;
                    dgvLibro.CurrentRow.Cells["Cantidad"].Value = libro_N.Cantidad;
                    dgvLibro.CurrentRow.Cells["Precio"].Value = libro_N.Precio;

                    MessageBox.Show("Cambios guardados correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila para guardar los cambios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (dgvLibro.Columns.Count == 0)
            {
                dgvLibro.Columns.Add("ID", "ID");
                dgvLibro.Columns.Add("Titulo", "Título");
                dgvLibro.Columns.Add("Autor", "Autor");
                dgvLibro.Columns.Add("Anio", "Año");
                dgvLibro.Columns.Add("Cantidad", "Cantidad");
                dgvLibro.Columns.Add("Precio", "Precio");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
