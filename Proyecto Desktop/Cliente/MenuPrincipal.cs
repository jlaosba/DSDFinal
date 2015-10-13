using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitarCambioMoneda
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            btnAprobarDesaprobarSolicitud.Text = "Aprobar / Desaprobar" + "\r\n" + "Solicitudes";
            btnRegistrarSolicitud.Focus();
        }

        private void btnRegistrarSolicitud_Click(object sender, EventArgs e)
        {
            frmCliente objFrmCliente = new frmCliente();
            this.Hide();
            objFrmCliente.ShowDialog();
        }

        private void btnAprobarDesaprobarSolicitud_Click(object sender, EventArgs e)
        {
            frmListadoSolicitud objfrmListadoSolicitud = new frmListadoSolicitud();
            this.Hide();
            objfrmListadoSolicitud.ShowDialog();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
