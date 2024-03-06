using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Banco
    {
        //Atributos
        private string nombreB;

        private Banco(string NomBan)
        {
            this.nombreB = NomBan;
        }

        public int Cuenta()
        {
            int idCuenta = 01;
            Console.WriteLine("Ingrese el ID de la cuenta: ");
            return idCuenta;
        }
    }
}
