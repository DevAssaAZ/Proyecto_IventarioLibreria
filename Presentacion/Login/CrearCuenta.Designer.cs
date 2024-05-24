namespace Presentacion.Login
{
    partial class CrearCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuenta));
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtUsuarioCrear = new System.Windows.Forms.TextBox();
            this.txtContraseñaCrear = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.linkInicio = new System.Windows.Forms.LinkLabel();
            this.txtNombreCrear = new System.Windows.Forms.TextBox();
            this.txtCorreoCrear = new System.Windows.Forms.TextBox();
            this.panelCrearCuenta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCrearCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.White;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbRol.ForeColor = System.Drawing.Color.Black;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "EMPLEADO"});
            this.cmbRol.Location = new System.Drawing.Point(176, 81);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(192, 29);
            this.cmbRol.TabIndex = 0;
            this.cmbRol.Text = "ROL";
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.BackColor = System.Drawing.Color.White;
            this.txtUsuarioCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCrear.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioCrear.Location = new System.Drawing.Point(36, 326);
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.Size = new System.Drawing.Size(332, 20);
            this.txtUsuarioCrear.TabIndex = 3;
            this.txtUsuarioCrear.Text = "USUARIO";
            this.txtUsuarioCrear.TextChanged += new System.EventHandler(this.txtUsuarioRecuperar_TextChanged);
            // 
            // txtContraseñaCrear
            // 
            this.txtContraseñaCrear.BackColor = System.Drawing.Color.White;
            this.txtContraseñaCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaCrear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtContraseñaCrear.ForeColor = System.Drawing.Color.Black;
            this.txtContraseñaCrear.Location = new System.Drawing.Point(36, 397);
            this.txtContraseñaCrear.Name = "txtContraseñaCrear";
            this.txtContraseñaCrear.Size = new System.Drawing.Size(332, 20);
            this.txtContraseñaCrear.TabIndex = 3;
            this.txtContraseñaCrear.Text = "CONTRASEÑA";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(36, 6);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(153, 22);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "CREAR CUENTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistro.Location = new System.Drawing.Point(231, 432);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(137, 44);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // linkInicio
            // 
            this.linkInicio.AutoSize = true;
            this.linkInicio.BackColor = System.Drawing.Color.Transparent;
            this.linkInicio.ForeColor = System.Drawing.Color.White;
            this.linkInicio.LinkColor = System.Drawing.Color.DimGray;
            this.linkInicio.Location = new System.Drawing.Point(318, 488);
            this.linkInicio.Name = "linkInicio";
            this.linkInicio.Size = new System.Drawing.Size(50, 13);
            this.linkInicio.TabIndex = 14;
            this.linkInicio.TabStop = true;
            this.linkInicio.Text = "VOLVER";
            this.linkInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInicio_LinkClicked);
            // 
            // txtNombreCrear
            // 
            this.txtNombreCrear.BackColor = System.Drawing.Color.White;
            this.txtNombreCrear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCrear.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCrear.Location = new System.Drawing.Point(36, 183);
            this.txtNombreCrear.Name = "txtNombreCrear";
            this.txtNombreCrear.Size = new System.Drawing.Size(332, 27);
            this.txtNombreCrear.TabIndex = 15;
            this.txtNombreCrear.Text = "APELLIDOS Y NOMBRES";
            // 
            // txtCorreoCrear
            // 
            this.txtCorreoCrear.BackColor = System.Drawing.Color.White;
            this.txtCorreoCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCrear.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoCrear.Location = new System.Drawing.Point(36, 256);
            this.txtCorreoCrear.Name = "txtCorreoCrear";
            this.txtCorreoCrear.Size = new System.Drawing.Size(332, 20);
            this.txtCorreoCrear.TabIndex = 16;
            this.txtCorreoCrear.Text = "CORREO ELECTRONICO";
            // 
            // panelCrearCuenta
            // 
            this.panelCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.panelCrearCuenta.Controls.Add(this.titulo);
            this.panelCrearCuenta.Controls.Add(this.linkInicio);
            this.panelCrearCuenta.Controls.Add(this.label4);
            this.panelCrearCuenta.Controls.Add(this.label3);
            this.panelCrearCuenta.Controls.Add(this.label2);
            this.panelCrearCuenta.Controls.Add(this.txtCorreoCrear);
            this.panelCrearCuenta.Controls.Add(this.label1);
            this.panelCrearCuenta.Controls.Add(this.txtNombreCrear);
            this.panelCrearCuenta.Controls.Add(this.pictureBox1);
            this.panelCrearCuenta.Controls.Add(this.txtUsuarioCrear);
            this.panelCrearCuenta.Controls.Add(this.txtContraseñaCrear);
            this.panelCrearCuenta.Controls.Add(this.btnRegistro);
            this.panelCrearCuenta.Controls.Add(this.cmbRol);
            this.panelCrearCuenta.Location = new System.Drawing.Point(12, 10);
            this.panelCrearCuenta.Name = "panelCrearCuenta";
            this.panelCrearCuenta.Size = new System.Drawing.Size(396, 517);
            this.panelCrearCuenta.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Correo Electronico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Completo:";
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(423, 539);
            this.Controls.Add(this.panelCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearCuenta";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCrearCuenta.ResumeLayout(false);
            this.panelCrearCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistro;
        public System.Windows.Forms.Panel panelCrearCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel linkInicio;
<<<<<<< HEAD
        public System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.TextBox txtUsuarioCrear;
        public System.Windows.Forms.TextBox txtContraseñaCrear;
        public System.Windows.Forms.Label titulo;
        public System.Windows.Forms.TextBox txtNombreCrear;
        public System.Windows.Forms.TextBox txtCorreoCrear;
=======
>>>>>>> Main
    }
}