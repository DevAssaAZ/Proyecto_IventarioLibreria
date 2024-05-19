namespace Presentacion.Login
{
    partial class RecuperarPassword
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
            this.titulo = new System.Windows.Forms.Label();
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(99, 42);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(305, 18);
            this.titulo.TabIndex = 9;
            this.titulo.Text = "Ingrese su nombre o correo electronico:";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRequest.ForeColor = System.Drawing.Color.White;
            this.txtUserRequest.Location = new System.Drawing.Point(104, 84);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.Size = new System.Drawing.Size(591, 19);
            this.txtUserRequest.TabIndex = 8;
            this.txtUserRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEnviar.Location = new System.Drawing.Point(538, 134);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(162, 40);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResultado.Location = new System.Drawing.Point(99, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 17);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RecuperarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(798, 355);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.txtUserRequest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox txtUserRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblResultado;
    }
}