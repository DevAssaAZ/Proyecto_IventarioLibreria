using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Negocio.Login_cn;
using Presentacion.MenuPrincipal;

namespace Presentacion.Login
{
    public partial class Login_ : Form
    {
        
        public Login_()
        {
            InitializeComponent();
        }
        
       


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            //Condicion para borrar el Text "Usuario" y resaltar al momento de escribir
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            //Condicion para regresar el Text "USUARIO" y el color iniciar
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.White; 
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            //Condicion para borrar el Text "CONTRASEÑA" y resaltar al momento de escribir
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                //Ocultar los caracteres de la contraseña
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            //Condicion para regresar el Text "CONTRASEÑA" y el color iniciar
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.White;
                //Desactivar el ocultamiento de la contraseña
                txtPass.UseSystemPasswordChar = false;
            }
        }



        bool mover = false;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    Usuario_N user = new Usuario_N();
                    var validarLogin = user.LoginUsuario(txtUsuario.Text, txtPass.Text);
                    if(validarLogin == true)
                    {
                        Principal mainMenu = new Principal();
                        mainMenu.Show();
                        mainMenu.FormClosed += CerrarSession;
                        this.Hide();
                    }else
                    {
                        msgError("Usuario o contraseña incorrectos. Por favor, intente denuevo.");
                        txtPass.Text = "CONTRASEÑA";
                        txtUsuario.Focus();
                    }
                }
                else msgError("Por favor, ingrese su contraseña");

            }
            else msgError("Por favor, ingrese su usuario");
        }

        #region MetodosLogin

        //Metodo para mensaje de errores
        private void msgError(string msg)
        {
            lblMensajeError.Text = "           " + msg;
            lblMensajeError.Visible = true;
        }


        //Metodo para cerrar sesion
        private void CerrarSession(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible = false;
            this.Show();
            //txtUsuario.Focus();
        }



        #endregion



        //Funcion de boton para cerrar la ventana(X)
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Funcion de boton para minimizar ventana(-)
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
