using System;
//Esto nos permite importar todos los metodos de la clase Math
//using static System.Math;
//using static System.Console;
namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();
            //miVariable es una instancia de una clase anonima
            var miVariable = new { Nombre = "Juan", Edad = 22 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };
            /*
             Las clases anonimas solo pueden contener campos publicos
            Todos los campos deben estar inicializados
            Los campos no pueden ser static
            No se pueden definir metodos
             */
        }
        static void realizarTarea()
        {
            //Objeto 1
            Punto origen = new Punto();
            //Objeto 2
            Punto destino = new Punto(128, 80);
            //Obeto 3
            Punto otroPunto = new Punto();
            
            
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los dos puntos es de: {distancia}");
            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}