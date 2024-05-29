using Presentacion.Metodos.RegistroClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.AbrirYCerrarFormularios
{
    public static  class CerrarFormularios
    {
        //Metodo para cerrar ventanas de formularios
        public static void Cerrarform(Form form)
        {
            if (MessageBox.Show("Deseas Cerrar Esta Ventana?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                form.Close();
            }


        }


    }
}
