using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
    public class Operador
    {
        private List<Prestamo> prestamos;
        private double comision;
        private double porcentajeComision;

        public Operador()
        {
            prestamos = new List<Prestamo>();
            CalcularPorcentajeComision();
        }
        public void CalcularPorcentajeComision()
        {
            double interes = 0;
            foreach (Prestamo prestamo in prestamos)
            {
                interes += prestamo.CuotaInteres();
            }
            porcentajeComision= interes * 0.15;
        }
        public double PorcentajeComision
        {
            get
            {
                return this.porcentajeComision;
            }
        }
    }
}
