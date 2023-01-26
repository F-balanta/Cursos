using Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMSTest
{
    // COmponente tipo test
    [TestClass]
    public class OperacionMSTest
    {
        [TestMethod]
        public void SumarNumeros_InputDosNumeros_ObtenerValorCorrecto()
        {
            // Devide en 3 fases 
            // Arrange: Inicializar las variables antes de ejecutar la prueba
            Operacion operacion = new ();
            int numero1Test = 50, numero2Test = 69;

            // Act : Representa la ejecucion de la operacion
            int resultado = operacion.SumarNumeros(numero1Test,numero2Test);

            //Assert : Comparacion de resultados, contiene un conjunto de operadores usado para hacer la comparacion
            Assert.AreEqual(119,resultado);
        }
    }
}
