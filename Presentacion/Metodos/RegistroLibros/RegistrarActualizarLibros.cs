using Negocio.Libros_cn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroLibros
{
    public static class RegistrarActualizarLibros
    {
        //Metodo para agregar o actualizar un libro
        public static void RegistrarActualizarLibro(Button btnRegistrarLibro, string idLibro, DataGridView dgvLibro, TextBox txtTitulo, TextBox txtAutor, TextBox txtAnio, TextBox txtCantidad, TextBox txtPrecio, Button btNuevo, Button btnCancelar, Panel panelContenedor, Panel panelPrincipal)
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
                        // Cargar datos al cargar el formulario
                        DatosLoaderLibros.CargarDatosLibros(dgvLibro);
                        // Llamada del método para limpiar los campos de los registros
                        LimpiarCamposRegistroLibros.LimpiarCampos(txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio);
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
            else if (btnRegistrarLibro.Text == "Actualizar")
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
                        // Cargar datos al cargar el formulario
                        DatosLoaderLibros.CargarDatosLibros(dgvLibro);
                        // Llamada del método para limpiar los campos de los registros
                        LimpiarCamposRegistroLibros.LimpiarCampos(txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio);
                        btNuevo.Visible = true;
                        btnCancelar.Visible = false;
                        panelContenedor.Visible = false;
                        panelPrincipal.Size = new Size(1020, 632);
                        dgvLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el libro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                btnRegistrarLibro.Text = "Registrar";
            }
        }
    }
}
