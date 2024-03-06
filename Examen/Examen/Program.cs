// See https://aka.ms/new-console-template for more information
using Examen;

Cliente cliente = new Cliente("Juan", 162080, 1200);
Cajero cajero = new Cajero(09);

cliente.SolicitarOperacion();
Console.WriteLine(cliente.Nombre + " " + " Tienes un saldo de: " + cliente.Saldo);

int opcionReserva = 0;
Console.WriteLine("Ingrese la operacion que quiere realizar: \n" +
                    "1.- Retirar. \n" +
                    "2.- Depositar. \n" +
                    "3.- Consultar saldo.");

opcionReserva = int.Parse(Console.ReadLine());
cajero.Reserva(opcionReserva);