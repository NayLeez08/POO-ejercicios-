// See https://aka.ms/new-console-template for more information
using Herencia;
using System.Net.Http.Headers;

string nombre;
double peso;
int nBigotes;

//Ingresar y mostrar clase gato
Console.WriteLine("------Clase gato------");
Console.Write("Ingresa el nombre del gato: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa el numero de bigotes: ");
nBigotes = int.Parse(Console.ReadLine());

//Instancia de los objetos
//Gato 
Gato gato1 = new Gato(nombre, peso, nBigotes);

Console.WriteLine();
gato1.mostrarGato();

//Cambiando el nombre al gato
gato1.setNombre("Lucifer");
nombre = gato1.getNombre();
Console.WriteLine("\n---Le cambie el nombre al gato----\n");
gato1.mostrarGato();
Console.WriteLine();

Console.WriteLine("------Clase vaca------");
Vaca vaca = new Vaca(n:"Pinta", p:100, l:60);
vaca.mostrarVaca();
vaca.CantidadComida();
Console.WriteLine();

Console.WriteLine("------Clase ballena------");
Ballena ballena = new Ballena(n:"Rayas", p:1000);
ballena.mostrarBallena();