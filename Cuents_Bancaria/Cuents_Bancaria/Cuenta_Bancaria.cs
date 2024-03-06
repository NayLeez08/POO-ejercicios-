using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuents_Bancaria
{
    internal class Cuenta_Bancaria
    {
        public string dueño;
        public int numCuenta;
        public int claveCuenta;

        public Cuenta_Bancaria(string dueño, int cuenta, int clave)
        {
            this.dueño = dueño;
            this.numCuenta = cuenta;
            this.claveCuenta = clave;
        }

        public int Operacion(int a)
        {
            int opcion = a;
            int reserva = 0;
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Retirar");
                    reserva = a;
                    break;
                case 1:
                    Console.WriteLine("Depositar");
                    reserva = a;
                    break;
                case 2:
                    Console.WriteLine("Consultar");
                    reserva = a;
                    break;
                case 3:
                    Console.WriteLine("Otras");
                    reserva = a;
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            return reserva;
        }
    }
}
