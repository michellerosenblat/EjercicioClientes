using EjercicioClientes.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
    public class TCMaster : TarjetaCredito
    {

        public TCMaster(int periodoVencimiento, double saldo, string sufijoTarjeta, int idCliente) :
            base((int)TipoTarjetaEnum.Master, periodoVencimiento, saldo, idCliente, sufijoTarjeta)
        {

        }
        public override string GetPrefijo()
        {
            return "3333";
        }
        public override int GetNroDigitos()
        {
            return 16;
        }


    }
}
