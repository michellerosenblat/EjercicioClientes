using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Datos;
using EjercicioClientes.Entidades;

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

       /* public int InsertarCliente(string nombre, string apellido, string direccion)
        {
            // antes validar con el get si existe ese dni/apellido-nombre
            List<Cliente> result = mapper.TraerTodos();

            Cliente cliente = new Cliente();
            cliente.Apellido = apellido;
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;

            foreach (var item in result)
            {
                if (item.ToString() == cliente.ToString())
                    throw new Exception("El cliente ya existe");
            }

            // ya pasamos las validaciones, persistimos el cliente
            TransactionResult resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
                return resultante.Id;
            //return TraerClientesPorId(resultante.Id);
            else

                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);


        }*/
    }
}
