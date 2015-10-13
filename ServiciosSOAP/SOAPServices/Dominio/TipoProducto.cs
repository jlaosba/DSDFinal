using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class TipoProducto
    {
        [DataMember]
        public int CodTipoProducto { get; set; }
        [DataMember]
        public string DescTipoProducto { get; set; }

    }
}