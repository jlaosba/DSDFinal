using SolicitarCambioMoneda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolicitarCambioMoneda.ws.Producto;

namespace SolicitarCambioMoneda
{
    public partial class frmCliente : Form
    {
        ws.Cliente.ClientesClient proxyCliente = new ws.Cliente.ClientesClient();
        ws.Cliente.Cliente cliente = new ws.Cliente.Cliente();
        ws.Producto.ProductosClient proxyProducto = new ws.Producto.ProductosClient();
        Producto producto = new ws.Producto.Producto();

        public frmCliente()
        {
            InitializeComponent();
            //txtCodigo.Text = "12345678";
            txtCodigo.Focus();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                frmSolicitud objFrmSolicitud = new frmSolicitud();

                objFrmSolicitud.CodigoCliente = txtCodigo.Text;
                objFrmSolicitud.NombreCliente = txtNombre.Text;
                
                int codigo = Convert.ToInt32(dgvProducto.CurrentRow.Cells["Codigo"].Value);

                producto = proxyProducto.ObtenerProducto(codigo);

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

                    objFrmSolicitud.ProductoCliente = objProducto;

                    this.Hide();
                    objFrmSolicitud.ShowDialog();

                }

               
            }
            catch (Exception)
            {
                throw;
            }

                    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count>0)
            dgvProducto.Rows.Clear();

            try
            {
               cliente =  proxyCliente.ObtenerCliente(txtCodigo.Text.Trim());

                if (cliente != null)
                {
                    txtNombre.Text = cliente.Nombre + " " + cliente.ApePat + " " + cliente.ApeMat;
                    txtDireccion.Text = cliente.Direccion;
                    txtTelefono.Text = cliente.Telefono.ToString();
                    txtCorreo.Text = cliente.Correo;

                    // Realizamos el llamado al servicio quelista los productos
                    

                    List<ws.Producto.Producto> ListaProductos = new List<ws.Producto.Producto>();
                    
                    ListaProductos = proxyProducto.ObtenerProductosporCliente(cliente.CodCliente).ToList();

                    if (ListaProductos.Count > 0)
                    {
                        //dgvProducto.DataSource = ListaProductos;
                        //dgvProducto.Refresh();

                        foreach (ws.Producto.Producto beanPproducto in ListaProductos)
                        {
                            int fila = dgvProducto.Rows.Add();
                            dgvProducto.Rows[fila].Cells["Codigo"].Value = beanPproducto.codProducto;
                            dgvProducto.Rows[fila].Cells["Descripcion"].Value = beanPproducto.codProducto;
                            dgvProducto.Rows[fila].Cells["Monto"].Value = beanPproducto.monto;
                            dgvProducto.Rows[fila].Cells["TipoMoneda"].Value = beanPproducto.tipoMoneda;
                        }
                        dgvProducto.Refresh();
                        btnSeleccionar.Enabled = true;

                    }
                    else
                    {
                        btnSeleccionar.Enabled = false;
                    }
                    

                }



            }
            catch (Exception)
            {
                
                throw;
            }
            


        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProducto.RowCount>0)
                {
                    btnSeleccionar_Click(null, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
