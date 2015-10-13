using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Cliente
    {
        //[DataMember]
        //public int Codigo { get; set; }
        //[DataMember]
        //public string Nombre { get; set; }
        //[DataMember]
        //public string AppPaterno { get; set; }


        [DataMember]
        public string CodCliente { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ApePat { get; set; }
        [DataMember]
        public string ApeMat { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public int Telefono { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string EstadoCivil { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }

    
    }
}