using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class ProductoAddOrUpdateDto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }
    }
}