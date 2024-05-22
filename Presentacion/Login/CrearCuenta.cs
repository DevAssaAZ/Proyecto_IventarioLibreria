using Negocio.Login_cn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Login
{
    public partial class CrearCuenta : Form
    {
        private Usuario_N obj_Usuario = new Usuario_N();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void linkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var volverinicio = new Login_();
            volverinicio.ShowDialog();

        }

        private void txtUsuarioRecuperar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Usuario.Rol = cmbRol.Text;
                obj_Usuario.NombreCompleto = txtNombreCrear.Text;
                obj_Usuario.Email = txtCorreoCrear.Text;
                obj_Usuario.Password = txtContraseñaCrear.Text;
                obj_Usuario.UserName = txtUsuarioCrear.Text;

                // Debug: Mostrar los valores que se están pasando
                MessageBox.Show($"Rol: {obj_Usuario.Rol}, Nombre Completo: {obj_Usuario.NombreCompleto}, Email: {obj_Usuario.Email}, Password: {obj_Usuario.Password}, Usuario: {obj_Usuario.UserName}");

                if (obj_Usuario.CrearUsuario(obj_Usuario))
                {
                    MessageBox.Show("Registrado con éxito");
                    txtUsuarioCrear.Text = "USUARIO";
                    txtContraseñaCrear.Text = "CONTRASEÑA";
                    txtNombreCrear.Text = "NOMBRE COMPLETO (APELLIDOS Y NOMBRES)";
                    txtCorreoCrear.Text = "EMAIL";
                    cmbRol.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar usuario: " + ex.Message);
            }
        }
    }
}
