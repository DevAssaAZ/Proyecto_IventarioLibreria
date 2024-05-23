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
using Negocio.Usuarios_cn;

namespace Presentacion.Modulos.RegistroUsuarios
{
    public partial class RegistroUsuarios : Form
    {
        //Instancia de la clase de N_usuarios de Negocio
        MetodosUsuario obj_usuarios = new MetodosUsuario();
        private string idUsuario = null;







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
            
        }


        //Mostrar usuarios
        private void MostrarUsuarios()
        {
            dataUsuarios.DataSource = obj_usuarios.MostrarUsuarios();
            dataUsuarios.Columns["ID"].DisplayIndex = 0;
            dataUsuarios.Columns["USUARIO"].DisplayIndex = 1;
            dataUsuarios.Columns["CONTRASEÑA"].DisplayIndex = 2;
            dataUsuarios.Columns["APELLIDOS_NOMBRES"].DisplayIndex = 3;
            dataUsuarios.Columns["CORREO_ELECTRONICO"].DisplayIndex = 4;
            dataUsuarios.Columns["ROL"].DisplayIndex = 5;
            dataUsuarios.Columns["Ver"].DisplayIndex = 6;
            dataUsuarios.Columns["Editar"].DisplayIndex = 7;
            dataUsuarios.Columns["Eliminar"].DisplayIndex = 8;
        }






        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panelPrincipal.Size = new Size(469, 539);
            ShowMenu(panelContenedor);
            CrearCuenta form = new CrearCuenta();
            form.BackColor = Color.FromArgb(46, 68, 96);
            form.linkInicio.Visible = false;
            form.btnCancelar.Visible = true;
            form.FormClosed += new FormClosedEventHandler(MostrarLogoAlCerrarFormulario);
            AbrirFormularioEnPanel(form);

        }










        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void dataUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataUsuarios.Rows[e.RowIndex];

                    // Capturar los datos de la fila seleccionada
                    string rol = row.Cells["ROL"].Value.ToString();
                    string usuario = row.Cells["USUARIO"].Value.ToString();
                    string contraseña = row.Cells["CONTRASEÑA"].Value.ToString();
                    string nombreCompleto = row.Cells["APELLIDOS_NOMBRES"].Value.ToString();
                    string email = row.Cells["CORREO_ELECTRONICO"].Value.ToString();
                    idUsuario = row.Cells["ID"].Value.ToString();


                    // Abrir la ventana de edición y pasar los datos
                    panelPrincipal.Size = new Size(469, 539);
                    ShowMenu(panelContenedor);
                    CrearCuenta form = new CrearCuenta(idUsuario, rol, usuario, contraseña, nombreCompleto, email);
                    form.BackColor = Color.FromArgb(46, 68, 96);
                    form.linkInicio.Visible = false;
                    form.FormClosed += new FormClosedEventHandler(MostrarLogoAlCerrarFormulario);
                    AbrirFormularioEnPanel(form);
                }
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if(panelContenedor.Visible == false)
            {
                panelPrincipal.Size = new Size(873, 539);
            }
        }
    }
}
