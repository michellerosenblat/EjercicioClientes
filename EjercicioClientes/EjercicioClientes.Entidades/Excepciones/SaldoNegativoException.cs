using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Excepciones
{
    public class SaldoNegativoException : Exception
    {
        public SaldoNegativoException (): base ("El saldo debe ser mayor a cero") { }
    }
}
