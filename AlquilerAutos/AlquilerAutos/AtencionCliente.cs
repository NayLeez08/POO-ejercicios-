using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class AtencionCliente
    {
        public int IdEmpresa;

        public AtencionCliente(int idEmpresa)
        {
            this.IdEmpresa = idEmpresa;
        }

        public int Atencion(int b)
        {
            int opcion = b;
            int reserva = 0;
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Telefonica");
                    reserva = b;
                    break;
                case 1:
                    Console.WriteLine("Online");
                    reserva = b;
                    break;
                case 2:
                    Console.WriteLine("Prsencial");
                    reserva = b;
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            return reserva;
        }
    }
}
