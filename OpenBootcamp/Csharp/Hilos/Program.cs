using System;
using System.Threading;

namespace thread
{
    class Program
    {
        public static void Cantinero1Atiende()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Caninero 1 sirve cerveza N° " +i);
                Thread.Sleep(100);
            }
            
        }
        public static void Cantinero2Atiende()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Caninero 2 sirve cerveza N° " + i);
                Thread.Sleep(100);
            }

        }
        static void Main(string[] args)
        {
            Thread cantinero1 = new Thread(new ThreadStart(Cantinero1Atiende));
            Thread Cantinero2 = new Thread(new ThreadStart(Cantinero2Atiende));


            cantinero1.Start();
            Cantinero2.Start();

            Console.ReadKey();
        }
    }

}