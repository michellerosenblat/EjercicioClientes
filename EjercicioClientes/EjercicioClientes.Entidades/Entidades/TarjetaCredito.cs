using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public  class TarjetaCredito
    {
        protected int tipoTarjeta;
        protected int periodoVencimiento;
        protected double limiteCompra;
        protected string nroPlastico;
        protected int idCliente;
        private string prefijoNroTarjeta;
        private int nroDigitos;
        public TarjetaCredito(int tipoTarjeta, int periodoVencimiento, double saldo, int idCliente, string sufijoTarjeta)
        {
            this.tipoTarjeta = tipoTarjeta;
            this.periodoVencimiento = periodoVencimiento;
            this.limiteCompra = saldo*18;
            this.idCliente = idCliente;
            this.nroPlastico = FormatearNroTarjeta(sufijoTarjeta);
        }
        public int TipoTarjeta
        {
            get
            {
                return this.tipoTarjeta;
            }
            set
            {
                this.tipoTarjeta = value;
            }
        }
        public int PeriodoVencimiento
        {
            get
            {
                return this.periodoVencimiento;
            }
            set
            {
                this.periodoVencimiento = value;
            }
        }
        public double LimiteCompra
        {
            get
            {
                return this.limiteCompra;
            }
            set
            {
                this.limiteCompra = value;
            }
        }
        public string NroPlastico
        {
            get
            {
                return this.nroPlastico;
            }
            set
            {
                this.nroPlastico = value;
            }
        }

 
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        private  string SufijosConCerosALaIzq(string sufijoTarjeta)
        {
            return (sufijoTarjeta.PadLeft(GetNroDigitos() - GetPrefijo().Length, '0'));
        }
        public string FormatearNroTarjeta(string sufijoTarjeta)
        {
            return GetPrefijo() + SufijosConCerosALaIzq(sufijoTarjeta);
        }
        //esta hecho así porque lo habia pensado abstracto y no se puede.
        public virtual string GetPrefijo() {
            return "";
        }
        public virtual int GetNroDigitos() {
            return 0;
        }
        

    }
    
}
