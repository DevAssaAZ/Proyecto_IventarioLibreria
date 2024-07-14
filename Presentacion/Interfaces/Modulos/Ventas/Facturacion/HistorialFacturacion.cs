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
    }
}
