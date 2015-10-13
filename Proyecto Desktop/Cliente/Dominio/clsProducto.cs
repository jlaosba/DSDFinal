using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitarCambioMoneda.Dominio
{
    public class clsProducto
    {
        public int codProducto { get; set; }
        public string codCliente { get; set; }
        public double monto { get; set; }
        public int codTipoProducto { get; set; }
        public string tipoMoneda { get; set; }
        public int cuotas { get; set; }
        public double seguroDes { get; set; }
        public double seguroBien { get; set; }
        public DateTime fechaVenc { get; set; }
        public DateTime fechaRegistro { get; set; }
        public double tasaInteres { get; set; }
        public double montoPendiente { get; set; }
    }
}
