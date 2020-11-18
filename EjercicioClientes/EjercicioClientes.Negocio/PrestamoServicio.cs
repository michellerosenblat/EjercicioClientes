using EjercicioClientes.Datos;
using EjercicioClientes.Entidades;
using EjercicioClientes.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Negocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper prestamoMapper;
        private List<Prestamo> cachePrestamos;
        public PrestamoServicio()
        {
            prestamoMapper = new PrestamoMapper();
        }
        private void RefrescarCache()
        {
            cachePrestamos = prestamoMapper.GetPrestamos();

        }
        public List <Prestamo> GetPrestamos()
        {
            return cachePrestamos;
        }
        public void InsertarPrestamo(Prestamo prestamo)
        {
            TransactionResult resultante = prestamoMapper.Insert(prestamo);
            if (!resultante.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
            }
            else
            {
                RefrescarCache();
            }
                
        }
    }
}
