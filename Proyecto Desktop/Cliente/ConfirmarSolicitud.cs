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
using System.Net;
using System.Messaging;

namespace SolicitarCambioMoneda
{
    public partial class frmConfirmarSolicitud : Form
    {

        public clsCliente clienteSolicitud { get; set; }
        public clsProducto ProductoSolicitud { get; set; }
        public int codigoSolicitud { get; set; }
        public string descripcionSolicitud { get; set; }

        public frmConfirmarSolicitud()
        {
            InitializeComponent();
        }

        private void frmConfirmarSolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboBox(cboTipoMonedaOrigen);
                CargarComboBox(cboTipoMonedaCambio);
                CargarDatosAValidar();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void CargarComboBox(ComboBox objComboBox)
        {
            try
            {
                DataTable dataTable = new DataTable("TipoCambio");
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Name");
                dataTable.Rows.Add("PEN", "SOLES");
                dataTable.Rows.Add("USD", "DÓLARES");

                objComboBox.DataSource = dataTable;
                objComboBox.DisplayMember = "Name";
                objComboBox.ValueMember = "Id";

                objComboBox.SelectedIndex = 1;
                objComboBox.Refresh();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void CargarDatosAValidar()
        {
            try
            {
                txtCodigo.Text = clienteSolicitud.CodCliente;
                txtNombre.Text = clienteSolicitud.Nombre + " " + clienteSolicitud.ApePat + " " + clienteSolicitud.ApePat;
                txtCodigoSolicitud.Text = codigoSolicitud.ToString();
                txtDescripcionSolicitud.Text = descripcionSolicitud;


                txtCodProd.Text = ProductoSolicitud.codProducto.ToString();
                txtDescripcionProducto.Text = ProductoSolicitud.codTipoProducto.ToString();
                cboTipoMonedaOrigen.SelectedValue = ProductoSolicitud.tipoMoneda;
                txtCuotas.Text = ProductoSolicitud.cuotas.ToString();
                txtSeguroDes.Text = ProductoSolicitud.seguroDes.ToString();
                txtSeguroBien.Text = ProductoSolicitud.seguroBien.ToString();
                txtFechaVenc.Text = string.Format(ProductoSolicitud.fechaVenc.ToString(),"dd/MM/yyyy");
                txtFechaReg.Text = string.Format(ProductoSolicitud.fechaRegistro.ToString(),"dd/MM/yyyy");
                txtTasa.Text = ProductoSolicitud.tasaInteres.ToString();
                txtMontoPend.Text = ProductoSolicitud.montoPendiente.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de cargar los datos." + "\r\n" + ex.Message.ToString(), "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
            }
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            try
            {
                clsSolicitud solcitudAModificar = new clsSolicitud();
                solcitudAModificar.Codigo = Convert.ToInt32(txtCodigoSolicitud.Text);
                solcitudAModificar.Estado = "DESAPROBADO";

                SolicitudNegocio solNegocio = new SolicitudNegocio();
                solNegocio.ModificarSolicitud(solcitudAModificar);

                MessageBox.Show("La solicitud fue desaprobada correctamente.", "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
                btnAprobar.Enabled = false;
                btnDesaprobar.Enabled = false;
                btnCerrar.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de desaprobar la solicitud de cambio de moneda." + "\r\n" + ex.Message.ToString(), "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                clsCambioMoneda cambioMonedaARegistrar = new clsCambioMoneda();
                cambioMonedaARegistrar.Producto = Convert.ToInt32(txtCodProd.Text);
                cambioMonedaARegistrar.Cliente = txtCodigo.Text;
                cambioMonedaARegistrar.MonedaOrigen = cboTipoMonedaOrigen.SelectedValue.ToString();
                cambioMonedaARegistrar.MonedaCambio = cboTipoMonedaCambio.SelectedValue.ToString();
                cambioMonedaARegistrar.Monto = Convert.ToDecimal(txtCodProd.Text);
                cambioMonedaARegistrar.Cuotas = Convert.ToInt32(txtCuotas.Text);
                cambioMonedaARegistrar.FecVenc = Convert.ToDateTime(txtFechaVenc.Text);
                cambioMonedaARegistrar.TasaInteres = Convert.ToDecimal(txtTasa.Text);
                cambioMonedaARegistrar.TipoCambio = Convert.ToDecimal(3.221);
                cambioMonedaARegistrar.Estado = "APROBADO";

                CambioMonedaNegocio cambioMonedaNegocio = new CambioMonedaNegocio();
                clsCambioMoneda cambioMonedaRegistrada = new clsCambioMoneda ();
                cambioMonedaRegistrada = cambioMonedaNegocio.CrearCambioMoneda(cambioMonedaARegistrar);

                if (cambioMonedaRegistrada.Cliente != null)
                {
                    EnviarMensajeColaEmail(cambioMonedaARegistrar);
                    MessageBox.Show("La aprobación de la solicitud fue realizada correctamente.","Sistema de Cambio de Moneda", MessageBoxButtons.OK);
                    btnAprobar.Enabled = false;
                    btnDesaprobar.Enabled = false;
                    btnCerrar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ya existe una solicitud aprobada con el mismo código de producto.");
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de Aprobar la Solicitud. " + "\r\n" + ex.Message.ToString(), "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de Aprobar la Solicitud. " + "\r\n" + ex.Message.ToString(), "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
            }
        }

        private void frmConfirmarSolicitud_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                MenuPrincipal objFrmMenuPrincipal = new MenuPrincipal();
                objFrmMenuPrincipal.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EnviarMensajeColaEmail(clsCambioMoneda cambioMonedaARegistrar)
        {
            try
            {
                string rutaCola = @".\private$\dsanchez";
                if (!MessageQueue.Exists(rutaCola))
                {
                    MessageQueue.Create(rutaCola);
                }
                    MessageQueue cola = new MessageQueue(rutaCola);

                    System.Messaging.Message mensaje = new System.Messaging.Message();
                    mensaje.Label = "Nueva Email";
                    mensaje.Body = new colaEmail()
                                    {
                                        nombreCliente = txtNombre.Text,
                                        correoCliente = clienteSolicitud.Correo,
                                        codigoSolicitud = Convert.ToInt32(txtCodigoSolicitud.Text),
                                        tipoMonedaOrigen = cambioMonedaARegistrar.MonedaOrigen,
                                        tipoMonedaCambio = cambioMonedaARegistrar.MonedaCambio,
                                        tasaInteres = cambioMonedaARegistrar.TasaInteres,
                                        tipoCambio = cambioMonedaARegistrar.TipoCambio
                                    };
                    cola.Send(mensaje);


            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
