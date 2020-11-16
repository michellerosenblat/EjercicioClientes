using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades;
using Newtonsoft.Json;

namespace EjercicioClientes.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerCuentas()
        {
            string json2 = WebHelper.Get("/cuenta");
            return MapList(json2);
        }
        private List<Cuenta> MapList(string json)
        {
            //devuelve el json deserializado
            return JsonConvert.DeserializeObject<List<Cuenta>>(json);
        }

        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string result = WebHelper.Post("/cuenta", obj);
            return MapResultado(result);
            //devuelve el resultado de la transaccion
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());
            //n.Add("FechaApertura", cuenta.FechaApertura.ToShortDateString()); // DateTime
            //n.Add("FechaModificacion", cuenta.FechaModificacion.ToShortDateString()); // DateTime
            n.Add("Activo", cuenta.Activo.ToString()); // bool
            n.Add("idCliente", cuenta.IdCliente.ToString()); // STRING
            //n.Add("id", cuenta.Id.ToString()); // INT
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
            //devuelve el resultado
        }
    }
}
