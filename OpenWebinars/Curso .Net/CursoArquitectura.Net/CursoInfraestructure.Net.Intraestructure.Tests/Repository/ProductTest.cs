using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Infraestructure.Data;
using CursoArquitectura.Net.Infraestructure.Repository;
using CursoInfraestructure.Net.Intraestructure.Tests.Base;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace CursoInfraestructure.Net.Intraestructure.Tests.Repository
{
    public class ProductTest
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ProductRepository _productRepository;
        private readonly CursoArquitecturaNetContext _cursoArquitecturaNetContext;
        private ProductBuilder ProductBuilder { get; } = new ProductBuilder();


        public ProductTest( ITestOutputHelper testOutputHelper)
        {
            // Nos permitirá ver la salida de los test por consola como si fuera un Console.WriteLine()
            _testOutputHelper = testOutputHelper;
            // Configurando base de datos en memoria para poder ejecutar el test
            var dbOptions = new DbContextOptionsBuilder<CursoArquitecturaNetContext>()
                .UseInMemoryDatabase(databaseName: "CursoTestingDB").Options;

            // Acceso al contexto
            _cursoArquitecturaNetContext = new CursoArquitecturaNetContext(dbOptions);
            // Acceso al repositorio
            _productRepository = new ProductRepository(_cursoArquitecturaNetContext);

        }

        // Test para testear metodo
        [Fact] // Indica que el metodo siguiente va a ser un test
        public async Task Get_Product_By_Name()
        {
            // Obtenemos el build para generar un producto
            var existingProduct = ProductBuilder.Build();
            // Si quiere obtener el contexto primero hay que añadirlo al contexto
            _cursoArquitecturaNetContext.Products.Add(existingProduct);
            // Se guardan los cambios
            _cursoArquitecturaNetContext.SaveChanges();

            // Se imprimen el nombre del producto por Consola de Test
            // Brindará información sobre lo que pasa 
            _testOutputHelper.WriteLine($"ProductnName:  {existingProduct.ProductName}");


            // TESTING
            // Obtiene  una lista o coleccion de nombres de produsctos
            var productListFromRepo = await _productRepository.GetProductByNameAsync(existingProduct.ProductName);
            Assert.Equal(ProductBuilder.TestProductName, productListFromRepo.ToList().First().ProductName);

        }
    }
}
