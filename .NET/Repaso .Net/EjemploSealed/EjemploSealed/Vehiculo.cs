namespace EjemploSealed
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumeroRuedas { get; set; }
        public decimal Altura { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca =  marca;
            Modelo = modelo;
        }

        public virtual void Arrancar()
        {
            Console.WriteLine("Arrancando Vehiculo");
        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }
        public void Apagar()
        {
            Console.WriteLine("Apagando...");
        }


       
    }
}