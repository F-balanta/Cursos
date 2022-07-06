using System;

var persona = new Persona();
persona.PreguntarNombre();
Console.WriteLine(persona.Nombre);
Console.ReadKey();
public class Persona : IPersonas
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public  void PreguntarNombre()
    {
        
        Console.WriteLine("Cual es tu nombre: ");
        var nombre = Console.ReadLine();
        if (nombre == null)
        {
           // Console.WriteLine("Por favor introduce un nombre.");
        }
        else
        {
            Nombre = nombre;
        }
        
    }
}

public interface IPersonas
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad{ get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }

    public void PreguntarNombre()
    {

    }
}
