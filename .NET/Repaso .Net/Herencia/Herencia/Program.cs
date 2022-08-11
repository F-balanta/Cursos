using POO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("opel","vectra", "2 ruedas");
            Moto moto1 = new Moto("Kawasaki", "ninja", 1000);

            Console.WriteLine(coche1.Marca);
            Console.WriteLine(moto1.Marca);

            moto1.Arrancar();
            coche1.Arrancar();

            Console.ReadKey();
        }
    }
}