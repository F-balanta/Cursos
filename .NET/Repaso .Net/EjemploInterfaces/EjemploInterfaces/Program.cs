using ExplicacionInterface;
namespace EjemploInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPieza triangulo = new TrianguloRectangulo(3, 4);
            IPieza cuadrado = new Cuadrado(4);
            Console.WriteLine($"El area del cuadrado es {cuadrado.Area()} y su perimetro {cuadrado.Perimetro()}");
            Console.WriteLine($"El area del triangulo es {triangulo.Area()} y su perimetro {triangulo.Perimetro()}");
            Console.ReadKey();
        }
    }
}