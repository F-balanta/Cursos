using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Cavel");
            Humano Juan = new Humano("Balantik");
            Gorila copito = new Gorila("Yayo");
            Juan.getNombre();
            Babieca.getNombre();
            copito.getNombre();
        }
    }

    class Mamiferos
    {
        public  Mamiferos(string nombre)
        {
            this.nombreSerVivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz derespirar");
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
    class Caballo : Mamiferos // Clase caballo Hereda de la clase mamifero
    {
        public Caballo(string nombreCaballo):base(nombreCaballo)
        {
            
        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    class Humano : Mamiferos
    {
        public Humano(string nombreHumano):base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy cfapaz de pensar");
        }
    }
    class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila):base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}