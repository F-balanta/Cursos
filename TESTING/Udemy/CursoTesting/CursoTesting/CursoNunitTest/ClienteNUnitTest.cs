using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    [TestFixture]
    public class ClienteNUnitTest
    {
        // Declaro un propiedad que va a ser utilizada por todos metodos de la calse
        private Cliente cliente { get; set; }
        // Declaro un metodo SetUp()

        [SetUp]// Con esta notación  este metodo se iniciará primero 
        public void SetUp()
        {
            // 
            cliente = new();
        }

        [Test]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto()
        {
            //Act
            cliente.ClienteNombre = cliente.CrearNombreCompleto("Felipe", "Balanta");

            //Assert

            // Compara si "nombreCompleto" == "Felipe Balanta"
            Assert.That(cliente.ClienteNombre, Is.EqualTo("Felipe Balanta"));
            // Compara si "nombreCompleto" == "Felipe Balanta" - Método clasico
            Assert.AreEqual(cliente.ClienteNombre, "Felipe Balanta");
            // Evalua si cierto texto existe dentro de la variable
            Assert.That(cliente.ClienteNombre, Does.Contain("Balanta"));
            // Evalua si cierto texto existe dentro de la variable Ignorando mayusculas y minusculas
            Assert.That(cliente.ClienteNombre, Does.Contain("Balanta").IgnoreCase);
            // Evalua si nombre completo comienza con "Felipe"
            Assert.That(cliente.ClienteNombre, Does.StartWith("Felipe"));
            // Evalua si nombre completo Termina con "Felipe"
            Assert.That(cliente.ClienteNombre, Does.EndWith("Balanta"));
        }

        [Test]
        //Metodo para evaluar si la propiedad es nula
        public void ClienteNombre_NoValues_ReturnNull()
        {
            Assert.IsNull(cliente.ClienteNombre);
        }

        [Test]
        public void DescuentoEvaluacion_DeafaultCliente_ReturnsDescuentoIntervalo()
        {
            int descuento = cliente.Descuento;

            Assert.That(descuento, Is.InRange(5, 24));
        }

        [Test]
        public void CrearExcepcionAlCrearELNombreCompleto_InputNombreApellido_ReturnNombreCompleto()
        {

            cliente.ClienteNombre = cliente.CrearNombreCompleto("Felipe", "Balanta");


            // Este metodo permite agrupar asserts, para que cuando salga un error,
            // aparezcan todos los errores errores que lo causan
            Assert.Multiple(() =>
            {
                // Con estos ejemplos estoy forzando un un error
                // Compara si "nombreCompleto" == "Felipe Balanta"
                Assert.That(cliente.ClienteNombre, Is.EqualTo("Felipe Balanta"));
                // Compara si "nombreCompleto" == "Felipe Balanta" - Método clasico
                Assert.AreEqual(cliente.ClienteNombre, "Felipe Balanta");
                // Evalua si cierto texto existe dentro de la variable
                Assert.That(cliente.ClienteNombre, Does.Contain("Balanta"));
                // Evalua si cierto texto existe dentro de la variable Ignorando mayusculas y minusculas
                Assert.That(cliente.ClienteNombre, Does.Contain("Balanta").IgnoreCase);
                // Evalua si nombre completo comienza con "Felipe"
                Assert.That(cliente.ClienteNombre, Does.StartWith("Felipe"));
                // Evalua si nombre completo Termina con "Felipe"
                Assert.That(cliente.ClienteNombre, Does.EndWith("Balanta"));
            });

        }

        [Test]
        public void CrearNombreCompleto_InputNombre_returnsNotNull()
        {
            cliente.CrearNombreCompleto("Juan", "");
            //Validamos que la variable no sea nula
            Assert.IsNotNull(cliente.ClienteNombre);
            Assert.IsFalse(string.IsNullOrEmpty(cliente.ClienteNombre));
        }
        [Test]
        public void ClienteNombre_InputNombreEnBlanco_ThrowsException()
        {
            // capturamos la excepción
            var exceptionDetalle = Assert.Throws<ArgumentException>(() => cliente.CrearNombreCompleto("", "Balanta"));
            // Comparamos si el mensaje de la excepcion que sea ha creado dentro del metodo CrearNombreCompleto
            // con lo que se supone debe de salir. (Lo que yo supongo contra el resultado de la operación)
            Assert.AreEqual("El nombre está en blanco", exceptionDetalle.Message);

            // Misma condicion usando That
            Assert.That(() =>
                cliente.CrearNombreCompleto("", "Balanta"), Throws.ArgumentException.With.Message.EqualTo("El nombre está en blanco"));


            // Comparar el obtejo de la excepción 
            Assert.Throws<ArgumentException>(() => cliente.CrearNombreCompleto("", "Balanta"));
            // De esta forma puedp comparar el objeto sin evaluar el mensaje
            Assert.That(() => cliente.CrearNombreCompleto("", "Balanta"), Throws.ArgumentException);

        }


        [Test]
        public void GetClienteDetalle_CrearClienteConMenosde500TotalOrderReturnsClienteBasico()
        {
            // Al setear el OrderTotal a 150 asumimos que s un cliente Basico el que se creará
            cliente.OrderTotal = 150;

            var resultado = cliente.GetClienteDetalle();

            // Quiero Evaluar  el resultado y el valor que estoy esperando
            // Para este caso comparamos el resultado obtenido, y lo que se supone deberia de ser
            Assert.That(resultado, Is.TypeOf<ClienteBasico>());

        }

        [Test]
        public void GetClienteDetalle_CrearClienteConMasDe500TotalOrderReturnsClientePremium()
        {
            // Al setear el OrderTotal a 150 asumimos que s un cliente Basico el que se creará
            cliente.OrderTotal = 670;

            var resultado = cliente.GetClienteDetalle();

            // Quiero Evaluar  el resultado y el valor que estoy esperando
            // Para este caso comparamos el resultado obtenido, y lo que se supone deberia de ser
            Assert.That(resultado, Is.TypeOf<ClientePremium>());

        }

    }
}
