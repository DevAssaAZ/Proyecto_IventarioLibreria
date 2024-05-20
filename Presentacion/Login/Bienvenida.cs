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

namespace Presentacion.Login
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            ProgressBar.Value += 1;
            ProgressBar.Text = ProgressBar.Value.ToString();
            if (ProgressBar.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            lbNombre.Text = CacheDeInicioDeSesion.NombreCompleto;
            this.Opacity = 0.0;
            ProgressBar.Value = 0;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            timer1.Start();
        }
    }
}
