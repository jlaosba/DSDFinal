using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;

namespace SOAPServices
{
    public class Productos : IProductos
    {
        private ProductoDAO productoDAO = null;
        private ProductoDAO ProductoDAO
        {
            get
            {
                if (productoDAO == null)
                    productoDAO = new ProductoDAO();
                return productoDAO;
            }
        }
        public List<Producto> ListarProductos()
        {
            return ProductoDAO.ListarTodos().ToList();
        }


        public List<Producto> ObtenerProductosporCliente(string cliente)
        {
            List<Producto> productosporCliente = ProductoDAO.ListarTodos().ToList();
            //List<Producto> listaProductos = null;
            List<Producto> listaProductos = new List<Producto>();
            foreach (Producto beanProducto in productosporCliente)
            {
                if (beanProducto.codCliente == cliente)
                    listaProductos.Add(beanProducto);
                
            }
            return listaProductos;
        }
        
        public Producto ObtenerProducto(int codigo)
        {
            return ProductoDAO.Obtener(codigo);
        }

    }
}
