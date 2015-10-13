using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServidor
{
    public class Servidor
    {
        public static void Main(string[] args)
        {
            string rutaCola = @".\private$\dsanchez";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);

                MessageQueue cola = new MessageQueue(rutaCola);


                int x = cola.GetAllMessages().Count();

                if (x > 0)
                {
                    while (x > 0)
                    {

                        cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(colaEmail) });
                        Message mensaje = cola.Receive();
                        colaEmail colaEmailCliente = (colaEmail)mensaje.Body;

                        colaEmail emailCliente = new colaEmail();
                        emailCliente.nombreCliente = colaEmailCliente.nombreCliente;
                        emailCliente.correoCliente = colaEmailCliente.correoCliente;
                        emailCliente.codigoSolicitud = colaEmailCliente.codigoSolicitud;
                        emailCliente.tipoMonedaOrigen = colaEmailCliente.tipoMonedaOrigen;
                        emailCliente.tipoMonedaCambio = colaEmailCliente.tipoMonedaCambio;
                        emailCliente.tasaInteres = colaEmailCliente.tasaInteres;
                        emailCliente.tipoCambio = colaEmailCliente.tipoCambio;

                        //Realiza el envío de Correo
                        emailCliente.EnviarCorreo();

                        x -= 1;

                    }


                }
               
        }
       

    }
}
