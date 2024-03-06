using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class CuentaBancaria
    {
        //Atributos
        private int IDcuenta;

        private CuentaBancaria(int cuentaB)
        {
            this.IDcuenta = cuentaB;
        }

        protected string Nombre()
        {
            string nombreC = "Pedro";
            Console.WriteLine("Ingrese su nombre: ");
            return nombreC;
        }

        protected int NumCuenta()
        {
            int NumCuenta = 01;
            Console.WriteLine("Ingrese su numero de cuenta: ");
            return NumCuenta;
        }
        protected int Saldo()
        {
            int saldo = 1500;
            Console.WriteLine("Su saldo es: ");
            return saldo;
        }
        private string Movimiento()
        {
            string movi = "";
            Console.WriteLine("Se realizo el movimiento");
            return movi;
        }
    }
}
