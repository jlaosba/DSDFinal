using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitarCambioMoneda.Dominio
{
    public class colaEmail
    {
        public string nombreCliente { get; set; }
        public string correoCliente { get; set; }
        public int codigoSolicitud { get; set; }
        public string tipoMonedaOrigen { get; set; }
        public string tipoMonedaCambio{ get; set; }
        public decimal tasaInteres { get; set; }
        public decimal tipoCambio { get; set; }
    }
}
