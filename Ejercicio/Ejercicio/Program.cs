// See https://aka.ms/new-console-template for more information
using Ejercicio;
 
Persona persona = new Persona(); //Instanciar Objeto, sin parametros
Persona persona2 = new Persona("Nay", "nayleal42@gmail.com", "16 sur num.1101", 246197095, 2005, 68, 160); //Parametros al instanciar un objeto

Console.WriteLine(persona2.nombre + " " + persona2.correo + " " + persona2.direccion + " " + persona2.telefono);

persona2.CalculaEdad();

Console.WriteLine(persona2.edad);
Console.WriteLine("Este es el metodo 2: " + persona2.CalculaEdad2());
persona2.CalculaEdad3();
Console.WriteLine("Este es el metodo 4: " + persona2.CalculaEdad4(persona2.añoNacimiento));
//Indice de masa corporal
persona2.peso = 68;
persona2.estatura = 1.60;
Console.WriteLine("Este es el metodo de masa corporal: " + persona2.IMC());