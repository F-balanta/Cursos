using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    //[TestFixture]
    //public class ProductoXUnitTests
    //{
    //    [Test]
    //    public void GetPrecio_PremiumCliente_ReturnsPrecion80()
    //    {
    //        //Creo un nuevo producto y le asigno un precion
    //        Producto producto = new Producto { Precio = 50 };

    //        //Obtendgo el precio del producto dependiendo de si el cliente es premium o no
    //        var resultado = producto.GetPrecio(new Cliente { IsPremium = true });
    //        // Comparo el resultado obtenido, con lo esperado, si es valido pasa el test si no lo es falla.
    //        Assert.That(resultado, Is.EqualTo(40));
    //    }

    //    [Test]
    //    public void GetPrecio_PremiumClienteMoq_ReturnsPrecio80()
    //    {
    //        // Creo un nuevo producto el cual asigno el precio a 50
    //        Producto producto = new Producto
    //        {
    //            Precio = 50
    //        };
    //        // Creo un objeto objeto false de tipo ICliente
    //        // El mocking se genera a traves de una interface
    //        var cliente = new Mock<ICliente>();
    //        // para setearle un valor al atributo Ispremium
    //        // Declaro una funcion lambda para acceder a la propiedad. asigno el valor que debe retornar
    //        cliente.Setup(s=>s.IsPremium).Returns(true);
    //        // Para obtener el valor, al metodo GetPrecio le envío el mock con la propiedad seteada a true
    //        var resultado = producto.GetPrecio(cliente.Object);
    //    }
    //}
}
