using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");
            foreach(int element in arrayElementos)
            {
                int i = 0;
                Console.WriteLine(element);
            }


        }


        static int[] LeerDatos()
        {
            Console.Write("Cuantos elementos quieres que tenga el array?: ");

            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];
            for (int i = 0; i < numElementos; i++)
            {
                Console.Write($"Introduce el dato para la posicion [{i}]");
                respuesta = Console.ReadLine();
                datos[i] = int.Parse(respuesta);
            }
            return datos;
        }
    }

}
