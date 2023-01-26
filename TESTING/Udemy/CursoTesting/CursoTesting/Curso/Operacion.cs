namespace Curso
{
    public class Operacion
    {
        /// <summary>
        /// Variable global que almacena numeros impares
        /// </summary>
        public List<int> NumerosImpares { get; set; } = new List<int>();
        /// <summary>
        /// Return the sum of 2 integers
        /// </summary>
        /// <param name="a">Integer #1</param>
        /// <param name="b">Integer #2</param>
        /// <returns></returns>
        public int SumarNumeros(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Return True if a number is pais otherwise return false
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool IsValorPar(int numero)
        {
            if (numero % 2 == 0)
                return true; 
            else
                return false;
        }
        /// <summary>
        /// Sum of 2 decimal numbers
        /// </summary>
        /// <param name="decimal1"></param>
        /// <param name="decimal2"></param>
        /// <returns></returns>
        public double SumarDecimal(double decimal1, double decimal2)
        {
            return decimal1 + decimal2;
        }
        
        /// <summary>
        /// Return a list of Odd numbers
        /// </summary>
        /// <param name="intervaloMinimo">De donde</param>
        /// <param name="intervaloMaximo">Hasta a donde se generan los valores</param>
        /// <returns></returns>
        public List<int> GetListaNumerosImpares(int intervaloMinimo, int intervaloMaximo)
        {
            NumerosImpares.Clear();

            for(int i = intervaloMinimo; i <= intervaloMaximo; i++)
            {
                if(i % 2 != 0)// Es impar
                {
                    NumerosImpares.Add(i);
                }

            }
            return NumerosImpares;
        }
    }
}