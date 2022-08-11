using EjemploSealed;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("opel","vectra", "2 ruedas");
            Moto moto1 = new Moto("Kawasaki", "ninja", 1000);
            Triciclo triciclo1= new Triciclo("sadasd", "ewdsfg", 150);
            Console.WriteLine(coche1.Marca);
            Console.WriteLine(moto1.Marca);

            
            moto1.Arrancar();
            coche1.Arrancar();
            triciclo1.Arrancar();
            Console.ReadKey();
        }
    }
}