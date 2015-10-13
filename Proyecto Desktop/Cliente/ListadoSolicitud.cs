using SolicitarCambioMoneda.Dominio;
using SolicitarCambioMoneda.Persistencia;
using SolicitarCambioMoneda.ws.Producto;
using SolicitarCambioMoneda.ws.Cliente;
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
    public partial class frmListadoSolicitud : Form
    {
        public frmListadoSolicitud()
        {
            InitializeComponent();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            try
            {
                // Listar Solicitud y Datos del Cliente

                SolicitudNegocio solNeg = new SolicitudNegocio();
                clsSolicitud solicitud = new clsSolicitud();
                int iCodigoSolicitud = (int)dgvSolicitud.CurrentRow.Cells["Codigo"].Value;
                solicitud = solNeg.ObtenerSolicitud(iCodigoSolicitud);

                if (solicitud != null)
                {
                    frmConfirmarSolicitud objfrmConfirmarSolicitud = new frmConfirmarSolicitud();

                    ProductosClient proxyProducto = new ProductosClient();
                    Producto producto = new Producto();

                    producto = proxyProducto.ObtenerProducto(solicitud.Producto);

                    if (producto != null)   
                    {

                        clsProducto objProducto = new clsProducto();

                        objProducto.codProducto = producto.codProducto;
                        objProducto.codCliente = producto.codCliente;
                        objProducto.monto = producto.monto;
                        objProducto.codTipoProducto = producto.codTipoProducto;
                        objProducto.tipoMoneda = producto.tipoMoneda;
                        objProducto.cuotas = producto.cuotas;
                        objProducto.seguroDes = producto.seguroDes;
                        objProducto.seguroBien = producto.seguroBien;
                        objProducto.fechaVenc = producto.fechaVenc;
                        objProducto.fechaRegistro = producto.fechaRegistro;
                        objProducto.tasaInteres = producto.tasaInteres;
                        objProducto.montoPendiente = producto.montoPendiente;

                        objfrmConfirmarSolicitud.ProductoSolicitud = objProducto;

                        ClientesClient proxyCliente = new ClientesClient();
                        Cliente cliente = new Cliente();

                        cliente = proxyCliente.ObtenerCliente(solicitud.Cliente);

                        if (cliente!= null)
	                    {
                            clsCliente objCliente = new clsCliente();

                            objCliente.CodCliente = cliente.CodCliente;
                            objCliente.Nombre = cliente.Nombre;
                            objCliente.ApePat = cliente.ApePat;
                            objCliente.ApeMat = cliente.ApeMat;
                            objCliente.Direccion = cliente.Direccion;
                            objCliente.Telefono = cliente.Telefono;
                            objCliente.Correo = cliente.Correo;
                            objCliente.EstadoCivil = cliente.EstadoCivil;
                            objCliente.FechaNacimiento = cliente.FechaNacimiento;

                            objfrmConfirmarSolicitud.clienteSolicitud = objCliente;

                            objfrmConfirmarSolicitud.codigoSolicitud = solicitud.Codigo;
                            objfrmConfirmarSolicitud.descripcionSolicitud = solicitud.Descripcion;

                            this.Hide();
                            objfrmConfirmarSolicitud.Show();
		 
	                    }
                    }                  

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de obtener la Solicitud. " + "\r\n" + ex.Message.ToString(), "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
            }            
        }

        private void btnConsultarSolicitudes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitud.RowCount>0)
                {
                    dgvSolicitud.Rows.Clear();
                }

               

                if (cboEstadoSolicitud.SelectedIndex != -1)
                {
                    SolicitudNegocio solNeg = new SolicitudNegocio();
                    List<clsSolicitud> ListaSolicitud = new List<clsSolicitud>();
                    string estado = cboEstadoSolicitud.SelectedItem.ToString();
                    ListaSolicitud = solNeg.ListarSolicitudesPorEstado(estado);

                    if (ListaSolicitud != null)
                    {
                        foreach (clsSolicitud beanSolicitud in ListaSolicitud)
                        {
                            int fila = dgvSolicitud.Rows.Add();
                            dgvSolicitud.Rows[fila].Cells["Codigo"].Value = beanSolicitud.Codigo;
                            dgvSolicitud.Rows[fila].Cells["Descripcion"].Value = beanSolicitud.Descripcion;
                            dgvSolicitud.Rows[fila].Cells["FechaSolicitud"].Value = beanSolicitud.Fecha;
                            dgvSolicitud.Rows[fila].Cells["EstadoSolicitud"].Value = beanSolicitud.Estado;
                            dgvSolicitud.Rows[fila].Cells["Producto"].Value = beanSolicitud.Producto;
                        }
                        dgvSolicitud.Refresh();

                        if (dgvSolicitud.Rows.Count>0)
                        {
                            btnDetalle.Enabled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar una opción", "Sistema de Cambio de Moneda", MessageBoxButtons.OK);
                }


                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void frmListadoSolicitud_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    MenuPrincipal objFrmMenuPrincipal = new MenuPrincipal();
                    objFrmMenuPrincipal.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSolicitud.RowCount>0)
                {
                    btnDetalle_Click(null, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
