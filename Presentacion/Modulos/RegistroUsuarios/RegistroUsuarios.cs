using Presentacion.Login;
using Presentacion.MenuPrincipal.Logo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.RegistroUsuarios
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MostrarLogo()
        {
            AbrirFormularioEnPanel(new MarcaLogo());
        }
        private void MostrarLogoAlCerrarFormulario(object sender, FormClosedEventArgs e)
        {
            MostrarLogo();
        }




        private void AbrirFormularioEnPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form formularioHijo = FormHijo as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }



        
        private void ShowMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
               
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ShowMenu(panelContenedor);
            CrearCuenta form = new CrearCuenta();
            form.BackColor = Color.FromArgb(46, 68, 96);
            form.linkInicio.Visible = false;
            form.FormClosed += new FormClosedEventHandler(MostrarLogoAlCerrarFormulario);
            AbrirFormularioEnPanel(form);

        }
    }
}
