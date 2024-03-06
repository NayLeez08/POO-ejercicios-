using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vaca : Mamifero
    {
        //Atributos
        private int litrosLeche { get; set; }
        public double totalcantidad;

        public Vaca(string n, double p, int l) : base(n, p)
        {
            this.litrosLeche = l;
        }
        public void CantidadComida()
        {
            double cantidad = 0;
            cantidad = peso/litrosLeche;
            Console.WriteLine("El total de comida que tiene que dar en Kg es: " + cantidad);
        }

        //Metodos 
        public void mostrarVaca()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su peso en Kg es de: " + peso);
            Console.WriteLine("Tiene " + litrosLeche + "  litros de leche");
        }
    }
}
