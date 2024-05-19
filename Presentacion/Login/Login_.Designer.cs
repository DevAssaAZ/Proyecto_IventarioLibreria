namespace Presentacion.Login
{
    partial class Login_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLibreria = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.linkRecuperarPass = new System.Windows.Forms.LinkLabel();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibreria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 355);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pbLibreria);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 355);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pbLibreria
            // 
            this.pbLibreria.Image = ((System.Drawing.Image)(resources.GetObject("pbLibreria.Image")));
            this.pbLibreria.Location = new System.Drawing.Point(34, 53);
            this.pbLibreria.Name = "pbLibreria";
            this.pbLibreria.Size = new System.Drawing.Size(174, 224);
            this.pbLibreria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLibreria.TabIndex = 0;
            this.pbLibreria.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________________________________________________";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(299, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(442, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(299, 146);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(442, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________________________________________________________________";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(402, 16);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(235, 33);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "INICIO DE SESIÓN";
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
            this.btnAcceder.Location = new System.Drawing.Point(299, 225);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(442, 40);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkCrearCuenta
            // 
            this.linkCrearCuenta.AutoSize = true;
            this.linkCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.linkCrearCuenta.LinkColor = System.Drawing.Color.DimGray;
            this.linkCrearCuenta.Location = new System.Drawing.Point(610, 319);
            this.linkCrearCuenta.Name = "linkCrearCuenta";
            this.linkCrearCuenta.Size = new System.Drawing.Size(131, 13);
            this.linkCrearCuenta.TabIndex = 1;
            this.linkCrearCuenta.TabStop = true;
            this.linkCrearCuenta.Text = "CREAR NUEVA CUENTA";
            // 
            // linkRecuperarPass
            // 
            this.linkRecuperarPass.AutoSize = true;
            this.linkRecuperarPass.ForeColor = System.Drawing.Color.White;
            this.linkRecuperarPass.LinkColor = System.Drawing.Color.DimGray;
            this.linkRecuperarPass.Location = new System.Drawing.Point(590, 291);
            this.linkRecuperarPass.Name = "linkRecuperarPass";
            this.linkRecuperarPass.Size = new System.Drawing.Size(151, 13);
            this.linkRecuperarPass.TabIndex = 0;
            this.linkRecuperarPass.TabStop = true;
            this.linkRecuperarPass.Text = "RECUPERAR CONTRASEÑA";
            this.linkRecuperarPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperarPass_LinkClicked);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMensajeError.Image = ((System.Drawing.Image)(resources.GetObject("lblMensajeError.Image")));
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(295, 184);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(446, 29);
            this.lblMensajeError.TabIndex = 14;
            this.lblMensajeError.Text = "Mensaje de Error";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(756, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(722, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Login_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(798, 355);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.linkRecuperarPass);
            this.Controls.Add(this.linkCrearCuenta);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLibreria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkCrearCuenta;
        private System.Windows.Forms.LinkLabel linkRecuperarPass;
        private System.Windows.Forms.PictureBox pbLibreria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}