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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.linkInicio = new System.Windows.Forms.LinkLabel();
            this.txtNombreCrear = new System.Windows.Forms.TextBox();
            this.txtCorreoCrear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoCrear = new System.Windows.Forms.Label();
            this.panelCrearCuenta = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCrearCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRol.BackColor = System.Drawing.Color.Black;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbRol.ForeColor = System.Drawing.Color.White;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "EMPLEADO"});
            this.cmbRol.Location = new System.Drawing.Point(221, 128);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(250, 29);
            this.cmbRol.TabIndex = 0;
            this.cmbRol.Text = "ROL";
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioCrear.BackColor = System.Drawing.Color.Black;
            this.txtUsuarioCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCrear.ForeColor = System.Drawing.Color.White;
            this.txtUsuarioCrear.Location = new System.Drawing.Point(29, 332);
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.Size = new System.Drawing.Size(442, 20);
            this.txtUsuarioCrear.TabIndex = 3;
            this.txtUsuarioCrear.Text = "USUARIO";
            this.txtUsuarioCrear.TextChanged += new System.EventHandler(this.txtUsuarioRecuperar_TextChanged);
            // 
            // txtContraseñaCrear
            // 
            this.txtContraseñaCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaCrear.BackColor = System.Drawing.Color.Black;
            this.txtContraseñaCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaCrear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtContraseñaCrear.ForeColor = System.Drawing.Color.White;
            this.txtContraseñaCrear.Location = new System.Drawing.Point(29, 374);
            this.txtContraseñaCrear.Name = "txtContraseñaCrear";
            this.txtContraseñaCrear.Size = new System.Drawing.Size(442, 20);
            this.txtContraseñaCrear.TabIndex = 3;
            this.txtContraseñaCrear.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_________________________________________________________________________";
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(10, 21);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(212, 33);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "CREAR CUENTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistro.Location = new System.Drawing.Point(129, 440);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(199, 44);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.Text = "REGISTRARSE";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // linkInicio
            // 
            this.linkInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkInicio.AutoSize = true;
            this.linkInicio.ForeColor = System.Drawing.Color.White;
            this.linkInicio.LinkColor = System.Drawing.Color.DimGray;
            this.linkInicio.Location = new System.Drawing.Point(206, 511);
            this.linkInicio.Name = "linkInicio";
            this.linkInicio.Size = new System.Drawing.Size(50, 13);
            this.linkInicio.TabIndex = 14;
            this.linkInicio.TabStop = true;
            this.linkInicio.Text = "VOLVER";
            this.linkInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInicio_LinkClicked);
            // 
            // txtNombreCrear
            // 
            this.txtNombreCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCrear.BackColor = System.Drawing.Color.Black;
            this.txtNombreCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCrear.ForeColor = System.Drawing.Color.White;
            this.txtNombreCrear.Location = new System.Drawing.Point(29, 239);
            this.txtNombreCrear.Name = "txtNombreCrear";
            this.txtNombreCrear.Size = new System.Drawing.Size(442, 20);
            this.txtNombreCrear.TabIndex = 15;
            this.txtNombreCrear.Text = "APELLIDOS Y NOMBRES";
            // 
            // txtCorreoCrear
            // 
            this.txtCorreoCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoCrear.BackColor = System.Drawing.Color.Black;
            this.txtCorreoCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCrear.ForeColor = System.Drawing.Color.White;
            this.txtCorreoCrear.Location = new System.Drawing.Point(29, 286);
            this.txtCorreoCrear.Name = "txtCorreoCrear";
            this.txtCorreoCrear.Size = new System.Drawing.Size(442, 20);
            this.txtCorreoCrear.TabIndex = 16;
            this.txtCorreoCrear.Text = "CORREO ELECTRONICO";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "_________________________________________________________________________";
            // 
            // txtApellidoCrear
            // 
            this.txtApellidoCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoCrear.AutoSize = true;
            this.txtApellidoCrear.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidoCrear.ForeColor = System.Drawing.Color.White;
            this.txtApellidoCrear.Location = new System.Drawing.Point(26, 256);
            this.txtApellidoCrear.Name = "txtApellidoCrear";
            this.txtApellidoCrear.Size = new System.Drawing.Size(445, 13);
            this.txtApellidoCrear.TabIndex = 18;
            this.txtApellidoCrear.Text = "_________________________________________________________________________";
            // 
            // panelCrearCuenta
            // 
            this.panelCrearCuenta.Controls.Add(this.txtNombreCrear);
            this.panelCrearCuenta.Controls.Add(this.pictureBox1);
            this.panelCrearCuenta.Controls.Add(this.cmbRol);
            this.panelCrearCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrearCuenta.Location = new System.Drawing.Point(0, 0);
            this.panelCrearCuenta.Name = "panelCrearCuenta";
            this.panelCrearCuenta.Size = new System.Drawing.Size(516, 554);
            this.panelCrearCuenta.TabIndex = 19;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(516, 554);
            this.Controls.Add(this.txtApellidoCrear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoCrear);
            this.Controls.Add(this.linkInicio);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaCrear);
            this.Controls.Add(this.txtUsuarioCrear);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtUsuarioCrear;
        private System.Windows.Forms.TextBox txtContraseñaCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.LinkLabel linkInicio;
        private System.Windows.Forms.TextBox txtNombreCrear;
        private System.Windows.Forms.TextBox txtCorreoCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtApellidoCrear;
        public System.Windows.Forms.Panel panelCrearCuenta;
    }
}