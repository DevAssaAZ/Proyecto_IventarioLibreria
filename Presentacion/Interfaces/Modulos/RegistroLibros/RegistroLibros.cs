using Negocio.Clientes_cn;
using Negocio.Libros_cn;
using Presentacion.Metodos.RegistroLibros;
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
        
        private string idLibro = null;

        public RegistroLibro()
        {
            InitializeComponent();
        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para registrar y actualizar libro
            RegistrarActualizarLibros.RegistrarActualizarLibro(btnRegistrarLibro, idLibro, dgvLibro, txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio, btNuevo, btnCancelar, panelContenedor, panelPrincipal);
        }

        private void RegistroLibro_Load_1(object sender, EventArgs e)
        {
            // Cargar datos al cargar el formulario
            DatosLoaderLibros.CargarDatosLibros(dgvLibro);
            //Llamada del metodo para limpias los campos de los registros
            LimpiarCamposRegistroLibros.LimpiarCampos(txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para nuevo registro libro
            NuevoRegistroLibro.NuevoRegistro(btNuevo, btnCancelar, dgvLibro, panelContenedor, panelPrincipal, txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLibro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Llamada del metodo para realizar acciones en la tabla de libros
            AccionesDelDataViewGriedLibros.AccionesTablaLibros(dgvLibro, e, txtTitulo, txtAutor, txtAnio, txtCantidad, txtPrecio, ref idLibro, btNuevo, btnCancelar, panelContenedor, panelPrincipal, btnRegistrarLibro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para cancelar la operacion de registrar o actualizar un libro
            CancelarOperacionRegistroLibro.Cancelar(btNuevo, btnCancelar, panelContenedor, panelPrincipal, dgvLibro);
        }

    }
}
