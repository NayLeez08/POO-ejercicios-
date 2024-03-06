// See https://aka.ms/new-console-template for more information

using AlquilerAutos;

Agencia agencia = new Agencia();
Cliente cliente = new Cliente(01, "BBVA", "calle 16 sur", 246197095);
Reservacion reservacion = new Reservacion("2024", "VW", "Amarillo", "ABC123", true);
Pago pago = new Pago();


//Variables 
int opcionReservacion = 0;


agencia.AlquilerAutos();
Console.WriteLine("Ingrese la forma de reservacion: \n" +
                    "1.- Teléfonica. \n" +
                    "2.- Online. \n" +
                    "3.- Presencial.");

opcionReservacion = int.Parse(Console.ReadLine());

cliente.Reservacion(opcionReservacion);
Console.WriteLine("El auto elegido es: " + reservacion.modeloAuto + " " + reservacion.marca + " " + reservacion.color);
reservacion.TiempoAlquiler();
reservacion.DiasAlquiler();
reservacion.FechaEntrega();

pago.Transferencia();
pago.PuntoVenta();
pago.efectivo();

