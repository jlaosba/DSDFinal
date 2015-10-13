using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil2
    {
        public static string Cadena
        {
            get
            {
                return "Data Source=(local);Initial Catalog=BD_CambioMoneda;Integrated Security=SSPI;";
            }

        }
    }
}