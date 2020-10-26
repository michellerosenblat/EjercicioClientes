using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades.Excepciones;

namespace EjercicioClientes
{
    public static class Validacion
    {
        public static int EsInt(string input)
        {
            int nro;
            if (int.TryParse(input, out nro))
            {
                return nro;
            }
            else
            {
                throw new NoEsDatoEsperadoException();
            }
        }
    }
}
