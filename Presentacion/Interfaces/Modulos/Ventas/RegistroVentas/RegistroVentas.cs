using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Clientes_cn;
using Negocio.Libros_cn;
using Negocio.Stock_cn.StockEntrada;
using Negocio.Usuarios_cn;
using Negocio.Ventas_cn;
using Soporte.Cache;
using Presentacion.Metodos.AbrirYCerrarFormularios;

namespace Presentacion.Modulos.RegistroVentas
{
    public partial class RegistroVentas : Form
    {
        MetodosVenta obj_venta = new MetodosVenta();
        private string idUsuario;
        private int idLibro;
        private int idCliente;
        private string idVenta;
        public RegistroVentas()
        {
            InitializeComponent();

        }

        private void CargarDatos()
        {
            MetodosVenta ventas_N = new MetodosVenta();
            DataTable dt = ventas_N.MostrarVentas();
            dgvVenta.DataSource = dt;
            dgvVenta.ClearSelection();
            dgvVenta.AutoGenerateColumns = false;

            dgvVenta.Columns["ID"].DisplayIndex = 0;
            dgvVenta.Columns["USUARIO_ID"].DisplayIndex = 1;
            dgvVenta.Columns["CLIENTE_ID"].DisplayIndex = 2;
            dgvVenta.Columns["LIBRO_ID"].DisplayIndex = 3;
            dgvVenta.Columns["CANTIDAD"].DisplayIndex = 4;
            dgvVenta.Columns["PRECIOTOTAL"].DisplayIndex = 5;
            dgvVenta.Columns["VER"].DisplayIndex = 6;
            dgvVenta.Columns["EDITAR"].DisplayIndex = 7;
            dgvVenta.Columns["ELIMINAR"].DisplayIndex = 8;
        }

        private void usuarioproceso()
        {
            textUsuario.Text = CacheDeInicioDeSesion.NombreCompleto;
            idUsuario = Convert.ToString(CacheDeInicioDeSesion.IdUser);
        }

        private void RegistroVentas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            usuarioproceso();
            LlenarComboBoxLibros();
            LlenarComboBoxClientes();
        }


        private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                MetodosVenta ventas = new MetodosVenta();
                CalculosVentas calculos = new CalculosVentas();
                ventas.UsuarioId = CacheDeInicioDeSesion.IdUser;
                ventas.ClienteId = idCliente;
                ventas.LibroId = idLibro;
                ventas.Cantidad = Convert.ToInt32(txtCantidad.Text); 
                
                ventas.PrecioTotal = calculos.CalculoVentas(Convert.ToDecimal(txtPrecio.Text), ventas.Cantidad = Convert.ToInt32(txtCantidad.Text));
                


                if (ventas.RegistrarVenta())
                {
                    MessageBox.Show("Venta Registrada");
                    // Vuelve a cargar los datos en el DataGridView
                    CargarDatos();



                }
                else
                {
                    MessageBox.Show("Error al registrar la venta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar la venta: " + ex.Message);
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Llamada al metodo para cerrar formularios
            CerrarFormularios.Cerrarform(this);
        }



