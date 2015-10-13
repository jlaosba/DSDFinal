using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Solicitud
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Cliente { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public int Producto { get; set; }

    }
}