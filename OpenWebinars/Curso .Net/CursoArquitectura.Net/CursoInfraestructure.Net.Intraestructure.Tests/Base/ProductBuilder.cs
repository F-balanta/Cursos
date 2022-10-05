using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Core.Entities;

namespace CursoInfraestructure.Net.Intraestructure.Tests.Base
{
    // Esta clase es para no tener que instanciar en los test
    public class ProductBuilder
    {
        public int TestProductId => 5;
        public string TestProductName => "Test product name";
        public decimal? TestProductUnitPrice => 5.5m;
        public short? TestProductUnitsInStock => 6;
        public short? TestProductUnitsOnOrder => 3;


        public Product Build()
        {
            return new Product()
            {
                Id = TestProductId,
                ProductName = TestProductName,
                UnitPrice = TestProductUnitPrice,
                UnitsInStock = TestProductUnitsInStock,
                UnitsOnOrder = TestProductUnitsOnOrder,

            };
        }
    }
}
