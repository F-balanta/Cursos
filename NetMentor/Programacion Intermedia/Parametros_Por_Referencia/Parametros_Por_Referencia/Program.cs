using System;

namespace Tipos_de_Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametro por valor
            int valorActual1 = 10;
            Console.WriteLine("\n\t\t Parametro por valor");
            Actualizar(valorActual1);
            Console.WriteLine($"El valor actual es: {valorActual1}");

            // Parametro por referencia
            int valorActual2 = 10;
            Console.WriteLine("\n\t\t Parametro por referencia");
            ActulizarRef(ref valorActual2);
            Console.WriteLine($"El valor es: {valorActual2}");

            int valorActua3;
            Console.WriteLine("\n\t\t Palabra reservada Out");
            ActualizarOut(out valorActua3);
            Console.WriteLine($"El valor es: {valorActua3}");

            int valorActua4;
            Console.WriteLine("\n\t\t Palabra reservada Out");
            ActualizarOut(out valorActua4);
            Console.WriteLine($"El valor es: {valorActua4}");


            Console.ReadKey();
        }

        // Parametro por valor
        // Es cuando pasamos variables a un metodo
        // Manda una copia del valor de esa variable al metodo
        // Para que cuando se modifique el valor de la variable 
        // El valor original no se vea afectado
        public static void Actualizar(int valor)
        {

            valor += 5;
            Console.WriteLine($"el valor es: {valor}");
        }

        // Parametro por referencia
        // No se manda una copia de la variable
        //Se manda La direccion de memoria de la variable como parametro
        // Por lo tanto si se modifica el valor dentro de un metodo, cambiaria el valor original de la variable
        // Esto se logra utilizando la palabra rezervada ref
        public static void ActulizarRef(ref int valor)
        {
            valor += 2;
        }
        // Palabra reservada Out
        // Se utiliza para inicializar una variable en un metodo
        private static void ActualizarOut(out int valorActual)
        {
            valorActual = 13;
            string x = "";
            
        }
        

        // Se utiliza la palabra reservada "in" cuando no queremos que el valor de la variable sea modificado dentro del metodo.
        // La variable queda dsefinida solamente de lectura
        public static void ActualizarIn(in int valor)
        {
            //valor +=5 da error ya que no se puede modificar
            //valor += 51 // error;
        }

    }
}
