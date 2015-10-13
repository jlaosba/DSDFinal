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
    public class Tipo_Producto : ITipo_Producto
    {
        private TipoProductoDAO tipoProductoDAO = null;
        private TipoProductoDAO TipoProductoDAO
        {
            get
            {
                if (tipoProductoDAO == null)
                    tipoProductoDAO = new TipoProductoDAO();
                return tipoProductoDAO;
            }
        }
        public List<TipoProducto> ListarTipoProductos()
        {
            return TipoProductoDAO.ListarTodos().ToList();
        }
    }
}
