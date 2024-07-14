namespace Presentacion.Modulos.RegistroVentas.Facturacion
{
    partial class facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.rtbDetalles = new System.Windows.Forms.RichTextBox();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.cbDescuento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuentoAplicar = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDescuentoAplicar);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.btnProcesar);
            this.panel1.Controls.Add(this.rtbDetalles);
            this.panel1.Controls.Add(this.cbPago);
            this.panel1.Controls.Add(this.cbDescuento);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblDescuento);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFactura);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.txtPrecioTotal);
            this.panel1.Controls.Add(this.txtPrecioCantidad);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLibro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panelBarra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 557);
            this.panel1.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcesar.ForeColor = System.Drawing.Color.LightGray;
            this.btnProcesar.Location = new System.Drawing.Point(758, 466);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(113, 47);
            this.btnProcesar.TabIndex = 47;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            // 
            // rtbDetalles
            // 
            this.rtbDetalles.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtbDetalles.Location = new System.Drawing.Point(574, 126);
            this.rtbDetalles.Name = "rtbDetalles";
            this.rtbDetalles.Size = new System.Drawing.Size(297, 121);
            this.rtbDetalles.TabIndex = 46;
            this.rtbDetalles.Text = "";
            // 
            // cbPago
            // 
            this.cbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPago.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "SELECCIONAR",
            "EFECTIVO",
            "T. DEBITO",
            "T. CREDITO"});
            this.cbPago.Location = new System.Drawing.Point(662, 403);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(209, 29);
            this.cbPago.TabIndex = 45;
            // 
            // cbDescuento
            // 
            this.cbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescuento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbDescuento.FormattingEnabled = true;
            this.cbDescuento.Items.AddRange(new object[] {
            "SELECCIONAR",
            "APLICA",
            "NO APLICA"});
            this.cbDescuento.Location = new System.Drawing.Point(160, 386);
            this.cbDescuento.Name = "cbDescuento";
            this.cbDescuento.Size = new System.Drawing.Size(231, 29);
            this.cbDescuento.TabIndex = 44;
            this.cbDescuento.SelectedIndexChanged += new System.EventHandler(this.cbDescuento_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(482, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "Metodo de pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(37, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Descuento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(482, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 41;
            this.label8.Text = "Detalles:";
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFactura.Location = new System.Drawing.Point(628, 48);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(243, 27);
            this.txtFactura.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(482, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Num. Factura:";
            // 
            // txtPrecioCantidad
            // 
            this.txtPrecioCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrecioCantidad.Location = new System.Drawing.Point(208, 306);
            this.txtPrecioCantidad.Name = "txtPrecioCantidad";
            this.txtPrecioCantidad.ReadOnly = true;
            this.txtPrecioCantidad.Size = new System.Drawing.Size(183, 27);
            this.txtPrecioCantidad.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(37, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Precio Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(160, 257);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(231, 27);
            this.txtCantidad.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(37, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cantidad:";
            // 
            // txtLibro
            // 
            this.txtLibro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLibro.Location = new System.Drawing.Point(160, 208);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(231, 27);
            this.txtLibro.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(37, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Libro:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCliente.Location = new System.Drawing.Point(160, 115);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(231, 27);
            this.txtCliente.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(37, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cliente:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCedula.Location = new System.Drawing.Point(160, 68);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(231, 27);
            this.txtCedula.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(37, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cedula:";
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panelBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Controls.Add(this.label1);
            this.panelBarra.Controls.Add(this.panelVenta);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(916, 37);
            this.panelBarra.TabIndex = 17;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(882, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " FACTURACION";
            // 
            // panelVenta
            // 
            this.panelVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVenta.Location = new System.Drawing.Point(464, 31);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(582, 383);
            this.panelVenta.TabIndex = 16;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Enabled = false;
            this.lblDescuento.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblDescuento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescuento.Location = new System.Drawing.Point(68, 469);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(115, 22);
            this.lblDescuento.TabIndex = 42;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtDescuentoAplicar
            // 
            this.txtDescuentoAplicar.Enabled = false;
            this.txtDescuentoAplicar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescuentoAplicar.Location = new System.Drawing.Point(189, 467);
            this.txtDescuentoAplicar.Name = "txtDescuentoAplicar";
            this.txtDescuentoAplicar.Size = new System.Drawing.Size(68, 27);
            this.txtDescuentoAplicar.TabIndex = 48;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.Enabled = false;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAplicar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAplicar.Location = new System.Drawing.Point(274, 466);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(82, 32);
            this.btnAplicar.TabIndex = 47;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(624, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "Total a pagar:";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrecioTotal.Location = new System.Drawing.Point(769, 336);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(102, 27);
            this.txtPrecioTotal.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(624, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 22);
            this.label12.TabIndex = 37;
            this.label12.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescuento.Location = new System.Drawing.Point(769, 297);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(102, 27);
            this.txtDescuento.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(624, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 22);
            this.label13.TabIndex = 37;
            this.label13.Text = "Precio Total:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(769, 257);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(102, 27);
            this.txtPrecio.TabIndex = 38;
            // 
            // facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 557);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facturacion";
            this.Text = "Facturacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.TextBox txtPrecioCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.ComboBox cbDescuento;
        private System.Windows.Forms.RichTextBox rtbDetalles;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuentoAplicar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}