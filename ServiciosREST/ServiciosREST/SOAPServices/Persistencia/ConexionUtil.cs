using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=DAVID-HP\\MSSQLSERVER2012;Initial Catalog=BD_CambioMoneda;Integrated Security=SSPI;";
        }
    }
}