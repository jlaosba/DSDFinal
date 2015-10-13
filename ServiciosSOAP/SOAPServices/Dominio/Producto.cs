using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        public int codProducto { get; set; }
        [DataMember]
        public string codCliente { get; set; }
        [DataMember]
        public double monto { get; set; }
        [DataMember]
        public int codTipoProducto { get; set; }
        [DataMember]
        public string tipoMoneda { get; set; }
        [DataMember]
        public int cuotas { get; set; }
        [DataMember]
        public double seguroDes { get; set; }
        [DataMember]
        public double seguroBien { get; set; }
        [DataMember]
        public DateTime fechaVenc { get; set; }
        [DataMember]
        public DateTime fechaRegistro { get; set; }
        [DataMember]
        public double tasaInteres { get; set; }
        [DataMember]
        public double montoPendiente { get; set; }
    }
}