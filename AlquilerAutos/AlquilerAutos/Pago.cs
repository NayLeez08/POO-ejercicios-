using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class Pago
    {
        public string prepago;

        public string PuntoVenta()
        {
            string pVenta = "Punto de venta";
            return pVenta;
        }

        public void Transferencia()
        {
            Console.WriteLine("El metodo de pago es transferencia");
        }

        public void efectivo()
        {
            Console.WriteLine("El metodo de pago es en efectivo");
        }
    }
}
