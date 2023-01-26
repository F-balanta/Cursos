using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;

                int contador = 0;

                string path =@"mnt\D:\Informacion\Escritorio\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea=archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }
            }catch(Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
        }
    }
}
