using System;

namespace ConceptosPOO
{
    internal class Punto
    {

        public Punto(int x, int y)
        {
            this.X = x;
            this.Y = y;
            contadoeDeObjetos++;
        }
        public Punto()
        {
            this.X = 0;
            this.Y = 0;
            contadoeDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif= this.X - otroPunto.X;
            int yDif = this.Y - otroPunto.Y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2)+ Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
        /*public static int ContadorDeObjetos()
        {
            return contadoeDeObjetos;
        }*/
        // O Tambien
        public static int ContadorDeObjetos() => contadoeDeObjetos;
        private int X, Y;
        private static int contadoeDeObjetos = 0;
        public const int constantePrueba = 7;
    }
}
