using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades.Entidades
{
    public static class Operador
    {
        private static int comision;
        private static double porcentajeComision;

        static Operador()
        {
            porcentajeComision = 0.15;
        }
        public static double CalcularComisionDe (List <Prestamo> prestamos)
        {
            return prestamos.Sum(p => p.InteresTotal()) * porcentajeComision;
        }
           
        }
        
      
    }

