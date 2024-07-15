using Negocio.Ventas_cn.Facturacion;
using Presentacion.Metodos.AbrirYCerrarFormularios;
using Presentacion.Metodos.RegistroVentas.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Interfaces.Modulos.Ventas.Facturacion
{
    public partial class HistorialFacturacion : Form
    {
        public HistorialFacturacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Llamada al metodo para cerrar formularios
            CerrarFormularios.Cerrarform(this);
        }
        private void HistorialFacturacion_Load(object sender, EventArgs e)
        {
            //Llamada del metodo para cargar los datos en el dataGriedView
            DatosLoaderFacturacion.CargarDatos(dgvFacturacion);
        }

        private void dgvFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llamada del metodo para las acciones que hay dentro de la tabla (Ver, Eliminar)
            AccionesDelDataGridViewFacturacion.Acciones(dgvFacturacion, e);
        }
    }
}
