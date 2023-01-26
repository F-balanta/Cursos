using System;
namespace UseCars
{

    class MyCar
    {

        static void Main(string[] args)
        {
            // Instance of type Car
            Car coche = new Car();
            coche.Data();
            coche.getInfoCar();
            Console.ReadKey();
        }
    }
    partial class Car
    {

        public Car()
        {
            this.wheels = 4;
            this.height = 1.426; //MM
            this.width = 1.80; //MM
            this.length = 4.399; //MM
        }
        public void getInfoCar()
        {
            Console.WriteLine("\t\t\t\t\t\t\n\nINFORMACION COCHE:");
            Console.Write("Marca del coche: " + this.brand + "\n");
            Console.Write("Puertas: " + this.doors + "\n");
            Console.Write("Cantidad de ruedas: " + this.wheels + "\n");
            Console.Write("Color: " + this.color + "\n");
            Console.Write("Tapiceria: " + this.tapestery + "\n");
            if (this.air_conditioning == "S" || this.air_conditioning == "s")
                Console.Write("Aire acondicionado: SI" + "\n");
            else if (this.air_conditioning == "N" || this.air_conditioning == "n")
                Console.Write("Aire acondicionado: NO" + "\n");
            Console.Write("Altura: " + this.height + "\n");
            Console.Write("Largo: " + this.length + "\n");
            Console.Write("Ancho: " + this.width + "\n");
        }

    }
    partial class Car
    {
        public void Data()
        {
            string brand, color, tapestery, air;
            int doors, wheels;

            Console.WriteLine("\t\t\t\t\t\t\t***BIENVENIDO***");
            Console.Write("Especifica tu coche:\n\n");
            Console.Write("Digita la marca de tu carro: ");
            brand = Console.ReadLine();
            Console.Write("Digita el total de puertas: ");
            doors = Int32.Parse(Console.ReadLine());
            Console.Write("Tiene Aire Acondicionado? (S o N): ");
            air = Console.ReadLine();
            Console.Write("Tapiceria?: ");
            tapestery = Console.ReadLine();
            Console.Write("De que color es tu coche?: ");
            color = Console.ReadLine();
            setCar(brand, doors, air, tapestery, color);
        }
        
        public void setCar(string setbrand, int setdoors, string setair, string settapestery, string color)
        {
            this.brand = setbrand;
            this.doors = setdoors;
            this.air_conditioning = setair;
            this.tapestery = settapestery;
            // TODO: asdsadasd
        }

        // Define the features cars
        private string brand;
        private int wheels;
        private double height;
        private double width;
        private int doors;
        private string air_conditioning;
        private String tapestery;
        private string color;
        double length;
    }
} 