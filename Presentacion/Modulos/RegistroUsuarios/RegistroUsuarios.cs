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
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form formularioHijo = FormHijo as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formularioHijo);
            this.panelPrincipal.Tag = formularioHijo;
            formularioHijo.Show();
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textBuscar.Visible = false;
            btnBuscar.Visible = false;
            dataUsuarios.Visible = false;

            
            CrearCuenta form = new CrearCuenta();
            form.panelCrearCuenta.BackColor = Color.FromArgb(46, 68, 96);
            form.FormClosed += new FormClosedEventHandler(MostrarLogoAlCerrarFormulario);
            AbrirFormularioEnPanel(form);

        }
    }
}
