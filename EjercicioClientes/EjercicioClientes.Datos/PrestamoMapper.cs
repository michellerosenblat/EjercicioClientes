using EjercicioClientes.Entidades;
using EjercicioClientes.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Datos
{
    public class PrestamoMapper
    {
        public List<Prestamo> GetPrestamos()
        {
            string json = WebHelper.Get("./prestamo/" +ConfigurationManager.AppSettings["Legajo"]);
            return MapList(json);
        }
        public List<Prestamo> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<Prestamo>>(json);
        }
        private TransactionResult MapResultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        public TransactionResult Insert (Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string result = WebHelper.Post("/cliente", obj);
            return MapResultado(result);

        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("TNA", prestamo.TipoPrest.TNA.ToString());
            n.Add("Linea", prestamo.TipoPrest.Linea);
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("Monto", prestamo.Monto.ToString());
            n.Add("Cuota", prestamo.Cuota().ToString()) ;
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }

    }
}
