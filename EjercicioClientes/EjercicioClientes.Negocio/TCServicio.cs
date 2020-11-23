using EjercicioClientes.Datos;
using EjercicioClientes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Negocio
{
    public static class TCServicio
    {
        public static void Insertar (TarjetaCredito tc)
        {
            TransactionResult result = TCMapper.Insert(tc);
            if (!result.IsOk)
            {
                throw new Exception("Hubo un problema con la peticion " + result.Error);
            }
        }
        public static List <TarjetaCredito> TraerTarjetas()
        {
            return TCMapper.GetTarjetas();
        }
        public static int ProximoNroTarjeta()
        {
            List<TarjetaCredito> tarjetas = TCMapper.GetTarjetas().OrderByDescending(c => c.NroPlastico).ToList();
            if (!tarjetas.Any())
            {
                return 0;
            }
            else
            {
                string nroPlastico = tarjetas.First().NroPlastico;
                return int.Parse(nroPlastico.Substring(3, nroPlastico.Length - 1));
            }
            
         
        }
    }
}
