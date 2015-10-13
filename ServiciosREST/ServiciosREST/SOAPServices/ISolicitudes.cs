using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using System.ServiceModel.Web;

namespace RESTServices
{
    [ServiceContract]
    public interface ISolicitudes
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Solicitudes", ResponseFormat = WebMessageFormat.Json)]
        Solicitud CrearSolicitud(Solicitud solicitudACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Solicitudes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Solicitud ObtenerSolicitud(string codigo);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Solicitudes", ResponseFormat = WebMessageFormat.Json)]
        Solicitud ModificarSolicitud(Solicitud solicitudAModificar);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        List<Solicitud> ListarSolicitudes();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "SolicitudesPorEstado/{estado}", ResponseFormat = WebMessageFormat.Json)]
        List<Solicitud> ListarSolicitudesPorEstado(string estado);


    }
}
