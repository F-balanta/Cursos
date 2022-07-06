using System.Collections.Generic;
using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primero en entrar es el primero en salir -- Colecciones FIFO
            // First In / First out
            // Son utilizadas para el control de procesos, es como almacenar una lista de tarea
            /// que el sistema operativo tiene que hacer ¿que prioridades da?(First In / First out)
            // Si no se termina una tarea, no puede pasar a resolver la siguiente

            // Definir / Declarando una Queue - Cola
            Queue<int> numeros = new Queue<int>();
            // Agregar elementos a la cola
            foreach (int elemento in new int[5] { 2, 4, 6, 8, 10 })
            {
                // Para agregar un elemento en una cola utilizamos la clase Enqueue
                numeros.Enqueue(elemento);
            }
            // Imprimir en consola  - Recorriendo
            Console.WriteLine("Recorriendo el Queue");
            foreach (int elem in numeros)
            {
                Console.WriteLine(elem);
            }
            // Eliminando elementos del queuw
            // PAra eliminar elementos de una cola utulizamos la clase Dequeue
            Console.WriteLine("Eliminando Elementos");
            numeros.Dequeue();
            foreach (int elem in numeros)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
