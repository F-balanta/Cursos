using System;

class Excepciones
{
    static void Main(string[] args)
    {
        Random numero = new Random();

        int aleatorio = numero.Next(0, 100);
        int minumero;
        int intentos = 0;

        Console.WriteLine("Indtoduce un N° entre (0 y 100)");

        do{
            intentos++;
            try
            {
                minumero = int.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("No has introducido un valor numerico valido\nse toma como numero introducido el 0");
                minumero = 0;
            }
            if (minumero > aleatorio) Console.WriteLine("El N° es mas bajo.");
            if (minumero < aleatorio) Console.WriteLine("El N° es mas alto.");
        } while (aleatorio != minumero);

        Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

        Console.WriteLine("A partir de esta linea de codigo el programa continuaría");
    }
}
