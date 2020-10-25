using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Excepciones
{
    public class ClienteExistenteException : Exception
    {
        public ClienteExistenteException(int id) : base("Ya existe el cliente con id " + id) { }
    }
}
