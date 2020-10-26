using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Excepciones
{
    public class NoEsDatoEsperadoException : Exception
    {
        public NoEsDatoEsperadoException () : base ("No es el dato esperado"){}
    }
}
