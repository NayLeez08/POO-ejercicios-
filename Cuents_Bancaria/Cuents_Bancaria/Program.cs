// See https://aka.ms/new-console-template for more information
using Cuents_Bancaria;

Cuenta_Bancaria cuenta_Bancaria = new Cuenta_Bancaria("Nayeli", 023, 125647);

int opcionReservacion = 0;
cuenta_Bancaria.Operacion(1);
Console.WriteLine("Ingrese la operacion a realizar: \n" +
                    "0.- Retirar. \n" +
                    "1.- Depositar. \n" +
                    "2.- Consultar. \n" +
                    "3.- Otras.");

opcionReservacion = int.Parse(Console.ReadLine());
cuenta_Bancaria.Operacion(opcionReservacion);