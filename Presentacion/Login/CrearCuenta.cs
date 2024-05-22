﻿using Negocio.Login_cn;
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Usuario.rol = cmbRol.Text;
                obj_Usuario.nombreCompleto = txtNombreCrear.Text;
                obj_Usuario.email = txtCorreoCrear.Text;
                obj_Usuario.password = txtContraseñaCrear.Text;
                obj_Usuario.userName = txtUsuarioCrear.Text;

                obj_Usuario.CrearUsuario(obj_Usuario);
                MessageBox.Show("Registrado con exito");
                txtUsuarioCrear.Clear();
                txtContraseñaCrear.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar usuario: " + ex.Message);
            }

        }

        private void txtUsuarioRecuperar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
