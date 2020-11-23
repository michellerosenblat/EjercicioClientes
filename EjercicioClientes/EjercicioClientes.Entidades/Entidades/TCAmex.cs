using EjercicioClientes.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
    public class TCAmex : TarjetaCredito
    {

        public TCAmex(int periodoVencimiento, double saldo, string sufijoTarjeta, int idCliente) :
            base((int)TipoTarjetaEnum.Amex, periodoVencimiento, saldo, idCliente, sufijoTarjeta)
        {

        }
        public override string GetPrefijo()
        {
            return "4321";
        }
        public override int GetNroDigitos()
        {
            return 15;
        }




    }
}
