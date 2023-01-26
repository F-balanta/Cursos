using System;
namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Progando el Avion");
            Avion miAvion = new Avion();

            miAvion.ArrancarMotor("TracatraTracatra");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.PararMotor("plooooooooooooooof");
            Console.WriteLine();
            Console.WriteLine("Probando el Coche");
            Coche miCoche = new Coche();
            miCoche.ArrancarMotor("Grrrrrrum Grrruuumm");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frenar();
            miCoche.PararMotor("bluuuuuf");
            Console.WriteLine();
            Console.WriteLine("Polimorfismo en acción");
            // Cmabiando su forma  de objeto en tiempo de ejecucion
            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();
            miVehiculo = miAvion;
            miVehiculo.Conducir();
        }
    }
}