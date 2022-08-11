using System;
namespace DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic variableDinamica = 1;
            Console.WriteLine(variableDinamica.GetType().ToString());
            variableDinamica = "Hola";
            Console.WriteLine(variableDinamica.GetType().ToString());
            variableDinamica = new EjemploTest() { Valor = "Test valor" };
        }

        static void TestDynamic(dynamic valor)
        {
            Console.WriteLine(valor);
        }
        public class EjemploTest
        {
            public string Valor { get; set; }
        }

    }
}