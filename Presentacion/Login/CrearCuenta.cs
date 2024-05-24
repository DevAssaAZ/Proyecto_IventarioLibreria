using Negocio.EditarPerfil;
using Negocio.Usuarios_cn;
using Presentacion.MenuPrincipal;
using Presentacion.Modulos.RegistroUsuarios;
using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentacion.Login
{
    public partial class CrearCuenta : Form
    {
        private MetodosUsuario obj_Usuario = new MetodosUsuario();
        private string IdUs = null;
        public CrearCuenta()
        {
            InitializeComponent();
            btnRegistro.Text = "Registrar";
        }

        public CrearCuenta(string id, string rol, string usuario, string contraseña, string nombreCompleto, string email)
        {
            InitializeComponent();

            // Llenar los campos con los datos pasados
            
            IdUs = id;
            cmbRol.Text = rol;
            txtUsuarioCrear.Text = usuario;
            txtContraseñaCrear.Text = contraseña;
            txtNombreCrear.Text = nombreCompleto;
            txtCorreoCrear.Text = email;
            btnRegistro.Text = "Actualizar";


        }

        












        private void linkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var volverinicio = new Login_();
            volverinicio.ShowDialog();
            

        }

        private void txtUsuarioRecuperar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (btnRegistro.Text == "Registrar") {
                try
                {


                    obj_Usuario.Rol = cmbRol.Text;
                    obj_Usuario.NombreCompleto = txtNombreCrear.Text;
                    obj_Usuario.Email = txtCorreoCrear.Text;
                    obj_Usuario.Password = txtContraseñaCrear.Text;
                    obj_Usuario.UserName = txtUsuarioCrear.Text;

                    // Debug: Mostrar los valores que se están pasando
                    MessageBox.Show($"Rol: {obj_Usuario.Rol}, Nombre Completo: {obj_Usuario.NombreCompleto}, Email: {obj_Usuario.Email}, Password: {obj_Usuario.Password}, Usuario: {obj_Usuario.UserName}");

                    if (obj_Usuario.InsertarUsuario())
                    {
                        MessageBox.Show("Registrado con éxito");
                        
                        RegistroUsuarios form = new RegistroUsuarios();
                        //AddOwnedForm(form);
                        form.MostrarUsuarios();
                        form.panelContenedor.Visible = false;
                        form.panelPrincipal.Size = new Size(979, 539);
                        


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
            } if(btnRegistro.Text == "Actualizar")
            {
                obj_Usuario.Id = Convert.ToInt32(IdUs);
                obj_Usuario.Rol = cmbRol.Text;
                obj_Usuario.NombreCompleto = txtNombreCrear.Text;
                obj_Usuario.Email = txtCorreoCrear.Text;
                obj_Usuario.Password = txtContraseñaCrear.Text;
                obj_Usuario.UserName = txtUsuarioCrear.Text;

                // Mensajes de depuración
                MessageBox.Show($"Id: {obj_Usuario.Id}, Rol: {obj_Usuario.Rol}, Nombre Completo: {obj_Usuario.NombreCompleto}, Email: {obj_Usuario.Email}, Password: {obj_Usuario.Password}, Usuario: {obj_Usuario.UserName}");

                try
                {
                    // Lógica para actualizar los datos en la base de datos
                    bool resultado = obj_Usuario.EditarUsuario();
                    if (resultado)
                    {
                        MessageBox.Show("Datos actualizados con éxito.");
                        this.Close();
                        RegistroUsuarios form = new RegistroUsuarios();
                        form.MostrarUsuarios();
                        form.panelContenedor.Visible = false;
                        form.panelPrincipal.Size = new Size(979, 539);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                btnRegistro.Text = "Registrar";
                
            }

            

        }
 
        
    }
}
