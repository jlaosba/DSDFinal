using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;
using System.ServiceModel.Web;
using System.Net;

namespace RESTServices
{
    public class Solicitudes : ISolicitudes
    {
        private SolicitudDAO dao = new SolicitudDAO();

        public Solicitud CrearSolicitud(Solicitud solicitudACrear)
        {
            return dao.Crear(solicitudACrear);
        }

        public Solicitud ObtenerSolicitud(string codigo)
        {
            if (dao.Obtener(int.Parse(codigo))== null)
            {
                throw new WebFaultException<string>(
                    "Codigo no existe", HttpStatusCode.InternalServerError);
            }
            return dao.Obtener(int.Parse(codigo));
        }

        public Solicitud ModificarSolicitud(Solicitud solicitudAModificar)
        {
            if (dao.Obtener(solicitudAModificar.Codigo) == null)
            {
                throw new WebFaultException<string>(
                 "Codigo no existe", HttpStatusCode.InternalServerError);
            }
            return dao.Modificar(solicitudAModificar);
        }

        public List<Solicitud> ListarSolicitudes()
        {
            return dao.ListarTodos();
        }

        public List<Solicitud> ListarSolicitudesPorEstado(string estado)
        {
            return dao.ListarSolicitudesPorEstado(estado);
        }

    }
}
