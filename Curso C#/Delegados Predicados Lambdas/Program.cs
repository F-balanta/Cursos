using System;

namespace DelegadosPredicadosLambdas
{

    class Program
    {
        static void Main(string[] args)
        {
            // Creacion del objeto delegado apuntando a mensaje de bienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBIenvenida.SaludoBienvenida);
            // Utilizando el Delegado para llamar al metodo saludoBienvenida
            ElDelegado("Hola acabo de llegar");

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado("Hola ya me voy");
        }
        // Definicion del objeto delegado 
        delegate void ObjetoDelegado(string msj);
    }
    class MensajeBIenvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine($"Mensaje Bienvenida: {msj}");
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Mensaje de Despedida: {msj}");
        }
    }
}