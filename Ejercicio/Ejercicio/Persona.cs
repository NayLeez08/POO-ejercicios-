using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Persona
    {
        //Variables (Atributos)
        public string nombre;
        public string correo;
        public string direccion;
        public int telefono;
        public int añoNacimiento;
        public int edad;
        public double peso;
        public double estatura;

        //Constructor sin parametros
        public Persona()
        {
            nombre = "Nayeli";
            correo = "nayeleal42@gmail.com";
            direccion = "16 sur num.1101";
            telefono = 246197095;
        }

        //Constructor con parametros
        public Persona(string nombre, string correo, string direccion, int telefono, int añoNacimiento, double peso, double estatura)
        {
            this.nombre = nombre; //this hace referencia al atributo
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.añoNacimiento = añoNacimiento;
            this.peso = peso;
            this.estatura = estatura;
        }

        //Metodos
        public void CalculaEdad()
        {
            edad = 2024 - añoNacimiento;
        }

        //Al ageegar un tipo de dato, restringimos el tipo de dato a devolver
        public int CalculaEdad2()
        {
            int edad2;
            edad2 = 2024 - añoNacimiento;
            return edad2;
        }

        //Vamos a imprimir el texto en el mismo metodo
        public void CalculaEdad3()
        {
            int edad3;
            edad3 = 2024 - añoNacimiento;
            Console.WriteLine("Este es el metodo 3: " + edad3);
        }

        //Metodos con parametros
        public int CalculaEdad4(int añoNacimiento)
        {
            int nacimiento = añoNacimiento;
            int edad4;
            edad4= 2024 - nacimiento;
            return edad4;
        }

        //Agregar un metodo que calcule la masa corporal
        //IMS =Peso en KG/ Estatura en metros
        public double IMC()
        {
            double IMCmasa;
            IMCmasa = peso / estatura;
            return IMCmasa;
        }

    }
}
