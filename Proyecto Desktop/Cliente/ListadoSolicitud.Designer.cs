namespace SolicitarCambioMoneda
{
    partial class frmListadoSolicitud
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
            this.btnConsultarSolicitudes = new System.Windows.Forms.Button();
            this.cboEstadoSolicitud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.dgvSolicitud = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.LightSteelBlue;
            this.c.Controls.Add(this.btnConsultarSolicitudes);
            this.c.Controls.Add(this.cboEstadoSolicitud);
            this.c.Controls.Add(this.label1);
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(2, 2);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(718, 84);
            this.c.TabIndex = 2;
            this.c.TabStop = false;
            this.c.Text = "Cliente";
            // 
            // btnConsultarSolicitudes
            // 
            this.btnConsultarSolicitudes.AutoSize = true;
            this.btnConsultarSolicitudes.Location = new System.Drawing.Point(337, 18);
            this.btnConsultarSolicitudes.Name = "btnConsultarSolicitudes";
            this.btnConsultarSolicitudes.Size = new System.Drawing.Size(125, 38);
            this.btnConsultarSolicitudes.TabIndex = 5;
            this.btnConsultarSolicitudes.Text = "Consultar";
            this.btnConsultarSolicitudes.UseVisualStyleBackColor = true;
            this.btnConsultarSolicitudes.Click += new System.EventHandler(this.btnConsultarSolicitudes_Click);
            // 
            // cboEstadoSolicitud
            // 
            this.cboEstadoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoSolicitud.Items.AddRange(new object[] {
            "PENDIENTE",
            "APROBADO",
            "DESAPROBADO"});
            this.cboEstadoSolicitud.Location = new System.Drawing.Point(125, 24);
            this.cboEstadoSolicitud.Name = "cboEstadoSolicitud";
            this.cboEstadoSolicitud.Size = new System.Drawing.Size(189, 28);
            this.cboEstadoSolicitud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado Solicitud:";
            // 
            // gbProductos
            // 
            this.gbProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbProductos.Controls.Add(this.btnDetalle);
            this.gbProductos.Controls.Add(this.dgvSolicitud);
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(2, 92);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(718, 350);
            this.gbProductos.TabIndex = 3;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos del Cliente";
            // 
            // btnDetalle
            // 
            this.btnDetalle.AutoSize = true;
            this.btnDetalle.Enabled = false;
            this.btnDetalle.Location = new System.Drawing.Point(513, 311);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(170, 30);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dgvSolicitud
            // 
            this.dgvSolicitud.AllowUserToAddRows = false;
            this.dgvSolicitud.AllowUserToDeleteRows = false;
            this.dgvSolicitud.AllowUserToResizeColumns = false;
            this.dgvSolicitud.AllowUserToResizeRows = false;
            this.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.FechaSolicitud,
            this.EstadoSolicitud,
            this.Producto});
            this.dgvSolicitud.Location = new System.Drawing.Point(6, 22);
            this.dgvSolicitud.Name = "dgvSolicitud";
            this.dgvSolicitud.RowHeadersVisible = false;
            this.dgvSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitud.Size = new System.Drawing.Size(709, 276);
            this.dgvSolicitud.TabIndex = 0;
            this.dgvSolicitud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitud_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.HeaderText = "Fecha Solicitud";
            this.FechaSolicitud.Name = "FechaSolicitud";
            this.FechaSolicitud.Width = 150;
            // 
            // EstadoSolicitud
            // 
            this.EstadoSolicitud.HeaderText = "Estado Solicitud";
            this.EstadoSolicitud.Name = "EstadoSolicitud";
            this.EstadoSolicitud.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 150;
            // 
            // frmListadoSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoSolicitud";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoSolicitud";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListadoSolicitud_FormClosing);
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnConsultarSolicitudes;
        private System.Windows.Forms.DataGridView dgvSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        public System.Windows.Forms.ComboBox cboEstadoSolicitud;
    }
}