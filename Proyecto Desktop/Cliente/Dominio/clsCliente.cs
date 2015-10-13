using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitarCambioMoneda.Dominio
{
    public class clsCliente
    {
        public string CodCliente { get; set; }
        
        public string Nombre { get; set; }
        
        public string ApePat { get; set; }
        
        public string ApeMat { get; set; }
        
        public string Direccion { get; set; }
        
        public int Telefono { get; set; }
        
        public string Correo { get; set; }
        
        public string EstadoCivil { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
    }
}
