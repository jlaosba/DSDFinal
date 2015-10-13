using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;

namespace SOAPServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO clienteDAO = null;

        private ClienteDAO ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteDAO();
                return clienteDAO;
            }

        }

        //public Cliente CrearCliente(string nombre, string appPaterno)
        //{
        //    Cliente clienteACrear = new Cliente()
        //    {
        //        Nombre = nombre,
        //        AppPaterno = appPaterno
        //    };
        //    return ClienteDAO.Crear(clienteACrear);
        //}

        public Cliente ObtenerCliente(string codigo)
        {
            return ClienteDAO.Obtener(codigo);
        }

        //public Cliente ModificarCliente(int codigo, string nombre, string appPaterno)
        //{
        //    Cliente clienteAModificar = new Cliente()
        //    {
        //        Codigo = codigo,
        //        Nombre = nombre,
        //        AppPaterno = appPaterno
        //    };
        //    return ClienteDAO.Modificar(clienteAModificar);
        //}

        //public void EliminarCliente(int codigo)
        //{
        //    Cliente clienteExistente = ClienteDAO.Obtener(codigo);
        //    ClienteDAO.Eliminar(clienteExistente);
        //}

        public List<Cliente> ListarClientes()
        {
            return ClienteDAO.ListarTodos().ToList();
        }
    }
}
