using EjercicioClientes.Entidades;
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
    public static class TCMapper
    {
        public static TransactionResult Insert(TarjetaCredito tc)
        {
            string result = WebHelper.Post("/tarjetacredito", ReverseMap(tc));
            return MapResult(result);
        }
        public static NameValueCollection ReverseMap(TarjetaCredito tc)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Tipo", tc.TipoTarjeta.ToString());
            n.Add("PeriodoVencimiento", tc.PeriodoVencimiento.ToString());
            n.Add("LimiteCompra", tc.LimiteCompra.ToString());
            n.Add("NroPlastico", tc.NroPlastico);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("idCliente", tc.IdCliente.ToString());
            return n;
        }
        public static TransactionResult MapResult(string result)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(result);
        }
        public static List<TarjetaCredito> GetTarjetas()
        {
            string result = WebHelper.Get("/tarjetacredito/" + ConfigurationManager.AppSettings["Legajo"]);
            return MapList(result);
        }
        public static List<TarjetaCredito> GetTarjetas(int idCliente)
        {
            string result = WebHelper.Get("/tarjetacredito/" + ConfigurationManager.AppSettings["Legajo"] + "/"+idCliente);
            return MapList(result);
        }
        public static List <TarjetaCredito> MapList(string result)
        {
            return JsonConvert.DeserializeObject<List<TarjetaCredito>>(result);
        }
    }
}
