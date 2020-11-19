using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
    public class TipoPrestamo
    {
        private string linea;
        private double tna;

        public TipoPrestamo()
        {

        }
        public TipoPrestamo(double tna, string linea)
        {
            this.tna = tna;
            this.linea = linea;
        }
        public string Linea
        {
            get
            {
                return this.linea;
            }
            set
            {
                this.linea = value;
            }
        }
        public double TNA
        {
            get
            {
                return this.tna;
            }
            set
            {
                this.tna = value;
            }
        }
        public override string ToString()
        {
            return linea + " TNA: " + tna + "%";
        }
    }
}
