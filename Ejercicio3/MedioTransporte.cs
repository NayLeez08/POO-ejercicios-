using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class MedioTransporte
    {
        protected string nombre { get; set; }
        protected int capacidadPasajeros { get; set; }
        protected int cantidad { get; set; }

        //Constructor
        public MedioTransporte(string n, int cp, int can)
        {
            this.nombre = n;
            this.capacidadPasajeros = cp;
            this.cantidad = can;  
        }

        //Metodos
        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int CalcularPersonas(int personas)
        {
            personas= (capacidadPasajeros * cantidad);
            return personas;
        }
        public void mostrarMedioTransporte()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Capacidad de pasajeros: " + capacidadPasajeros);
            Console.WriteLine("Cantidad que ingresan al dia: " + cantidad);
        }
    }
}
