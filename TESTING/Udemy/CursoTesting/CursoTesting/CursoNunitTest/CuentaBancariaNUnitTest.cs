using Moq;

namespace Curso
{
    [TestFixture]
    public class CuentaBancariaNUnitTest
    {
        // Ya que vamos a hacer pruebas sobre CuentaBanciaria, instanciamos como un objeto privado
        private CuentaBancaria cuenta;  

        // Inicializamos
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]// Método para ingresar un monto a la cuenta
        public void Deposito_InputMonto100LggerFake_ReturnsTrue()
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria(new LoggerFake());
            // Ingresamos el monto y obtenemos el resultado sea True o False
            var resultado = cuentaBancaria.Deposito(100);



            // Comparamos si el resultado es verdadero, de serlo lo pasa 
            Assert.IsTrue(resultado);

            // Saber si el balance es igual al monto que se ingresó
            Assert.That(cuentaBancaria.GetBalance(), Is.EqualTo(100));
        }

        [Test]
        // Este método Agregará un monto a la cuenta utilizando Mocking
        public void Deposito_InputMonto100Mocking_ReturnsTrue()
        {
            // Creamos una instancia  de LoggerGeneral como tipo Mock (Un Falso LoggerGeneral)
            var mocking = new Mock<ILoggerGeneral>();

            CuentaBancaria cuentaBancaria = new CuentaBancaria(mocking.Object);// Se le pasa un objeto falso
            // Ingresamos el monto y obtenemos el resultado sea True o False
            var resultado = cuentaBancaria.Deposito(100);



            // Comparamos si el resultado es verdadero, de serlo lo pasa 
            Assert.IsTrue(resultado);

            // Saber si el balance es igual al monto que se ingresó
            Assert.That(cuentaBancaria.GetBalance(), Is.EqualTo(100));
        }


        [Test]
        [TestCase(200, 100)]
        [TestCase(200, 150)]
        public void Retiro_Retiro100ConBalance200_ReturnsTrue(int balance, int retiro)
        {
            // Creo una dependencia falsa del tipo IloggerGeneral
            var loggermock = new Mock<ILoggerGeneral>();

            // Ahora necesito llamar los metodos para setear los valores
            // EL primer método recibe una cadena como parametro, le indico que recibe cualquier tipo de string
            // Al final debo especificar que devuelve ese método , ya que devuelve un booleano haremos lo siguiente
            loggermock.Setup(s => s.LogDatabase(It.IsAny<string>())).Returns(true);

            // Abro una expresión lambda para acceder el metodo LogBalanceDespuesRetiro() recibe como parametro cualquier numero entero
            // Hago con un lambda despues de la declaracion de que sea entero, una condicion de que debe de ser mayor a zero
            // Y debe de retornar un true
            loggermock.Setup(s => s.LogBalanceDespuesRetiro(It.Is<int>(x=>x > 0))).Returns(true);

            // Le envio el objeto false a cuentabancaria ya que el constructor recibe una interface IllogerGeneral
            CuentaBancaria cuentaBancaria = new CuentaBancaria(loggermock.Object);

            // Ingreso dinero a la cuenta
            cuentaBancaria.Deposito(balance);

            // Retiro un monto
            var resultado = cuentaBancaria.Retiro(retiro);

            Assert.IsTrue(resultado);
        }


        [Test]
        [TestCase(200, 300)]
        // Cuando el valor a retirar sea mayor al balance
        public void Retiro_Retiro300ConBalance200_ReturnsTrue(int balance, int retiro)
        {
            // Creo una dependencia falsa del tipo IloggerGeneral
            var loggermock = new Mock<ILoggerGeneral>();

            
            // Ahora debo configurar la ejecución del método
            // Abro una expresión lambda para acceder el metodo LogBalanceDespuesRetiro() recibe como parametro cualquier numero entero
            // Hago con un lambda despues de la declaracion de que sea entero, una condicion de que debe de ser menor a zero
            // Y debe de retornar un false, ya que el valor a retirar es mayor al balance de la cuenta
            loggermock.Setup(s => s.LogBalanceDespuesRetiro(It.Is<int>(x => x < 0))).Returns(false);

            // Le envio el objeto false a cuentabancaria ya que el constructor recibe una interface IllogerGeneral
            CuentaBancaria cuentaBancaria = new CuentaBancaria(loggermock.Object);

            // Ingreso dinero a la cuenta
            cuentaBancaria.Deposito(balance);

            // El monto no se puede retirar ya que es mayor que el balance
            //Debe de retornar un false
            var resultado = cuentaBancaria.Retiro(retiro);

            // Comparo si el resultado es falso, si el, el test es exitoso, si no el test falla
            Assert.IsFalse(resultado);
        }



        [Test]
        //Este método validará si el tenxto que ingreso es igual al texto que espero que salga
        // Si esto es verdadero, devuelve un true, de lo contrario devuelve false
        public void CuentaBancariaLoggerGeneral_LogMocking_ReturnTrue()
        {
            // Creamos el mock sobre ILoggerGeneral
            var loggerGeneralMock = new Mock<ILoggerGeneral>();
            // Ahora indicamos cual es texto que quiero ingresar como parametro
            string textoPrueba = "hola mundo";

            // Ahora configuro la ejecucion del método
            // Setup() = abro una funcion lanbda para especificar cual método se va a ejecutar
            // Como parametro al método le indico que recibira cualquier tipo de cadena
            // Returns() = Pero este método debe de retornar una cadena (str) en minuscula
            loggerGeneralMock.Setup(s => s.MessaggeWithReturnString(It.IsAny<string>())).Returns<string>(str=>str.ToLower());

            // ejecuto la función y obtengo el resultado del método MessaggeWithReturnString()
            var resultado = loggerGeneralMock.Object.MessaggeWithReturnString("holA mundO");

            // Comparo el resultado obtenido vs lo que espero va a devolver
            Assert.That(resultado, Is.EqualTo(textoPrueba));
        }



        [Test]
        public void CuentaBancaria_LoggerGeneral_LogMockingOutput_ReturnsTrue()
        {
            var loggerGeneral = new Mock<ILoggerGeneral>();

            string textoPrueba = "hola";
            // Configuro el método
            // El método recibe 2 parametros uno de entrada y otro de salida
            loggerGeneral.Setup(s => s.MessaggeWithOutParameterReturnString(It.IsAny<string>(), out textoPrueba)).Returns(true);
            string parametroOut = "";
            var resultado = loggerGeneral.Object.MessaggeWithOutParameterReturnString("Felipe", out parametroOut);

            Assert.IsTrue(resultado);
        }
    }
}
