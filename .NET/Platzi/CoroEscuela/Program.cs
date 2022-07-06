using System;

namespace CoroEscuela
{
   class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();

            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "CL 73 # 25 L 34";
            miEscuela.AñoFundacion = 2012;
            Console.WriteLine("Timbrando...");
            miEscuela.Timbrar();
        }
    }
    class Escuela
    {


        public void Timbrar()
        {
            Console.Beep(10000,3000);
        }

        public string nombre;
        public string direccion;
        public int AñoFundacion;
        public string Ceo;
    }
}
