using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RESTServices.Dominio
{
    [DataContract]
    public class CambioMoneda
    {
        [DataMember]
        public int Producto { get; set; }
        [DataMember]
        public string Cliente { get; set; }
        [DataMember]
        public string MonedaOrigen { get; set; }
        [DataMember]
        public string MonedaCambio { get; set; }
        [DataMember]
        public decimal Monto { get; set; }
        [DataMember]
        public int Cuotas { get; set; }
        [DataMember]
        public DateTime FecVenc { get; set; }
        [DataMember]
        public decimal TasaInteres { get; set; }
        [DataMember]
        public decimal TipoCambio { get; set; }
        [DataMember]
        public string Estado { get; set; }
    }
}
