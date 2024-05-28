using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.AbrirYCerrarFormularios
{
    public static class AbrirFormulariosEnPanel
    {
        //Metodo para abrir los formularios en paneles
        public static void AbrirFormularioEnPanel(Panel panelContenedor, Form formularioHijo)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }
    }
}
