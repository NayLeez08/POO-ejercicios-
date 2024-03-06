using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Fecha
    {
        public int dia;
        public int mes;
        public int año;

        public Fecha()
        {
            this.dia = 08;
            this.mes = 2;
            this.año = 2023;
        }
        public Fecha(int dia, int mes, int año)
        {
            this.dia = dia;
            this.mes = mes;
            this.año = año;
        }
        public void ModificarFecha(int dia, int mes, int año)
        {
            int di = 02;
            int me =2;
            int a = 2024;
        }
        public void MostrarFecha(int dia, int mes, int año)
        {
            int di = 02;
            int me = 2;
            int a = 2024;
            Console.WriteLine("El dia es " + di + " mes " + me + " año " + a);
        }
        public void FechaMesPalabras(int dia, string mes, int año)
        {
             int di = 02;
             string me = "Febrero";
             int a = 2024;
             Console.WriteLine("El dia es " + di + " mes " + me + " año " + a);
        }
    }
}
