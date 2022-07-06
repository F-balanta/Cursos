using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_EF.Models
{
    public class Tarea
    {

        //[Key]
        public Guid TareaId { get; set; }
        // Definimos  el nombre de la llave foranea
        //[ForeignKey("CategoriaId")]
        // Relacion de tablas categoria y tarea
        public Guid CategoriaId { get; set; }
        //[Required]
        //[MaxLength(200)]
        public string Titulo { get; set; }
        public string Descriptcion { get; set; }

        public Prioridad PropridadTarea { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Para hacer la realcion
        public virtual Categoria Categoria { get; set; }

        // Atributo que va a omitir alguna propiedad que tenga  nuestra clase que no se debe de crear en la bd
        //[NotMapped()]
        public string Resumen { get; set; }
    }

    public enum Prioridad{Baja, Media, Alta}
}
