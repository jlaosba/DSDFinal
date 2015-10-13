using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using SolicitarCambioMoneda.Dominio;
using Newtonsoft.Json;

namespace SolicitarCambioMoneda.Persistencia
{
    public class CambioMonedaDAO
    {
        public clsCambioMoneda ObtenerCambioMoneda(string codigo)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/CambioMonedas.svc/CambioMonedas/" + codigo);
            req.Method = "GET";
            HttpWebResponse res = null;
            clsCambioMoneda cambioMonedaObtenida = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string cambioMonedaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                cambioMonedaObtenida = js.Deserialize<clsCambioMoneda>(cambioMonedaJson);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                //

                throw new Exception(mensaje);
            }
            return cambioMonedaObtenida;
        }

        public clsCambioMoneda CrearCambioMoneda(clsCambioMoneda cambioMonedaACrear)
        {

            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            string fechaJson = JsonConvert.SerializeObject(DateTime.Parse(cambioMonedaACrear.FecVenc.ToString()), microsoftDateFormatSettings).ToString();

            string postdata = "{\"Producto\":\"" + cambioMonedaACrear.Producto +
                "\",\"Cliente\":\"" + cambioMonedaACrear.Cliente +
                "\",\"MonedaOrigen\":\"" + cambioMonedaACrear.MonedaOrigen +
                "\",\"MonedaCambio\":\"" + cambioMonedaACrear.MonedaCambio +
                "\",\"Monto\":\"" + cambioMonedaACrear.Monto +
                "\",\"Cuotas\":\"" + cambioMonedaACrear.Cuotas +
                "\",\"FecVenc\":\"" + fechaJson.Substring(1, fechaJson.Length - 3) + "/" +
                "\",\"TasaInteres\":\"" + cambioMonedaACrear.TasaInteres +
                "\",\"TipoCambio\":\"" + cambioMonedaACrear.TipoCambio +
                "\",\"Estado\":\"" + cambioMonedaACrear.Estado + "\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/CambioMonedas.svc/CambioMonedas");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string cambioMonedaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                clsCambioMoneda cambioMonedaCreada = js.Deserialize<clsCambioMoneda>(cambioMonedaJson);
                return cambioMonedaCreada;
                //throw new Exception("Creacion realizada");
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                throw new Exception(mensaje);
            }
        }

        public clsCambioMoneda CrearCambioMoneda2(clsCambioMoneda cambioMonedaACrear)
        {

            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            string fechaJson = JsonConvert.SerializeObject(DateTime.Parse(cambioMonedaACrear.FecVenc.ToString()), microsoftDateFormatSettings).ToString();

            string postdata = "{\"Producto\":\"" + cambioMonedaACrear.Producto +
                "\",\"Cliente\":\"" + cambioMonedaACrear.Cliente +
                "\",\"MonedaOrigen\":\"" + cambioMonedaACrear.MonedaOrigen +
                "\",\"MonedaCambio\":\"" + cambioMonedaACrear.MonedaCambio +
                "\",\"Monto\":\"" + cambioMonedaACrear.Monto +
                "\",\"Cuotas\":\"" + cambioMonedaACrear.Cuotas +
                "\",\"FecVenc\":\"" + fechaJson.Substring(1, fechaJson.Length - 3) + "\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/CambioMonedas.svc/CambioMonedas2");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string cambioMonedaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                clsCambioMoneda cambioMonedaCreada = js.Deserialize<clsCambioMoneda>(cambioMonedaJson);
                return cambioMonedaCreada;
                throw new Exception("Creacion realizada");
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                throw new Exception(mensaje);
            }
        }

    }
}
