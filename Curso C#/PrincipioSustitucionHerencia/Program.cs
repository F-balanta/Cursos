using System;

namespace PrincipioSustitucionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando objetos
            Caballo miBabieca = new Caballo("Cavel");
            Humano miJuan = new Humano("Balantik");
            Gorila micopito = new Gorila("Yayo");

            //Principio de sustitucion "Siempre Un
            //Mamiferos Animal = new Caballo("Bucéfalo");
            //Mamiferos persona = new Humano("Juan");

            //Caballo bucefalo = new Caballo("Bucéfalo");
            //Animal = bucefalo;

            //Object miAnimal = new Caballo("Bucéfalo");

            //Object mihumamno = new Humano("Juan");
            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miJuan;
            almacenAnimales[2] = micopito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }

    class Mamiferos
    {
        public Mamiferos(string nombre)
        {
            this.nombreSerVivo = nombre;
        }
        // Cuando un metodo de una clase tiene el modificador de acceso Protected
        // Esto hace que el metodo solamente sea accesible a las clases que lo heredan
        // Si se intenta acceder de alguna forma externa a la clase en la que se definió o las que heredan, marcara error.
        protected void respirar()
        {
            Console.WriteLine("Soy capaz derespirar");
        }
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hastas que se valgan por si solas"); ;
        }
        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombreSerVivo}");
        }
        private string nombreSerVivo;
    }





    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena):base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        public int NumeroPatas()
        {
            return 4;
        }
    }
    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy cfapaz de pensar");
        }
    }
    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Pensamiento Instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int NumeroPatas()
        {
            return 2;
        }
    }
}