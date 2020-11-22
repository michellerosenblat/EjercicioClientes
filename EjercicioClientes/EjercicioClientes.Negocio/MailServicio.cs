using EjercicioClientes.Datos;
using EjercicioClientes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Negocio
{
    public class MailServicio
    {
        public static void EnviarMailA(Cliente cliente)
        {
            TransactionResult result = MailMapper.EnviarMailA(cliente);
            if (!result.IsOk)
            {
                throw new Exception("Hubo un error con el servidor " + result.Error);
            }
        }
    }
}
