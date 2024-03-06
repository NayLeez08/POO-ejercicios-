using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Cajero
    {
        //Atributos
        public int IdCajero;

        public Cajero(int idCajero)
        {
            this.IdCajero = idCajero;
        }

        public int Reserva(int a)
        {
            int opcion = a;
            int reserva = 0;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Retirar");
                    reserva = a;
                    break;
                case 2:
                    Console.WriteLine("Depositar");
                    reserva = a;
                    break;
                case 3:
                    Console.WriteLine("Consultar saldo");
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
