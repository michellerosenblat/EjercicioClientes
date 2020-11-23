using EjercicioClientes.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
    public class TCVisa : TarjetaCredito
    {

        public TCVisa (int periodoVencimiento, double saldo, string sufijoTarjeta, int idCliente) : 
            base ((int)TipoTarjetaEnum.Visa, periodoVencimiento,  saldo,   idCliente, sufijoTarjeta)
        {

        }
        public override string GetPrefijo()
        {
            return "1234";
        }
        public override int GetNroDigitos()
        {
            return 16;
        }

    }
}
