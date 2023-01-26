using System;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // checked{ // COMPRUEBA SI HAY ERRORES DE DESBORDAMIENTO 
            // // Si hay error de desbordamiento al ejecutar el programa nos devolvera una excepcion tipo O  veflowException
            // // Operaicones aritmeticas que pueden lanzar un error.
            // int numero=int.MaxValue;// Devuelve el valor mas alto del ripo primitivo (int)
            // int resultado = numero + 20;// Error de desbordamiento
            // System.Console.WriteLine(resultado);
            // }

            // // Que es lanzar excepciones
            /*Para abreviar el checked, primero hay que localizar que linea en que linea se 
                genera el desbordamiento
            */

            int numero = int.MaxValue;
            int resultado = checked(numero + 20); // la exprecion unchecked no comprueba las operaciones de numeros enteros, permitiendo los desbordamientos y la ejecucion del programa.
            Console.WriteLine(resultado);
        }
    }
}
