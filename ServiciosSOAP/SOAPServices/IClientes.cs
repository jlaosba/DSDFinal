using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    [ServiceContract]
    public interface IClientes
    {
        //[OperationContract]
        //Cliente CrearCliente(string nombre, string appPaterno);
        [OperationContract]
        Cliente ObtenerCliente(string codigo);
        //[OperationContract]
        //Cliente ModificarCliente(int codigo, string nombre, string appPaterno);
        //[OperationContract]
        //void EliminarCliente(int codigo);
        [OperationContract]
        List<Cliente> ListarClientes();
    }
}
