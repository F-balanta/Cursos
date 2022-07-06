using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Proyecto_EF.Models
{
    public class Categoria
    {
        // DataAnotation permite hacer validaciones
        //[Key]
        public Guid CategoriaId { get; set; }
        //[Required]
        //[MaxLength(150)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Peso { get; set; }


        // Para hacer la relacion 
        [JsonIgnore]
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
