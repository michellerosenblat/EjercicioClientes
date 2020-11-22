using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string ValidarMail(string email)
        {
            string error = "El texto ingresado no es mail válido "+"\n";
            if (string.IsNullOrWhiteSpace(email))
                return error;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return error;
            }
            catch (ArgumentException)
            {
                return error;
            }

            try
            {
                if (Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    return "";
                }
                else
                {
                    return error;
                }
                
            }
            catch (RegexMatchTimeoutException)
            {
                return error;
            }
        }
    }
}

