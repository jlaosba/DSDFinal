using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    [ServiceContract]
    public interface ICambioMonedas
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CambioMonedas", ResponseFormat = WebMessageFormat.Json)]
        CambioMoneda CrearCambioMoneda(CambioMoneda cambioMonedaACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CambioMonedas/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        CambioMoneda ObtenerCambioMoneda(string codigo);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CambioMonedas2", ResponseFormat = WebMessageFormat.Json)]
        CambioMoneda CrearCambioMoneda2(CambioMoneda cambioMonedaACrear);
    }
}
