using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Moto : MedioTransporte
    {
        private int canCilindraje250{ get; set; }
        public Moto(string n, int cp, int can, int cc250) : base(n, cp, can)
        {
            this.canCilindraje250 = cc250;
        }

        //Metodos 
        public void mostrarMoto()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Cantidad de motos con cilindraje mayor a 250: " + canCilindraje250);
        }
    }
}
