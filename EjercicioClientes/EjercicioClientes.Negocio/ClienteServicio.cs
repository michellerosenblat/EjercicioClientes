using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Datos;
using EjercicioClientes.Entidades;
using EjercicioClientes.Entidades.Excepciones;

namespace EjercicioClientes.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            return mapper.TraerTodos();
        }

        public Cliente TraerClientesPorId(int id)
        {
            List<Cliente> result = mapper.TraerTodos();
            Cliente cli = null;
            foreach (Cliente c in result)
            {
                if (c.ID == id)
                    cli = c;
            }
            return cli;

        }

        public bool ExisteElCliente (Cliente cliente)
        {
            List<Cliente> clientes = TraerClientes();
           return clientes.Any(c => c.Equals(cliente));
        }

        public void InsertarCliente(Cliente cliente)
        {
           if (ExisteElCliente(cliente))
            {
                throw new ClienteExistenteException(cliente.ID);
            }
           else
            {
                TransactionResult resultante = mapper.Insert(cliente);
                if (!resultante.IsOk)
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
                

                    
            }

        }
        public int ProximoId()
        {
            List<Cliente> c = TraerClientes();
            return c.Max(cliente => cliente.ID) + 1;
        }
    }
}
