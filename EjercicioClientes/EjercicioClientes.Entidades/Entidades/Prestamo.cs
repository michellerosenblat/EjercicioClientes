using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
   public class Prestamo
    {
        private TipoPrestamo tipoPrestamo;
        private int plazo;
        private double monto;
        private string usuario;
        private int idCliente;

        public Prestamo(TipoPrestamo tipoPrestamo, double monto, int plazo)
        {
            this.tipoPrestamo = tipoPrestamo;
            this.monto = monto;
            this.plazo = plazo;
        }
        public Prestamo(TipoPrestamo tipoPrestamo, double monto, int plazo, int idCliente)
        {
            this.tipoPrestamo = tipoPrestamo;
            this.monto = monto;
            this.plazo = plazo;
            this.idCliente = idCliente;
        }
        public TipoPrestamo TipoPrest
        {
            get
            {
                return this.tipoPrestamo;
            }
            set
            {
                this.tipoPrestamo = value;
            }
        }
        public int Plazo
        {
            get
            {
                return this.plazo;
            }
            set
            {
                this.plazo = value;
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
        public double Monto
        {
            get
            {
                return this.monto;
            }
            set
            {
                this.monto = value;
            }
        }
        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }
        public double CuotaCapital()
        {
            return monto / plazo;
        }
        public double CuotaInteres()
        {
            return CuotaCapital() * (tipoPrestamo.TNA * 100 / 12);
        }
        public double Cuota()
        {
            return CuotaCapital() + CuotaInteres();
        }
    }
}
