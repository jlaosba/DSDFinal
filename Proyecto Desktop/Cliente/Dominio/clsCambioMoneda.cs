using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitarCambioMoneda.Dominio
{
    public class clsCambioMoneda
    {
        public int Producto { get; set; }
        public string Cliente { get; set; }
        public string MonedaOrigen { get; set; }
        public string MonedaCambio { get; set; }
        public decimal Monto { get; set; }
        public int Cuotas { get; set; }
        public DateTime FecVenc { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal TipoCambio { get; set; }
        public string Estado { get; set; }

    }
}