        private void dgvVenta_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvVenta.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {


                        //if (dgvEntradaStock.Columns[e.ColumnIndex].Name == "Editar")
                        //{
                        //    if (e.RowIndex >= 0)
                        //    {

                        //        txtNombreLibro.Text = nombrelibro;
                        //        txtCantidad.Text = row.Cells["CANTIDAD"].Value?.ToString() ?? string.Empty;
                        //        //dtFecha = row.Cells["ANIO"].Value?.ToString() ?? string.Empty; 
                        //        txtProvedor.Text = row.Cells["PROVEEDOR"].Value?.ToString() ?? string.Empty;
                        //        rtComentarios.Text = row.Cells["COMENTARIOS"].Value?.ToString() ?? string.Empty;
                        //        txtIdStock.Text = row.Cells["ID"].Value.ToString();
                        //        btnNuevaEntrada.Visible = false;
                        //        btnCancelar.Visible = true;
                        //        dgvEntradaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        //        panelContenedor.Visible = true;
                        //        panelPrincipal.Size = new Size(437, 463);
                        //        btnRegistrarStockEntrada.Text = "Actualizar";
                        //        btnRegistrarStockEntrada.Enabled = false;

                        //    }

                        //}
                        if (dgvVenta.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                idVenta = row.Cells["ID"].Value.ToString();
                                obj_venta.Id = Convert.ToInt32(idVenta);
                                if (MessageBox.Show("Esta seguro de Eliminar Este Venta? ", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    if (obj_venta.EliminarVenta())
                                    {
                                        MessageBox.Show("Venta eliminada con éxito");
                                        CargarDatos();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Eliminar la venta");
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

        private void LlenarComboBoxLibros()
        {

            try
            {
                MetodosLibros libro_N = new MetodosLibros();
                DataTable tablaLibros = libro_N.MostrarLibros();

                // Configurar el ComboBox
                cblibros.DisplayMember = "TITULO";  // Columna que se mostrará en el ComboBox
                cblibros.ValueMember = "ID";  // Columna que representará el valor de cada ítem (asumiendo que tienes una columna 'ID')
                cblibros.DataSource = tablaLibros;

                // Suscribirse al evento SelectedIndexChanged
                cblibros.SelectedIndexChanged += new EventHandler(cblibros_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }



        private void cblibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ComboBox que lanzó el evento
            ComboBox comboBox = (ComboBox)sender;

            // Asegurarse de que hay un elemento seleccionado
            if (comboBox.SelectedItem != null)
            {
                // Obtener el DataRowView del elemento seleccionado
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;

                txtPrecio.Text = selectedRow["PRECIO"].ToString();


                // Obtener la ID del libro 
                idLibro = Convert.ToInt32(selectedRow["ID"]);


            }
        }

        private void LlenarComboBoxClientes()
        {

            try
            {
                MetodosCliente cliente_N = new MetodosCliente();
                DataTable tablaClientes = cliente_N.MostrarClientes();


                // Crear una nueva tabla con una columna concatenada
                DataTable tablaClientesConcat = new DataTable();
                tablaClientesConcat.Columns.Add("ID", typeof(int));
                tablaClientesConcat.Columns.Add("NombreCompleto", typeof(string));
                tablaClientesConcat.Columns.Add("CEDULA", typeof(string)); // Agregar la columna "CEDULA"

                foreach (DataRow row in tablaClientes.Rows)
                {
                    string nombreCompleto = row["APELLIDO"].ToString() + " " + row["NOMBRE"].ToString();
                    string cedulaCliente = row["CEDULA"].ToString(); // Obtener la cédula del cliente
                    

                    // Agregar la fila a la tablaClientesConcat
                    tablaClientesConcat.Rows.Add(row["ID"], nombreCompleto, cedulaCliente);
                }

                cbClientes.DisplayMember = "NombreCompleto";
                cbClientes.ValueMember = "ID";
                cbClientes.DataSource = tablaClientesConcat;
           

                // Suscribirse al evento SelectedIndexChanged
                cbClientes.SelectedIndexChanged += new EventHandler(cbClientes_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }



        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ComboBox que lanzó el evento
            ComboBox comboBox = (ComboBox)sender;

            // Asegurarse de que hay un elemento seleccionado
            if (comboBox.SelectedItem != null)
            {
                // Obtener el DataRowView del elemento seleccionado
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;

                // Obtener la cédula del cliente seleccionado
                string cedulaClienteSeleccionado = selectedRow.Row["CEDULA"].ToString();

                // Mostrar la cédula en el cuadro de texto txtCedula
                txtCedula.Text = cedulaClienteSeleccionado;

                // Obtener la ID del libro 
                idCliente = Convert.ToInt32(selectedRow["ID"]);


            }
        }
    }
}
