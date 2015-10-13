using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolicitarCambioMoneda.Dominio;
using System.Net;

namespace SolicitarCambioMoneda.Persistencia
{
    public class CambioMonedaNegocio
    {
        private CambioMonedaDAO cambioMonedaDao = new CambioMonedaDAO();
        public clsCambioMoneda ObtenerSolicitud(string codigo)
        {
            try
            {
                return cambioMonedaDao.ObtenerCambioMoneda(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public clsCambioMoneda CrearCambioMoneda(clsCambioMoneda CambioMonedaACrear)
        {
            clsCambioMoneda cambioMonedaACrear = new clsCambioMoneda();
            try
            {
                cambioMonedaACrear = cambioMonedaDao.CrearCambioMoneda(CambioMonedaACrear);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cambioMonedaACrear;
        }

        public clsCambioMoneda CrearCambioMoneda2(clsCambioMoneda CambioMonedaACrear)
        {
            try
            {
                return cambioMonedaDao.CrearCambioMoneda2(CambioMonedaACrear);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
