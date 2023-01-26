using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace Curso
{
    public class ClienteXUnitTest
    {
        // Declaro un propiedad que va a ser utilizada por todos metodos de la calse
        private Cliente cliente { get; set; }
        
        // Para inicializar valores, se utiliza un constructor sin parametros
        public ClienteXUnitTest()
        {
            cliente = new();
        }

        [Fact]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto()
        {
            //Act
            cliente.ClienteNombre = cliente.CrearNombreCompleto("Felipe", "Balanta");

            //Assert

            // Compara si "nombreCompleto" == "Felipe Balanta"
            Assert.Equal("Felipe Balanta",cliente.ClienteNombre);
            // Evalua si cierto texto existe dentro de la variable
            Assert.Contains("Balanta", cliente.ClienteNombre);
            // Evalua si nombre completo comienza con "Felipe"
            Assert.StartsWith("Felipe", cliente.ClienteNombre);
            // Evalua si nombre completo Termina con "Felipe"
            Assert.EndsWith("Balanta", cliente.ClienteNombre);
        }

        [Fact]
        //Metodo para evaluar si la propiedad es nula
        public void ClienteNombre_NoValues_ReturnNull()
        {
            Assert.Null(cliente.ClienteNombre);
        }

        [Fact]
        public void DescuentoEvaluacion_DeafaultCliente_ReturnsDescuentoIntervalo()
        {
            int descuento = cliente.Descuento;

            Assert.InRange(descuento,5, 24);
        }


        [Fact]
        public void CrearNombreCompleto_InputNombre_returnsNotNull()
        {
            cliente.CrearNombreCompleto("Juan", "");
            //Validamos que la variable no sea nula
            Assert.NotNull(cliente.ClienteNombre);
            Assert.False(string.IsNullOrEmpty(cliente.ClienteNombre));
        }
        [Fact]
        public void ClienteNombre_InputNombreEnBlanco_ThrowsException()
        {
            // capturamos la excepción
            var exceptionDetalle = Assert.Throws<ArgumentException>(() => cliente.CrearNombreCompleto("", "Balanta"));
            // Comparamos si el mensaje de la excepcion que sea ha creado dentro del metodo CrearNombreCompleto
            // con lo que se supone debe de salir. (Lo que yo supongo contra el resultado de la operación)
            Assert.Equal("El nombre está en blanco", exceptionDetalle.Message);

            // Comparar el obtejo de la excepción 
            Assert.Throws<ArgumentException>(() => cliente.CrearNombreCompleto("", "Balanta"));
        }


        [Fact]
        public void GetClienteDetalle_CrearClienteConMenosde500TotalOrderReturnsClienteBasico()
        {
            // Al setear el OrderTotal a 150 asumimos que s un cliente Basico el que se creará
            cliente.OrderTotal = 150;

            var resultado = cliente.GetClienteDetalle();

            // Quiero Evaluar  el resultado y el valor que estoy esperando
            // Para este caso comparamos el resultado obtenido, y lo que se supone deberia de ser
            Assert.IsType<ClienteBasico>(resultado);

        }

        [Fact]
        public void GetClienteDetalle_CrearClienteConMasDe500TotalOrderReturnsClientePremium()
        {
            // Al setear el OrderTotal a 150 asumimos que s un cliente Basico el que se creará
            cliente.OrderTotal = 670;

            var resultado = cliente.GetClienteDetalle();

            // Quiero Evaluar  el resultado y el valor que estoy esperando
            // Para este caso comparamos el resultado obtenido, y lo que se supone deberia de ser
            Assert.IsType<ClientePremium>(resultado);
        }
    }
}
