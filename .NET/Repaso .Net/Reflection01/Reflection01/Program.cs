using System.Linq;
using System.Reflection;

namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtener informacion sobre un tipo
            try
            {
                // Obtenemos el tipo
                Type t = Type.GetType("System.Console");

                // Metodos que buscan la informacion sobre el tipo
                CaracteristicasTipo(t);
                EncuentraCampos(t);
                EncuentraPropiedes(t);
                EncuentraMetodos(t);
                EncuentraInterfaces(t);
            }
            catch 
            {
                Console.WriteLine("Verificar el tipo"); 
            }
        }
        public static void CaracteristicasTipo(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las caracteristicas que tiene son:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Clase base: {t.BaseType}");
            Console.WriteLine($"Es una clase: {t.IsClass}");
            Console.WriteLine($"Abstracta: {t.IsAbstract}");
            Console.WriteLine($"Sellada: {t.IsSealed}");
            Console.WriteLine($"Generica: {t.IsGenericTypeDefinition}");
        }
        public static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("los Campos encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
        }
        public static void EncuentraPropiedes(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("las caracteristicas que tiene son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
        }
        public static void EncuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("las caracteristicas que tiene son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
        }
        public static void EncuentraInterfaces(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("las caracteristicas que tiene son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
        }
    }
}