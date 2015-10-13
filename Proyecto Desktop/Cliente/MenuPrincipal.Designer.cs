namespace SolicitarCambioMoneda
{
    partial class MenuPrincipal
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
            this.btnAprobarDesaprobarSolicitud = new System.Windows.Forms.Button();
            this.btnRegistrarSolicitud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAprobarDesaprobarSolicitud
            // 
            this.btnAprobarDesaprobarSolicitud.BackColor = System.Drawing.Color.White;
            this.btnAprobarDesaprobarSolicitud.Location = new System.Drawing.Point(224, 247);
            this.btnAprobarDesaprobarSolicitud.Name = "btnAprobarDesaprobarSolicitud";
            this.btnAprobarDesaprobarSolicitud.Size = new System.Drawing.Size(242, 60);
            this.btnAprobarDesaprobarSolicitud.TabIndex = 1;
            this.btnAprobarDesaprobarSolicitud.UseVisualStyleBackColor = false;
            this.btnAprobarDesaprobarSolicitud.Click += new System.EventHandler(this.btnAprobarDesaprobarSolicitud_Click);
            // 
            // btnRegistrarSolicitud
            // 
            this.btnRegistrarSolicitud.BackColor = System.Drawing.Color.White;
            this.btnRegistrarSolicitud.Location = new System.Drawing.Point(224, 110);
            this.btnRegistrarSolicitud.Name = "btnRegistrarSolicitud";
            this.btnRegistrarSolicitud.Size = new System.Drawing.Size(242, 60);
            this.btnRegistrarSolicitud.TabIndex = 2;
            this.btnRegistrarSolicitud.Text = "Registrar Solicitud de Cambio";
            this.btnRegistrarSolicitud.UseVisualStyleBackColor = false;
            this.btnRegistrarSolicitud.Click += new System.EventHandler(this.btnRegistrarSolicitud_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(698, 443);
            this.Controls.Add(this.btnRegistrarSolicitud);
            this.Controls.Add(this.btnAprobarDesaprobarSolicitud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAprobarDesaprobarSolicitud;
        private System.Windows.Forms.Button btnRegistrarSolicitud;
    }
}