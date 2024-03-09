using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Vehiculo : MedioTransporte
    {
        //Atributos
        private double cantidadGas { get; set; }
        private double cantidadGasolina { get; set; }
        public Vehiculo(string n, int cp, int can, double cG, double canGas) : base(n, cp, can)
        {
            this.cantidadGas = cG;
            this.cantidadGasolina = canGas;
        }

        //Metodos 
        public void mostrarVehiculo()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Cantidad de vehiculos a gas: " + cantidadGas);
            Console.WriteLine("Cantidad de vehiculos a gasolina: " + cantidadGasolina);
        }
    }
}
