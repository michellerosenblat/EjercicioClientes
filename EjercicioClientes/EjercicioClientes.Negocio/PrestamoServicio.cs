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

        public PrestamoServicio()
        {
            prestamoMapper = new PrestamoMapper();
        }
        public List <Prestamo> GetPrestamos()
        {
           return prestamoMapper.GetPrestamos();
        }
        public void InsertarPrestamo(Prestamo prestamo)
        {
            TransactionResult resultante = prestamoMapper.Insert(prestamo);
            if (!resultante.IsOk)
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
        }
    }
}
