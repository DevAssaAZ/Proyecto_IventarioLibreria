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
using Presentacion.Modulos.RegistroUsuarios;
using Presentacion.MenuPrincipal.Logo;
using Soporte.Cache;
using Presentacion.MenuPrincipal.PerfilUsuario;
using Presentacion.Modulos.RegistroClientes;
using Presentacion.Modulos.RegistroLibros;
using Presentacion.Modulos.RegistroVentas;
using Presentacion.Metodos.AbrirYCerrarFormularios;
using Presentacion.Modulos.RegistroVentas.Facturacion;
using Presentacion.Metodos.AbrirYCerrarFormularios.MostrarLogo;
using Presentacion.Metodos.MenuPrincipal;
using Presentacion.Metodos.MenuPrincipal.MenusDesplegables;
using Presentacion.Metodos.MenuPrincipal.AplicarRoles;
using Presentacion.Metodos.MenuPrincipal.AccionesDelFormulario;
using Presentacion.Interfaces.Modulos.Reserva.RegistroReserva;

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



        //Mover el formulario desde la barra
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para cerrar sesion
            SesionCerrada.CerrarSesion(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para salir del sistema
            Exit.Salir();

        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para maximizar la ventana principal
            MaximizarVentana.Maximizar(this, ref LX, ref LY, btnRestaurar, btnMaximizar);

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para Restaurar la ventana principal
            RestaurarVentana.Restaurar(this, LX, LY, btnRestaurar, btnMaximizar);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para minimizar la ventana principal
            MinimizarVentana.Minimizar(this);
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            //Llamada del metodo para mostrar el logo al inicio de la pantalla principal
            MostrarLogo.MostrarLogo1(panelContenedor);
            //Llamada del metodo para mostrar informacion del usuario en el apartado de perfil
            DatosUsuarioLoad.LoadDatosUsuario(lbRol, lbNombre, lbEmail);
            //Llamada al metodo de Administrar Permisos del Rol
            RolesPermisos.AplicarRolesPermisos(CacheDeInicioDeSesion.Rol, btnRegistroUsuarios, btnLibros);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Instancia del form UsuarioPerfil
            UsuarioPerfil form = new UsuarioPerfil();
            //Mostrar logo al cerrar este form
            form.FormClosed += Form_FormClosed;
            //Llamada de metodo para abrir el formulario en el panel
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, form);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para mostrar los submenu de los paneles
            MenuShow.ShowMenu(panelSubInventario, panelSubInventario, panelClientes, panelVentas);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para mostrar los submenu de los paneles
            MenuShow.ShowMenu(panelClientes, panelSubInventario, panelClientes, panelVentas);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Llamada del metodo para mostrar los submenu de los paneles
            MenuShow.ShowMenu(panelVentas, panelSubInventario, panelClientes, panelVentas);
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            RegistroLibro form = new RegistroLibro();
            form.panelPrincipal.Size = new Size(873, 539);
            //Mostrar logo al cerrar este form
            form.FormClosed += Form_FormClosed;
            //Llamada de metodo para abrir el formulario en el panel
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, form);
            //Llamada al metodo para esconder los paneles que sirven de menu
            MenuHider.HideMenu(panelSubInventario, panelClientes, panelVentas);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock form = new Stock();
            form.panelPrincipal.Size = new Size(873, 539);
            //Mostrar logo al cerrar este form
            form.FormClosed += Form_FormClosed;
            //Llamada de metodo para abrir el formulario en el panel
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, form);
            //Llamada al metodo para esconder los paneles que sirven de menu
            MenuHider.HideMenu(panelSubInventario, panelClientes, panelVentas);
        }

        private void btnRegistrarClientes_Click(object sender, EventArgs e)
        {
            RegistroCliente form = new RegistroCliente();
            form.panelPrincipal.Size = new Size(873, 539);
            //Mostrar logo al cerrar este form
            form.FormClosed += Form_FormClosed;
            //Llamada de metodo para abrir el formulario en el panel
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, form);
            //Llamada al metodo para esconder los paneles que sirven de menu
            MenuHider.HideMenu(panelSubInventario, panelClientes, panelVentas);
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            RegistroVentas form = new RegistroVentas();
            //Mostrar logo al cerrar este form
            form.FormClosed += Form_FormClosed;
            //Llamada de metodo para abrir el formulario en el panel
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, form);
            //Llamada al metodo para esconder los paneles que sirven de menu
            MenuHider.HideMenu(panelSubInventario, panelClientes, panelVentas);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {

            RegistroReserva facturacion = new RegistroReserva();
            //Llamado del metodo para abrir los formularios
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, facturacion);
            //Llamada al metodo para esconder los paneles que sirven de menu
            MenuHider.HideMenu(panelSubInventario, panelClientes, panelVentas);
        }


        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {

            RegistroUsuarios form = new RegistroUsuarios();
            form.panelPrincipal.Size = new Size(873, 539);
            //Mostrar logo al cerrar este form
            form.FormClosed += Form_FormClosed;
            //Llamada de metodo para abrir el formulario en el panel
            AbrirFormulariosEnPanel.AbrirFormularioEnPanel(panelContenedor, form);
        }

        //Evento para manejar que al cerrar un formulario regrese el logo
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarLogoAlCerrarForm.MostrarLogoAlCerrarFormulario(sender, e, panelContenedor);
        }
    }
}
