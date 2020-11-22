using EjercicioClientes.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Datos
{
    public static class MailMapper
    {
        public static TransactionResult EnviarMailA(Cliente cliente)
        {
            string result = WebHelper.Post("/Utilidades", ReverseMap(cliente));
            return MapResult(result);
        }
        public static TransactionResult MapResult (string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult> (json);
        }
        public static NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Para", cliente.Email);
            n.Add("Asunto", "Modificacion de cuenta");
            n.Add("Mensaje", "Se ha modificado la cuenta de " + cliente.Nombre + "\n" + ". Su saldo actual es: " + cliente.Cuenta.Saldo);
            return n;
        }
    }
}
