using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Ballena : Mamifero
    {
        private int ballena { get; set; }
        public Ballena(string n, double p) : base(n, p)
        {

        }
        public void mostrarBallena()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su peso en Kg es de: " + peso);
        }
    }
}
