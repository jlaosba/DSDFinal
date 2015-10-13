using RESTServices.Dominio;
using RESTServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    public class CambioMonedas : ICambioMonedas
    {
        private CambioMonedaDAO dao = new CambioMonedaDAO();
        public CambioMoneda CrearCambioMoneda(CambioMoneda cambioMonedaACrear)
        {
            CambioMoneda cambioMonedaRegistrado = new CambioMoneda();
            try
            {
                int iCodigoProducto = cambioMonedaACrear.Producto;
                CambioMoneda cambioMonedaObtenido = new CambioMoneda();
                cambioMonedaObtenido = dao.Obtener(iCodigoProducto);

                if (cambioMonedaObtenido == null)
                {
                    cambioMonedaRegistrado = dao.Crear(cambioMonedaACrear);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cambioMonedaRegistrado;
        }

        public CambioMoneda ObtenerCambioMoneda(string codigo)
        {
            if (dao.Obtener(int.Parse(codigo)) == null)
            {
                throw new WebFaultException<string>(
                    "Codigo Cambio Moneda no existe", HttpStatusCode.InternalServerError);
            }
            return dao.Obtener(int.Parse(codigo));
        }

        public CambioMoneda CrearCambioMoneda2(CambioMoneda cambioMonedaACrear)
        {
            return dao.Crear2(cambioMonedaACrear);
        }
    }
}
