using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack - Pilas
            //El ultimo elemento en entrar es el primero en salir
            // Last in First out

            // Declarando una pila
            Stack<itn> pila = new Stack<itn>();

            // Agregar elementos a una pila - Stack
            foreach (int elementos in new[] {10,20,30,40,50})
            {
                 pila.Push(elementos);
                 Console.Write("Se agrego el elemento: " + pila);

            }
            Console.Write("Imprimiendo elementos de la pila\n");
            foreach (var item in collection)
            {
                Console.Write();
            }

        }
    }
}
