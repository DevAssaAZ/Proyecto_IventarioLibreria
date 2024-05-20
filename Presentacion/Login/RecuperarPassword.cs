﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.Login_cn;

namespace Presentacion.Login
{
    public partial class RecuperarPassword : Form
    {
        public RecuperarPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            var user = new Usuario_N();
            var resultado = user.RecuperarPassword(txtUserRequest.Text);
            lblResultado.Text = "         "+ resultado;
            lblResultado.Visible = true;
        }

        private void RecuperarPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login_ lg = new Login_();
            lg.Show();
            this.Hide();
        }
    }
}