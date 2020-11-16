using EjercicioClientes.Datos;
using EjercicioClientes.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Negocio
{
    public class TipoPrestamoServicio
    {
        private TipoPrestamoMapper mapper;

        public TipoPrestamoServicio()
        {
            mapper = new TipoPrestamoMapper();
        }
        public List<TipoPrestamo> GetTipoPrestamo()
        {
            return mapper.GetTiposPrestamos();
        }
    }
}
