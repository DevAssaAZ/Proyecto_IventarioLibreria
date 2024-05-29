using Negocio.Libros_cn;
using Negocio.Login_cn;
using Negocio.Stock_cn.StockEntrada;
using Presentacion.Metodos.AbrirYCerrarFormularios;
using Presentacion.Metodos.Stock.DatosDelStock;
using Presentacion.Metodos.Stock.DatosDeTablas;
using Presentacion.Metodos.Stock.Entrada;
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
        
        private int idLibro;
        private string nombrelibro;
        private string idStock;
        public Stock()
        {
            InitializeComponent();
        }


        private void Stock_Load(object sender, EventArgs e)
        {
            //Llamada del metodo para ver stock
            DatosLoaderStock.CargarDatosStock(dgvLibrosStock);
            //Llamada del metodo para ver stock de entrada
            DatosLoaderStockEntrada.CargarDatosStockEntrada(dgvEntradaStock);
            //Llamada al metodo para limpiar los campos de registro de stock de entrada
            LimpiarCamposRegistroStockEntrada.LimpiarCampos(txtCantidad, rtComentarios);
            LlenarComboBox();
        }
        

        //Evento para manejar el formatiar celdas (en este caso cambiar el color)
        private void dgvLibrosStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Llamada del metodo para las condiciones de las cantidades
            CondicionesParaCantidad.FormatearCeldaCantidad(e, dgvLibrosStock);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Llamada al metodo para cerrar formularios
            CerrarFormularios.Cerrarform(this);
        }



        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para ingresar un nuevo stock de entrada
            NuevaEntradaStock.NuevaEntrada(btnNuevaEntrada, btnCancelar, cbLibros, dgvLibrosStock, dgvEntradaStock, dgvSalidaStock, panelContenedor, panelPrincipal, txtCantidad, rtComentarios);
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para cancelar un registro
            CancelarOperacionRegistroStockEntrada.CancelarEntrada(btnNuevaEntrada, btnCancelar, panelContenedor, panelPrincipal, dgvLibrosStock, dgvEntradaStock, dgvSalidaStock, txtCantidad, rtComentarios);
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
            //Llamada del metodo para registrar y actualizar stock de entrada
            RegistrarActualizarStockEntrada.RegistrarActualizarStock( ref idLibro, txtCantidad, dtFecha, txtProvedor, rtComentarios, dgvLibrosStock, dgvEntradaStock, btnNuevaEntrada, btnCancelar, panelContenedor, panelPrincipal, dgvSalidaStock);
        }

        private void dgvEntradaStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llamada del metodo para realizar acciones en la tabla de stock entrada
            AccionesDelDataViewGriedStockEntrada.AccionesTablaEntradaStock(e, dgvEntradaStock, txtNombreLibro, txtCantidad, txtProvedor, rtComentarios, txtIdStock, btnNuevaEntrada, btnCancelar, btnRegistrarStockEntrada, ref nombrelibro, dgvLibrosStock, panelContenedor, panelPrincipal);
        }
    }
}
