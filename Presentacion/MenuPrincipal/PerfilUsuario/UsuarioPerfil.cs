using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
using Negocio;
using System.Runtime.InteropServices;
using Negocio.EditarPerfil;

namespace Presentacion.MenuPrincipal.PerfilUsuario
{
    public partial class UsuarioPerfil : Form
    {
        public UsuarioPerfil()
        {
            InitializeComponent();
        }

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            LoadDatosUsuario();
            ControlEditarPass();
        }





        #region Mis metodos


        //Metodo para cargar datos de usuario en la vista del perfil y panel de edicion
        private void LoadDatosUsuario()
        {
            //vista
            lbUser.Text = CacheDeInicioDeSesion.UserName;
            lbName.Text = CacheDeInicioDeSesion.NombreCompleto;
            lbMail.Text = CacheDeInicioDeSesion.Email;
            lbRol.Text = CacheDeInicioDeSesion.Rol;

            //panel de edicion
            txtUsuario.Text = CacheDeInicioDeSesion.UserName;
            txtNombres.Text = CacheDeInicioDeSesion.NombreCompleto;
            txtEmail.Text = CacheDeInicioDeSesion.Email;
            txtPass.Text = CacheDeInicioDeSesion.Password;
            txtConfirmarPass.Text = CacheDeInicioDeSesion.Password;
            txtActualPass.Text = "";

        }

        //Metodo para cambiar la contraseña
        private void ControlEditarPass()
        {
            lkpass.Text = "Editar";
            txtPass.Enabled = false;
            txtPass.UseSystemPasswordChar = true;
            txtConfirmarPass.Enabled = false;
            txtConfirmarPass.UseSystemPasswordChar = true;

        }

        //Metodo para reiniciar y actualizar datos en la interfaz
        private void reset()
        {
            LoadDatosUsuario();
            ControlEditarPass();
        }






        #endregion
        



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            LoadDatosUsuario();

        }

        private void lkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lkpass.Text == "Editar")
            {
                lkpass.Text = "Cancelar";
                txtPass.Enabled = true;
                txtPass.Text = "";
                txtConfirmarPass.Enabled = true;
                txtConfirmarPass.Text = "";
            }else if(lkpass.Text == "Cancelar")
            {
                reset();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length >= 5)
            {
                if (txtPass.Text == txtConfirmarPass.Text)
                {
                    if (txtActualPass.Text == CacheDeInicioDeSesion.Password)
                    {
                        var modeloUsuario = new EditarPerfil(id: CacheDeInicioDeSesion.IdUser,
                            userName: txtUsuario.Text,
                            password: txtPass.Text,
                            nombreCompleto: txtNombres.Text,
                            email: txtEmail.Text,
                            rol: null);
                        var resultado = modeloUsuario.EditarPerfilUsuario();
                        MessageBox.Show(resultado);
                        reset();
                        panel1.Visible = false;

                    }
                    else
                        MessageBox.Show("Contraseña actual incorrecta, intente de nuevo.");
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, intente de nuevo.");
            }else
                MessageBox.Show("La contraseña debe de tener minimo 5 caracteres.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }
    }
}
