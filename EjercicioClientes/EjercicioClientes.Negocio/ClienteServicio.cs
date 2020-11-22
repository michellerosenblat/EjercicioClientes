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
        private CuentaServicio cuentaServicio;
        private static List<Cliente> cacheClientes;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
            cuentaServicio = new CuentaServicio();
            RefrescarCache();
        }

        public List<Cliente> TraerClientes()
        {
            return cacheClientes;
        }
        public void RefrescarCache()
        {
            cacheClientes = mapper.TraerTodos();
            AsignarCuentasAClientes();
        }
        public void AsignarCuentasAClientes()
        {
            List<Cuenta> cuentas = cuentaServicio.TraerCuentas();
            cacheClientes.ForEach(c => c.Cuenta = cuentas.FirstOrDefault(x => x.IdCliente == c.ID));
        }
        public List <Cliente> TraerClientesConCuenta()
        {
            return cacheClientes.Where(c => c.Cuenta != null).ToList();
        }
        public Cliente TraerClientesPorId(int id)
        {
            List<Cliente> result = mapper.TraerTodos();
            return result.SingleOrDefault(c => c.ID == id);

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
                {
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
                }
                else
                {
                    RefrescarCache();
                }     
            }
        }
        public void Update(Cliente cliente)
        {
            TransactionResult result = mapper.Update(cliente);
            if (!result.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + result.Error);
            }
            else
            {
                RefrescarCache();
            }
        }
        public int ProximoId()
        {
            List<Cliente> c = TraerClientes();
            return c.Max(cliente => cliente.ID) + 1;
        }
    }
}
