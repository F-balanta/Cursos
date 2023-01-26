using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Curso
{
    public class OperacionXUnitTest
    {

        [Fact]  // Define un metodo de prueba
        public void SumarNumeros_InputDosNumeros_ObtenerValorCorrecto()
        {
            // Devide en 3 fases 
            // Arrange: Inicializar las variables antes de ejecutar la prueba
            Operacion operacion = new();
            int numero1Test = 50, numero2Test = 69;

            // Act : Representa la ejecucion de la operacion
            int resultado = operacion.SumarNumeros(numero1Test, numero2Test);

            //Assert : Comparacion de resultados, contiene un conjunto de operadores usado para hacer la comparacion
            Assert.Equal(119, resultado);
        }

        [Fact]
        public void IsValorPar_InputNumeroImpar_ReturnFalse()
        {
            Operacion op = new();

            int numeroImpar = 7;
            bool ispar = op.IsValorPar(numeroImpar);

            Assert.False(ispar);
        }

        [Theory]// Para ingresar valores de prueba ya no se usa Fact si no Theory
        [InlineData(3, false)]// Indica que el parametro de entrada es 3 y el resultado esperado es false
        [InlineData(5, false)]
        [InlineData(7, false)]
        public void IsValorPar_InputNumeroImpar_ReturnFalse2(int numeroImpar, bool expectedResult)
        {
            Operacion op = new();
            var resultado = op.IsValorPar(numeroImpar);
            
            Assert.Equal(expectedResult, resultado);
        }

        [Fact]
        public void IsValorPar_InputNumeroPar_RetornaTrue()
        {
            Operacion op = new();

            int numeroPar = 4;
            bool ispar = op.IsValorPar(numeroPar);

            Assert.True(ispar);
        }

        [Theory]
        // TestCase describe los parametros a ser evalado por el metodo
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(44)]
        [InlineData(444)]
        [InlineData(88)]
        [InlineData(20)]
        public void IsValorPar_InputNumeroPar_RetornaTrue2(int numeroPar)
        {
            Operacion op = new();

            bool ispar = op.IsValorPar(numeroPar);

            Assert.True(ispar);
        }

        [Theory]  // Define un metodo de prueba
        [InlineData(2.2, 1.2)]
        [InlineData(2.23, 1.24)]
        public void SumarDecimal_InputDosNumeros_ObtenerValorCorrecto(double decimal1Test, double decimal2Test)
        {
            // Devide en 3 fases 
            // Arrange: Inicializar las variables antes de ejecutar la prueba
            Operacion operacion = new();

            // Act : Representa la ejecucion de la operacion
            double resultado = operacion.SumarDecimal(decimal1Test, decimal2Test);

            //Assert : Comparacion de resultados, contiene un conjunto de operadores usado para hacer la comparacion
            Assert.Equal(3.4, resultado, 0.1);
            // El tercer parametro es llamado Delta
            // Con el 3cer parametro indico que sumare 0.1 y restare 0.1 para mantener el resultado en un intervalo
            // no es recomendable dejar intervalos tan grandes.
            // Se utilizan normalmente cuando son centécimas de decimal
        }


        [Fact]
        public void GetListaNumerosImpares_InputMinimoMaximoIntervalos_ReturnListaImpares()
        {
            // arrange
            Operacion op = new();

            // Numeros impares que espero sean devueltos
            List<int> numerosImparesEsperados = new List<int> { 5, 7, 9 };

            // Act
            List<int> resultados = op.GetListaNumerosImpares(5, 10);

            // METODOS HELPERS
            // Asserts
            // El resultado de la operacion lo compara contra lo se supongo será el resultado

            Assert.Equal(numerosImparesEsperados, resultados);

            // Evaluar si un elemento se encuentra dentro de la colección
            // Si se encuentra devuelve un succes si no fallara el test
            //Assert.That(resultados, Does.Contain(15)); esto fallaria el test
            Assert.Contains(5, resultados);// Valida si 5 está dentro de los resultados

            // Validar si la lista está no vacia
            Assert.NotEmpty(resultados);

            //validar cantidad de elementos de una lista
            Assert.Equal(3,resultados.Count());

            //Validar que un elemento no se encuentre
            Assert.DoesNotContain(100,resultados);

            // Validar que estén ordenados de forma Ascendente los elementos de la lista
            Assert.Equal(resultados.OrderBy(u=>u), resultados);
        }

    }
}


