using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar Obj = new ConversorEuroDolar();
            Console.WriteLine(Obj.convierte(5));
        }
    }

    class Circulo
    {
        private const double pi = 3.1416; // Propiedad de la clase Circulo. Campo de clase

        public double CalculoArea(int radio) // Metodo de clase. ¿Que pueden hacer los objetos de tipo circulo?
                                             // POO Propiedades y Comportamientos
        {

            return pi * radio * radio;
        }
    }
    class ConversorEuroDolar
    {
        public double euro = 4.176;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
    }
}
