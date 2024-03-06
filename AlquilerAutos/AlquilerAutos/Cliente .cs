using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class Cliente
    {
        //Atributos (variables o constantes)
        private int  IDusuario;
        private string DaBancarios;
        private string Direccion;
        private int Telefono;

        //Constructor parametros
        public Cliente(int idUsu, string DaBancarios, string Direccion, int Tel)
        {
            this.IDusuario = idUsu;
            this.DaBancarios = DaBancarios;
            this.Direccion = Direccion;
            this.Telefono = Tel;
        }

        //Metodo
        public int Reservacion(int a)
        {
            int opcion = a;
            int reserva = 0;
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Telefonica");
                    reserva = a;
                    break;
                case 1:
                    Console.WriteLine("Online");
                    reserva = a;
                    break;
                case 2:
                    Console.WriteLine("Prsencial");
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
