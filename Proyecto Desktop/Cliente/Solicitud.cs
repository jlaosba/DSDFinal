using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolicitarCambioMoneda.Dominio;
using SolicitarCambioMoneda.Persistencia;

namespace SolicitarCambioMoneda
{
    public partial class frmSolicitud : Form
    {
        bool bCerrar = false;
        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public clsProducto ProductoCliente { get; set; }

        public frmSolicitud()
        {
            InitializeComponent();
            txtSolicitud.ReadOnly = false;
        }
                
        public void CargarSolicitudProducto()
        {
            try 
	        {
                txtCodigo.Text = CodigoCliente;
                txtNombre.Text = NombreCliente;

                txtCodProd.Text = ProductoCliente.codProducto.ToString();
                txtDescrip.Text = ProductoCliente.codTipoProducto.ToString();
                txtTipoMoneda.Text = ProductoCliente.tipoMoneda;
                txtCuotas.Text = ProductoCliente.cuotas.ToString();
                txtSeguroDes.Text = ProductoCliente.seguroDes.ToString();
                txtSeguroBien.Text = ProductoCliente.seguroBien.ToString();
                dtpFechaVencimiento.Value = ProductoCliente.fechaVenc;
                dtpFechaRegistro.Value = ProductoCliente.fechaRegistro;
                txtTasa.Text = ProductoCliente.tasaInteres.ToString();
                txtMontoPend.Text = ProductoCliente.montoPendiente.ToString();

	        }
	        catch (Exception)
	        {
		        throw;
	        }
        }

        private void frmSolicitud_Load(object sender, EventArgs e)
        {
            CargarSolicitudProducto();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txtSolicitud.Text))
                {
                    MessageBox.Show("Debe de ingresar una descripción en la solicitud.", "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
                    return;
                }

            btnRegistrar.Enabled = false;

            if (bCerrar)
            {
                //Application.Exit();
                this.Close();
                return;
            }

            SolicitudNegocio solNeg = new SolicitudNegocio();
            clsSolicitud solicitud = new clsSolicitud();


                solicitud.Cliente = txtCodigo.Text;
                solicitud.Descripcion = txtSolicitud.Text;
                solicitud.Producto = int.Parse(txtCodProd.Text);
                
                clsSolicitud solNuevo = new clsSolicitud();
                solNuevo = solNeg.CrearSolicitud(solicitud);

                if (solNuevo != null)
                {
                    txtSolicitud.ReadOnly = true;
                    MessageBox.Show("La solicitud ha sido registrada correctamente.", "Sistema de Cambio de Moneda", MessageBoxButtons.OK);

                    btnRegistrar.Text = "Salir";
                    btnRegistrar.Enabled = true;
                    bCerrar = true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al momento de registrar la solicitud.", "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
                    btnRegistrar.Enabled = true;
                }



            }
            catch (Exception ex)
            {
                btnRegistrar.Enabled = true;
                MessageBox.Show("Ocurrió un problema al momento de registrar la solicitud. " + "\r\n" + "Error: " + ex.Message.ToString(), "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
            }


        }

        private void frmSolicitud_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //if (!bCerrar)
                //{
                    if (this.Visible)
                    {
                        MenuPrincipal objFrmMenuPrincipal = new MenuPrincipal();
                        objFrmMenuPrincipal.Show();
                    }    
                //}
                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
