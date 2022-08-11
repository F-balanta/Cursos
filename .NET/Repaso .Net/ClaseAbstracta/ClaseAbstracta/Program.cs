namespace ClaseAbstracta
{
    public class Program
    {
        static void Main(string[] args)
        {
            Acutangulo acutangulo = new Acutangulo();
            Escaleno escaleno = new Escaleno();

            acutangulo.Area();
            escaleno.Area();

            escaleno.CalcularTrianguloconHipotenusa(2,5);
            acutangulo.CalcularTrianguloconHipotenusa(2, 5);

            Console.WriteLine();
        }
    }
}