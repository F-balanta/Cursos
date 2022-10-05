using System;

namespace Estension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(("hello world!").PrimeraLEtraMayuscula());
            Console.ReadKey();
        }
    }
    // Para crear un metodo de extension es necesario tener una clase estática
    // Sus metodos tambien deben ser estaticos
    // Y los parametros que reciben los metodos deben de llevar la palabra reservada this
    // Así podrán ser invocados sin tener que instanciarse 
    public static class StringExtension
    {
        public static string PrimeraLEtraMayuscula(this string frase)
        {
            char primeraletra = char.ToUpper(frase[0]);
            string restodefrase = frase.Substring(1);
            return primeraletra + restodefrase;
        }
    }
}
