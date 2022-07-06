using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre
        {
            get { return "Copia " + nombre; }
            set { nombre = value; }
        }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> cursos { get; set; }


        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}\nTipo: {TipoEscuela}\nPais:{Pais}\nCiudad: {Ciudad}";
        }
    }
}
