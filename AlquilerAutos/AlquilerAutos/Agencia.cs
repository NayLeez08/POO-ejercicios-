using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class Agencia
    {
        //Atributos
        public string nombreEmpresa;
        public int telefono;
        public int NumCuentaBancaria;

        //Contructor 
        public Agencia()
        {

        }

        //Metodo
        public void AlquilerAutos()
        {
            Console.WriteLine("Estas llamando al metodo alquiler de autos");
        
        }
    }
}
