namespace Presentacion.Modulos.RegistroLibros
{
    partial class RegistroLibro
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
            this.label7 = new System.Windows.Forms.Label();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(10, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio Unitario:";
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(142, 253);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(98, 34);
            this.btNuevo.TabIndex = 13;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.Location = new System.Drawing.Point(13, 253);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(95, 34);
            this.btnRegistrarLibro.TabIndex = 11;
            this.btnRegistrarLibro.Text = "Registrar";
            this.btnRegistrarLibro.UseVisualStyleBackColor = true;
            this.btnRegistrarLibro.Click += new System.EventHandler(this.btnRegistrarLibro_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(125, 193);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(125, 150);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(89, 109);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(151, 20);
            this.txtAnio.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(89, 70);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(151, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(89, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(151, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Autor:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btNuevo);
            this.panel1.Controls.Add(this.btnRegistrarLibro);
            this.panel1.Controls.Add(this.dgvLibro);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtAnio);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 315);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(-8, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToAddRows = false;
            this.dgvLibro.AllowUserToDeleteRows = false;
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(256, -4);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.ReadOnly = true;
            this.dgvLibro.Size = new System.Drawing.Size(643, 314);
            this.dgvLibro.TabIndex = 10;
            this.dgvLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibro_CellContentClick);
            this.dgvLibro.SelectionChanged += new System.EventHandler(this.dgvLibro_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(9, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo:";
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(495, 7);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(128, 23);
            this.btnGuarda.TabIndex = 12;
            this.btnGuarda.Text = "Guardar cambios";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(686, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(862, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panelBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBarra.Controls.Add(this.btnGuarda);
            this.panelBarra.Controls.Add(this.btnEliminar);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Controls.Add(this.label1);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(898, 38);
            this.panelBarra.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE LIBROS EN EL SISTEMA";
            // 
            // RegistroLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroLibro";
            this.Text = "RegistroLibros";
            this.Load += new System.EventHandler(this.RegistroLibro_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btnRegistrarLibro;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLibro;
    }
}