using CursoArquitectura.Net.DTOs.Base;

namespace CursoArquitectura.Net.DTOs
{
    public class ProductDTO : BaseDTO
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? UnitsInStock { get; set; }
        public string? UnitsOnOrder { get; set; }
    }
}
