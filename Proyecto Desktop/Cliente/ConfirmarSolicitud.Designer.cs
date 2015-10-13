namespace SolicitarCambioMoneda
{
    partial class frmConfirmarSolicitud
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
            this.c = new System.Windows.Forms.GroupBox();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.txtDescripcionSolicitud = new System.Windows.Forms.TextBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.txtCodigoSolicitud = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoMonedaCambio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaVenc = new System.Windows.Forms.TextBox();
            this.txtFechaReg = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtMontoPend = new System.Windows.Forms.TextBox();
            this.txtSeguroBien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.txtSeguroDes = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboTipoMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.c.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.LightSteelBlue;
            this.c.Controls.Add(this.btnCerrar);
            this.c.Controls.Add(this.btnDesaprobar);
            this.c.Controls.Add(this.txtDescripcionSolicitud);
            this.c.Controls.Add(this.btnAprobar);
            this.c.Controls.Add(this.txtCodigoSolicitud);
            this.c.Controls.Add(this.label14);
            this.c.Controls.Add(this.label15);
            this.c.Controls.Add(this.txtNombre);
            this.c.Controls.Add(this.txtCodigo);
            this.c.Controls.Add(this.label2);
            this.c.Controls.Add(this.label1);
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(0, 1);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(816, 233);
            this.c.TabIndex = 2;
            this.c.TabStop = false;
            this.c.Text = "Cliente";
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.AutoSize = true;
            this.btnDesaprobar.Location = new System.Drawing.Point(655, 95);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(138, 40);
            this.btnDesaprobar.TabIndex = 23;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // txtDescripcionSolicitud
            // 
            this.txtDescripcionSolicitud.Location = new System.Drawing.Point(105, 120);
            this.txtDescripcionSolicitud.Multiline = true;
            this.txtDescripcionSolicitud.Name = "txtDescripcionSolicitud";
            this.txtDescripcionSolicitud.ReadOnly = true;
            this.txtDescripcionSolicitud.Size = new System.Drawing.Size(455, 97);
            this.txtDescripcionSolicitud.TabIndex = 13;
            // 
            // btnAprobar
            // 
            this.btnAprobar.AutoSize = true;
            this.btnAprobar.Location = new System.Drawing.Point(655, 48);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(138, 40);
            this.btnAprobar.TabIndex = 22;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // txtCodigoSolicitud
            // 
            this.txtCodigoSolicitud.Location = new System.Drawing.Point(105, 90);
            this.txtCodigoSolicitud.Name = "txtCodigoSolicitud";
            this.txtCodigoSolicitud.ReadOnly = true;
            this.txtCodigoSolicitud.Size = new System.Drawing.Size(276, 26);
            this.txtCodigoSolicitud.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Solicitud:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Cod Solicitud:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(455, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(276, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.cboTipoMonedaOrigen);
            this.groupBox1.Controls.Add(this.cboTipoMonedaCambio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFechaVenc);
            this.groupBox1.Controls.Add(this.txtFechaReg);
            this.groupBox1.Controls.Add(this.txtTasa);
            this.groupBox1.Controls.Add(this.txtMontoPend);
            this.groupBox1.Controls.Add(this.txtSeguroBien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDescripcionProducto);
            this.groupBox1.Controls.Add(this.txtCuotas);
            this.groupBox1.Controls.Add(this.txtSeguroDes);
            this.groupBox1.Controls.Add(this.txtCodProd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // cboTipoMonedaCambio
            // 
            this.cboTipoMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMonedaCambio.FormattingEnabled = true;
            this.cboTipoMonedaCambio.Location = new System.Drawing.Point(129, 186);
            this.cboTipoMonedaCambio.Name = "cboTipoMonedaCambio";
            this.cboTipoMonedaCambio.Size = new System.Drawing.Size(121, 28);
            this.cboTipoMonedaCambio.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Moneda Cambio:";
            // 
            // txtFechaVenc
            // 
            this.txtFechaVenc.Location = new System.Drawing.Point(555, 54);
            this.txtFechaVenc.Name = "txtFechaVenc";
            this.txtFechaVenc.ReadOnly = true;
            this.txtFechaVenc.Size = new System.Drawing.Size(121, 26);
            this.txtFechaVenc.TabIndex = 19;
            // 
            // txtFechaReg
            // 
            this.txtFechaReg.Location = new System.Drawing.Point(555, 86);
            this.txtFechaReg.Name = "txtFechaReg";
            this.txtFechaReg.ReadOnly = true;
            this.txtFechaReg.Size = new System.Drawing.Size(121, 26);
            this.txtFechaReg.TabIndex = 18;
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(555, 118);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.ReadOnly = true;
            this.txtTasa.Size = new System.Drawing.Size(121, 26);
            this.txtTasa.TabIndex = 17;
            // 
            // txtMontoPend
            // 
            this.txtMontoPend.Location = new System.Drawing.Point(555, 150);
            this.txtMontoPend.Name = "txtMontoPend";
            this.txtMontoPend.ReadOnly = true;
            this.txtMontoPend.Size = new System.Drawing.Size(121, 26);
            this.txtMontoPend.TabIndex = 16;
            // 
            // txtSeguroBien
            // 
            this.txtSeguroBien.Location = new System.Drawing.Point(555, 24);
            this.txtSeguroBien.Name = "txtSeguroBien";
            this.txtSeguroBien.ReadOnly = true;
            this.txtSeguroBien.Size = new System.Drawing.Size(121, 26);
            this.txtSeguroBien.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Monto Pend:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tasa Interes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fecha Reg:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Fecha Venc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(438, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Seguro Bien:";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(129, 54);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.ReadOnly = true;
            this.txtDescripcionProducto.Size = new System.Drawing.Size(252, 26);
            this.txtDescripcionProducto.TabIndex = 9;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(129, 118);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.ReadOnly = true;
            this.txtCuotas.Size = new System.Drawing.Size(121, 26);
            this.txtCuotas.TabIndex = 7;
            // 
            // txtSeguroDes
            // 
            this.txtSeguroDes.Location = new System.Drawing.Point(129, 150);
            this.txtSeguroDes.Name = "txtSeguroDes";
            this.txtSeguroDes.ReadOnly = true;
            this.txtSeguroDes.Size = new System.Drawing.Size(121, 26);
            this.txtSeguroDes.TabIndex = 6;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(129, 24);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            this.txtCodProd.Size = new System.Drawing.Size(121, 26);
            this.txtCodProd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seguro Des:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuotas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Moneda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Location = new System.Drawing.Point(655, 142);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(138, 40);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboTipoMonedaOrigen
            // 
            this.cboTipoMonedaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMonedaOrigen.Enabled = false;
            this.cboTipoMonedaOrigen.FormattingEnabled = true;
            this.cboTipoMonedaOrigen.Location = new System.Drawing.Point(129, 86);
            this.cboTipoMonedaOrigen.Name = "cboTipoMonedaOrigen";
            this.cboTipoMonedaOrigen.Size = new System.Drawing.Size(121, 28);
            this.cboTipoMonedaOrigen.TabIndex = 22;
            // 
            // frmConfirmarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmarSolicitud";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobar / Desaprobar Solicitud";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfirmarSolicitud_FormClosing);
            this.Load += new System.EventHandler(this.frmConfirmarSolicitud_Load);
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox c;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoMonedaCambio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaVenc;
        private System.Windows.Forms.TextBox txtFechaReg;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtMontoPend;
        private System.Windows.Forms.TextBox txtSeguroBien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.TextBox txtSeguroDes;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionSolicitud;
        private System.Windows.Forms.TextBox txtCodigoSolicitud;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboTipoMonedaOrigen;
    }
}