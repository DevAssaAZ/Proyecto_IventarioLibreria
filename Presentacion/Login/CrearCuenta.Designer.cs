﻿namespace Presentacion.Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkInicio = new System.Windows.Forms.LinkLabel();
            this.txtNombreCrear = new System.Windows.Forms.TextBox();
            this.txtCorreoCrear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoCrear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Black;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbRol.ForeColor = System.Drawing.Color.White;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbRol.Location = new System.Drawing.Point(288, 33);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(442, 29);
            this.cmbRol.TabIndex = 0;
            this.cmbRol.Text = "ROL";
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.BackColor = System.Drawing.Color.Black;
            this.txtUsuarioCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCrear.ForeColor = System.Drawing.Color.White;
            this.txtUsuarioCrear.Location = new System.Drawing.Point(288, 174);
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.Size = new System.Drawing.Size(442, 20);
            this.txtUsuarioCrear.TabIndex = 3;
            this.txtUsuarioCrear.Text = "USUARIO";
            this.txtUsuarioCrear.TextChanged += new System.EventHandler(this.txtUsuarioRecuperar_TextChanged);
            // 
            // txtContraseñaCrear
            // 
            this.txtContraseñaCrear.BackColor = System.Drawing.Color.Black;
            this.txtContraseñaCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaCrear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtContraseñaCrear.ForeColor = System.Drawing.Color.White;
            this.txtContraseñaCrear.Location = new System.Drawing.Point(288, 216);
            this.txtContraseñaCrear.Name = "txtContraseñaCrear";
            this.txtContraseñaCrear.Size = new System.Drawing.Size(442, 20);
            this.txtContraseñaCrear.TabIndex = 3;
            this.txtContraseñaCrear.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_________________________________________________________________________";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(23, 21);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(212, 33);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "CREAR CUENTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-3, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(817, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(817, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Location = new System.Drawing.Point(288, 267);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(199, 44);
            this.btnAcceder.TabIndex = 12;
            this.btnAcceder.Text = "REGISTRARSE";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(531, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // linkInicio
            // 
            this.linkInicio.AutoSize = true;
            this.linkInicio.ForeColor = System.Drawing.Color.White;
            this.linkInicio.LinkColor = System.Drawing.Color.DimGray;
            this.linkInicio.Location = new System.Drawing.Point(605, 320);
            this.linkInicio.Name = "linkInicio";
            this.linkInicio.Size = new System.Drawing.Size(50, 13);
            this.linkInicio.TabIndex = 14;
            this.linkInicio.TabStop = true;
            this.linkInicio.Text = "VOLVER";
            this.linkInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInicio_LinkClicked);
            // 
            // txtNombreCrear
            // 
            this.txtNombreCrear.BackColor = System.Drawing.Color.Black;
            this.txtNombreCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCrear.ForeColor = System.Drawing.Color.White;
            this.txtNombreCrear.Location = new System.Drawing.Point(288, 81);
            this.txtNombreCrear.Name = "txtNombreCrear";
            this.txtNombreCrear.Size = new System.Drawing.Size(442, 20);
            this.txtNombreCrear.TabIndex = 15;
            this.txtNombreCrear.Text = "APELLIDOS Y NOMBRES";
            // 
            // txtCorreoCrear
            // 
            this.txtCorreoCrear.BackColor = System.Drawing.Color.Black;
            this.txtCorreoCrear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCrear.ForeColor = System.Drawing.Color.White;
            this.txtCorreoCrear.Location = new System.Drawing.Point(288, 128);
            this.txtCorreoCrear.Name = "txtCorreoCrear";
            this.txtCorreoCrear.Size = new System.Drawing.Size(442, 20);
            this.txtCorreoCrear.TabIndex = 16;
            this.txtCorreoCrear.Text = "CORREO ELECTRONICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "_________________________________________________________________________";
            // 
            // txtApellidoCrear
            // 
            this.txtApellidoCrear.AutoSize = true;
            this.txtApellidoCrear.ForeColor = System.Drawing.Color.White;
            this.txtApellidoCrear.Location = new System.Drawing.Point(285, 98);
            this.txtApellidoCrear.Name = "txtApellidoCrear";
            this.txtApellidoCrear.Size = new System.Drawing.Size(445, 13);
            this.txtApellidoCrear.TabIndex = 18;
            this.txtApellidoCrear.Text = "_________________________________________________________________________";
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(798, 355);
            this.Controls.Add(this.txtApellidoCrear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoCrear);
            this.Controls.Add(this.txtNombreCrear);
            this.Controls.Add(this.linkInicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaCrear);
            this.Controls.Add(this.txtUsuarioCrear);
            this.Controls.Add(this.cmbRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearCuenta";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkInicio;
        private System.Windows.Forms.TextBox txtNombreCrear;
        private System.Windows.Forms.TextBox txtCorreoCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtApellidoCrear;
    }
}