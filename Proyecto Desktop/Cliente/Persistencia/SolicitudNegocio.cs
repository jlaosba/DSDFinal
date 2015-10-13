using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolicitarCambioMoneda.Dominio;

namespace SolicitarCambioMoneda.Persistencia
{
    public class SolicitudNegocio
    {
        private SolicitudDAO solicitudDao = new SolicitudDAO();
        public clsSolicitud ObtenerSolicitud(int codigo)
        {
            try
            {
                return solicitudDao.ObtenerSolicitud(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public clsSolicitud CrearSolicitud(clsSolicitud solicitudACrear)
        {
            try
            {
                return solicitudDao.CrearSolicitud(solicitudACrear);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarSolicitud(clsSolicitud solicitudAModificar)
        {
            try
            {
                solicitudDao.ModificarSolicitud(solicitudAModificar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clsSolicitud> ListarSolicitudes()
        {
            try
            {
                return solicitudDao.ListarSolicitudes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clsSolicitud> ListarSolicitudesPorEstado(string estado)
        {
            try
            {
                return solicitudDao.ListarSolicitudesPorEstado(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
