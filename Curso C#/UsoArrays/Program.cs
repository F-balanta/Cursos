namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Implicito
            var datos = new[] { "Juan", "Diaz", "España" };
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };
            // Array de objetos
            Empleados Ana = new Empleados("Ana", 27);
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("sara", 37);

            arrayEmpleados[1] = Ana;
            // Array de tipos o clases anonimas
            var personas = new[]
            {
                new{Nombre = "Juan", Edad = 19},
                new{Nombre = "Maria", Edad = 49},
                new{Nombre = "Diana", Edad = 35}
            };
            // Imprimimos el array de Objetos
            Console.WriteLine("Array de Objetos");
            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getNombreEmpleados());
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            // Imprimir array implicito
            Console.WriteLine("Array Implicito");
            foreach (double variable in valores)
            {
                Console.WriteLine(variable);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            // Imprimir array de claes anonimas
            Console.WriteLine("Array de clases anonimas");
            foreach (var variable in personas)
            {
                Console.WriteLine(variable);
            }
        }

    }
    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string getNombreEmpleados()
        {
            return this.nombre;
        }
        private String nombre;
        private int edad;
    }
}