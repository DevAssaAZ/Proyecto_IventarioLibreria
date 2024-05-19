﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Presentacion.Modulos.RegistroUsuarios;
using Presentacion.MenuPrincipal.Logo;
using Soporte.Cache;

namespace Presentacion.MenuPrincipal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);





        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 321)
            {
                panelMenuVertical.Width = 69;
            }
            else
            {
                panelMenuVertical.Width = 321; 
            }
        }

        //Mover el formulario desde la barra
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar sesión?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar el programa? ", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            //Capturar posiciones del form
            LX = this.Location.X;
            LY = this.Location.Y;
            //Maximizar solo en el area de trabajo
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size=new Size(1300, 650);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        #region MisMetodos
        //Funcion para abrir el formulario en el panel
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


        //Funcione para cargar el logo como marca de agua
        private void MostrarLogo()
        {
            AbrirFormularioEnPanel(new MarcaLogo());
        }
        private void MostrarLogoAlCerrarFormulario(object sender, FormClosedEventArgs e)
        {
            MostrarLogo();
        }


        //Metodos para mostrar informacion en el perfil
        private void LoadDatosUsuario()
        {
            lbRol.Text = CacheDeInicioDeSesion.Rol;
            lbNombre.Text = CacheDeInicioDeSesion.NombreCompleto;
            lbEmail.Text = CacheDeInicioDeSesion.Email;
        }




        #endregion



        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarLogo();
            LoadDatosUsuario();
        }


        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            RegistroUsuarios form = new RegistroUsuarios();
            form.FormClosed += new FormClosedEventHandler(MostrarLogoAlCerrarFormulario);
            AbrirFormularioEnPanel(form);
        }
    }
}
