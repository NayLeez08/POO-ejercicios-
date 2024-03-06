using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class Reservacion
    {
        public string modeloAuto;
        public string marca;
        public string color;
        private string matricula;
        public bool disponibilidad;

        public Reservacion(string modeloAuto, string marca, string color, string matricula, bool disponibilidad)
        {
            this.modeloAuto = modeloAuto;
            this.marca = marca;
            this.color = color;
            this.matricula = matricula;
            this.disponibilidad = disponibilidad;
        }
        public double TiempoAlquiler()
        {
            double tiempoAlquiler = 3;
            Console.WriteLine("Tiempo de alquiler");
            return tiempoAlquiler;
        }

        public int DiasAlquiler()
        {
            int diasAlquiler = 3;
            return diasAlquiler;
        }

        public string FechaEntrega()
        {
            string fecha = "Fecha de entrega";
            Console.WriteLine("La fecha de entrega es: ");
            return fecha;
        }
    }
}