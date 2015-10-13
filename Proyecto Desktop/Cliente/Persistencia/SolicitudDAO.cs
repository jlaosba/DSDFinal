using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using SolicitarCambioMoneda.Dominio;

namespace SolicitarCambioMoneda.Persistencia
{
    public class SolicitudDAO
    {
        public clsSolicitud ObtenerSolicitud(int codigo)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/Solicitudes.svc/Solicitudes/" + codigo.ToString());
            req.Method = "GET";
            HttpWebResponse res = null;
            clsSolicitud solicitudObtenida = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string solicitudJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                solicitudObtenida = js.Deserialize<clsSolicitud>(solicitudJson);
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
            return solicitudObtenida;
        }

        public clsSolicitud CrearSolicitud(clsSolicitud solicitudACrear)
        {
            string postdata = "{\"Cliente\":\"" + solicitudACrear.Cliente +
                "\",\"Descripcion\":\"" + solicitudACrear.Descripcion +
                "\",\"Estado\":\"" + solicitudACrear.Estado +
                "\",\"Producto\":\"" + solicitudACrear.Producto.ToString() + "\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/Solicitudes.svc/Solicitudes");
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
                string solicitudJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                clsSolicitud solicitudCreada = js.Deserialize<clsSolicitud>(solicitudJson);
                return solicitudCreada;
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

        public void ModificarSolicitud(clsSolicitud solicitudAModificar)
        {
            string postdata = "{\"Codigo\":\"" + solicitudAModificar.Codigo.ToString() +
                "\",\"Estado\":\"" + solicitudAModificar.Estado + "\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/Solicitudes.svc/Solicitudes");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string solicitudJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                clsSolicitud solicitudCreada = js.Deserialize<clsSolicitud>(solicitudJson);
                //throw new Exception("Modificacio realizada");
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

        public List<clsSolicitud> ListarSolicitudes()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/Solicitudes.svc/ListarSolicitudes");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string solicitudJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<clsSolicitud> solicitudObtenida = js.Deserialize<List<clsSolicitud>>(solicitudJson);
            return solicitudObtenida;
        }
        public List<clsSolicitud> ListarSolicitudesPorEstado(string estado)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:55000/Solicitudes.svc/SolicitudesPorEstado/" + estado);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string solicitudJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<clsSolicitud> solicitudObtenida = js.Deserialize<List<clsSolicitud>>(solicitudJson);
            return solicitudObtenida;
        }
    }
}
