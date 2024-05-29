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
using Presentacion.Metodos.AbrirYCerrarFormularios;

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
            //Llamada al metodo para cerrar formularios
            CerrarFormularios.Cerrarform(this);
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




        private void ShowMenu(System.Windows.Forms.Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }
            
        }


        //Mostrar usuarios
        public void MostrarUsuarios()
        {
            MetodosUsuario usuario = new MetodosUsuario();
            DataTable dt = usuario.MostrarUsuarios();
            dataUsuarios.DataSource = dt;
            dataUsuarios.ClearSelection();
            dataUsuarios.AutoGenerateColumns = false;
            //dataUsuarios.DataSource = obj_usuarios.MostrarUsuarios();
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

        private void RefrescarTabla()
        {
            //


        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = true;
            btnNuevo.Visible = false;
            panelPrincipal.Size = new Size(482, 539);
            ShowMenu(panelContenedor);
            CrearCuenta form = new CrearCuenta(this);
            form.BackColor = Color.FromArgb(46, 68, 96);
            form.linkInicio.Visible = false;
            AddOwnedForm(form);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);  // Corrected line
            this.Tag = form;
            form.BringToFront();
            form.FormClosed += CrearCuenta_FormClosed;
            AbrirFormularioEnPanel(form);





        }


        private void CrearCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnVolver.Visible = false;
            btnNuevo.Visible = true;
            panelPrincipal.Size = new Size(482, 539);
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
                    btnVolver.Visible = true;
                    btnNuevo.Visible = false;
                    panelPrincipal.Size = new Size(482, 539);
                    ShowMenu(panelContenedor);
                    CrearCuenta form = new CrearCuenta(this,idUsuario, rol, usuario, contraseña, nombreCompleto, email);
                    form.BackColor = Color.FromArgb(46, 68, 96);
                    form.linkInicio.Visible = false;
                    form.FormClosed += new FormClosedEventHandler(MostrarLogoAlCerrarFormulario);
                    AbrirFormularioEnPanel(form);
                }
               
            }
            if (dataUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataUsuarios.Rows[e.RowIndex];
                    idUsuario = row.Cells["ID"].Value.ToString();
                    obj_usuarios.Id = Convert.ToInt32(idUsuario);
                    if (MessageBox.Show("Esta seguro de Eliminar a este usuario? ", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (obj_usuarios.EliminarUsuario())
                        {
                            MessageBox.Show("Eliminado con éxito");
                            MostrarUsuarios();

                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar el usuario");
                        }

                    }

                }
            }



        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = true;
            btnVolver.Visible = false;
            panelContenedor.Visible = false;
            panelPrincipal.Size = new Size(1020, 632);
            MostrarUsuarios();

        }

        public void RedimensionarPanel()
        {
            panelPrincipal.Size = new Size(1020, 632);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Size = new Size(1020, 632);
        }
    }
}
