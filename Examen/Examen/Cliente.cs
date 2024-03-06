using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Cliente
    {
        //Atributos
        public string Nombre;
        private int numCuenta;
        public int Saldo;


        public Cliente(string NomC, int numCuenta, int Saldo)
        {
            this.Nombre = NomC;
            this.numCuenta = numCuenta;
            this.Saldo = Saldo;
        }

        public string SolicitarOperacion()
        {
            string operacion = "";
            Console.WriteLine("Solicitar operacion");
            return operacion;
        }
    }
}
