using Negocio.Ventas_cn.Facturacion;
using Presentacion.Metodos.AbrirYCerrarFormularios;
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


        private void CargarDatos()
        {
            MetodosFacturacion fac = new MetodosFacturacion();
            DataTable dt = fac.MostrarFacturaciones();
            dgvFacturacion.DataSource = dt;
            dgvFacturacion.ClearSelection();
            dgvFacturacion.AutoGenerateColumns = false;

            dgvFacturacion.Columns["ID"].DisplayIndex = 0;
            dgvFacturacion.Columns["NUM_FACTURA"].DisplayIndex = 1;
            dgvFacturacion.Columns["CEDULA"].DisplayIndex = 2;
            dgvFacturacion.Columns["CLIENTE"].DisplayIndex = 3;
            dgvFacturacion.Columns["LIBRO"].DisplayIndex = 4;
            dgvFacturacion.Columns["CANTIDAD"].DisplayIndex = 5;
            dgvFacturacion.Columns["PRECIO_CANTIDAD"].DisplayIndex = 6;
            dgvFacturacion.Columns["DETALLES"].DisplayIndex = 7;
            dgvFacturacion.Columns["DESCUENTO"].DisplayIndex = 8;
            dgvFacturacion.Columns["PRECIO_TOTAL"].DisplayIndex = 9;
            dgvFacturacion.Columns["METODO_DE_PAGO"].DisplayIndex = 10;
            dgvFacturacion.Columns["ESTADO"].DisplayIndex = 11;
            dgvFacturacion.Columns["VER"].DisplayIndex = 12;
            dgvFacturacion.Columns["ELIMINAR"].DisplayIndex = 13;
        }

        private void HistorialFacturacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
