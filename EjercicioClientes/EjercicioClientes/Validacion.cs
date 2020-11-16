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
        public static string ValidarNumero(string input, string campoEsperado)
        {
            int nro;
            string error = "";
            if (!int.TryParse(input, out nro))
            {
                error = campoEsperado + " debe ser numérico" + "\n";
            }
            else if (nro < 0)
            {
                error = campoEsperado + " debe ser positivo" + "\n";
            }
            return error;
        }
        public static string ValidarString(string input, string campoEsperado)
        {
            string error = "";
            if (input == "")
            {
                error = campoEsperado + " no puede ser vacío" + "\n";
            }
            return error;
        }
        public static string ValidarComboBox(int num, string campoEsperado)
        {
            string error = "";
            if (num == -1)
            {
                error = "Seleccione un " + campoEsperado + "\n";
            }
            return error;
        }
    }
}
