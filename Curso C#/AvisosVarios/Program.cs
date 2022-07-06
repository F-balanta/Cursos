using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura provincial Madrid", "Sancion de Velocidad 580$", "02-05-2022");
            av2.mostrarAviso();
            Console.WriteLine(av2.getFecha());
        }
    }
}
