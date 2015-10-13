using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServidor
{
        public class colaEmail
    {
        public string nombreCliente { get; set; }
        public string correoCliente { get; set; }
        public int codigoSolicitud { get; set; }
        public string tipoMonedaOrigen { get; set; }
        public string tipoMonedaCambio { get; set; }
        public decimal tasaInteres { get; set; }
        public decimal tipoCambio { get; set; }

        public void EnviarCorreo()
        {
            MailMessage Msg = new MailMessage();
            //  Instancia para Manejar el Envio de Archivos      
            SmtpClient SMTP = new SmtpClient();
            //  Uso de SMTP para el envio y codificacion de Archivos
            try
            {
                    string destinatarios;
                    string remitente;
                    string mensaje;
                    string asunto;
                    string SMTPServer;
                    int port;
                    string ccopia;

                    remitente = "d.sanchez.r@hotmail.com";
                    destinatarios = correoCliente;
                    mensaje = "Estimado: Sr(a): " + nombreCliente.ToUpper() + Environment.NewLine +
                              "Su solicitud con código: " + codigoSolicitud.ToString() + " ha sido aprobada." + Environment.NewLine + Environment.NewLine +
                              "Detalle de la Solictud de Cambio de Moneda:" + Environment.NewLine +
                              "Tipo Moneda Origen: " + tipoMonedaOrigen + Environment.NewLine +
                              "Tipo Moneda Cambio:" + tipoMonedaCambio + Environment.NewLine +
                              "Tasa de Interés:" + tasaInteres.ToString() + Environment.NewLine +
                              "Tipo de Cambio:" + tipoCambio.ToString() + Environment.NewLine +
                              "Saludos Cordiales,"
                              ;
                    asunto = "Solicitud Aprobada";
                    SMTPServer = "smtp.live.com";
                    port = 587;
                    Msg.From = new System.Net.Mail.MailAddress(remitente, asunto, System.Text.Encoding.UTF8);

                    if (!string.IsNullOrEmpty(destinatarios))
                    {
                        Msg.To.Add(new System.Net.Mail.MailAddress(destinatarios));
                    }

                    Msg.Subject = asunto;
                    Msg.SubjectEncoding = System.Text.Encoding.UTF8;
                   
                    Msg.Body = mensaje;
                    Msg.BodyEncoding = System.Text.Encoding.Default;
                    Msg.IsBodyHtml = false;
                    SMTP.UseDefaultCredentials = true;
                    SMTP.Port = port;
                    SMTP.Host = SMTPServer;
                    SMTP.EnableSsl = true;
                    SMTP.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    // 'SMTP.Timeout = 50000

                    ////ServicePointManager.ServerCertificateValidationCallback = delegate(
                    ////Object obj, X509Certificate certificate, X509Chain chain,
                    ////SslPolicyErrors errors)
                    ////{
                    ////    return (true);
                    ////};
                    SMTP.EnableSsl = true;
                    SMTP.Credentials = new NetworkCredential("d.sanchez.r@hotmail.com", "ds43767918");
                   
                    SMTP.Send(Msg);

            }
            catch (Exception)
            {
            }

        }

    }

}
