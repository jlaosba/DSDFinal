using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitarCambioMoneda.Dominio
{
    public class clsSolicitud
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Producto { get; set; }
    }
}
