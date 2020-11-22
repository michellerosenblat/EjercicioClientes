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
    public class CuentaServicio
    {
        private CuentaMapper mapper;
        private List<Cuenta> cacheCuentas;
        public CuentaServicio()
        {
            mapper = new CuentaMapper();
            RefrescarCache();
        }
        public List <Cuenta> TraerCuentas()
        {
            return cacheCuentas.OrderBy(order => order.IdCliente).ToList();
        }
        public void RefrescarCache()
        {
            cacheCuentas = mapper.TraerCuentas();
        }
        public void IngresarCuenta (Cuenta cuenta)
        {
            if (!ExisteLaCuenta(cuenta))
            {
                TransactionResult result = mapper.Insert(cuenta);
                if (!result.IsOk)
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + result.Error);
                else
                {
                    RefrescarCache();
                }
            }
            else
            {
                throw new CuentaExistenteException(cuenta.Id);
            }
        }
        public void ActualizarSaldoDe (Cuenta cuenta, int saldoAModificar)
        {
            if (saldoAModificar < 0)
            {
                throw new SaldoNegativoException();
            }
            cuenta.Saldo = saldoAModificar;
            TransactionResult t = mapper.ModificarSaldoDe(cuenta);
            if (!t.IsOk)
            {
                throw new Exception("Error al modificar el saldo de la cuenta. " + t.Error);
            }
        }
        public bool ExisteLaCuenta(Cuenta cuenta)
        {
            List<Cuenta> cuentas = TraerCuentas();
            return cuentas.Any(c => c.Equals(cuenta));
        }
        public int ProximoId()
        {
            List<Cuenta> c = TraerCuentas();
            return c.Max(cuenta => cuenta.Id) + 1;
        }
        public int ProximoIdCuenta()
        {
            List<Cuenta> c = TraerCuentas();
            return c.Max(cuenta => cuenta.NroCuenta) + 1;
        }
    }
}
