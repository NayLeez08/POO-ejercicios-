// See https://aka.ms/new-console-template for more information

using Ejercicio3;

string nombre;
int can;
int cG;
int cGas;
int canCilindraje250;

Console.WriteLine("------Clase Vehiculos------");
Console.Write("Ingresa el nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Ingresa datos del vehiculo: ");

Console.Write("Ingresar la cantidad que ingresa al dia: ");
can = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de vehiculos a gas: ");
cG = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de vehiculos a gasolina: ");
cGas = int.Parse(Console.ReadLine());
Vehiculo vehiculo1 = new Vehiculo(n:"Tipo vehiculo", cp:5, can:1800, cG:200, canGas: 1600);

Console.WriteLine("------Clase Moto------");
Console.WriteLine("Ingresa datos de la moto: ");
Console.Write("Ingresar la cantidad que ingresa al dia: ");
can = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de motos con cilindraje mayor a 250: ");
canCilindraje250 = int.Parse(Console.ReadLine());
Moto moto1 = new Moto(n:"Tipo Moto", cp: 2, can: 120, cc250:120);

MedioTransporte medioT = new MedioTransporte(n:"Nayeli", cp:10, can:120);

medioT.mostrarMedioTransporte();
vehiculo1.mostrarVehiculo();
moto1.mostrarMoto();

int cantP = (vehiculo1.CalcularPersonas(5) + moto1.CalcularPersonas(2));
Console.WriteLine("Cantidad maxima de personas: " + cantP);
