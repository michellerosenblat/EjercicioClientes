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

        public CuentaServicio()
        {
            mapper = new CuentaMapper();
        }
        public List <Cuenta> TraerCuentas()
        {
            return mapper.TraerCuentas();
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
                    mapper.Insert(cuenta);
                }
            }
            else
            {
                throw new CuentaExistenteException(cuenta.Id);
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
