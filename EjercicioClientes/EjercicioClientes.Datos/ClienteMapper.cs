using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades;
using System.Configuration;

namespace EjercicioClientes.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/cliente/888593"); // trae un texto en formato json de una web
            return MapList(json2);
            //devuelve toda la lista de clientes
        }
        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/cliente", obj);
            return MapResultado(result);
            //devuelve el resultado de la transaccion
        }
        public TransactionResult Update (Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Put("/cliente", obj);
            return MapResultado(result);
        }
        private List<Cliente> MapList(string json)
        {
            //devuelve el json deserializado
            return JsonConvert.DeserializeObject<List<Cliente>>(json);
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Email", cliente.Email); // STRING
            n.Add("Telefono", cliente.Telefono.ToString()); // INT
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToShortDateString()); // DateTime
            n.Add("Activo", cliente.Activo.ToString()); // bool
            n.Add("id", cliente.ID.ToString());
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
           return JsonConvert.DeserializeObject<TransactionResult>(json);
            //devuelve el resultado
        }
    }
}
