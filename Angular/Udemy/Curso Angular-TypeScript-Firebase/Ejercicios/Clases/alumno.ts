// Inicio de la clase
class Alumno{

    // Método constructor
    constructor()
    {
        this.mostrarMensaje;
    }
    nombre:string;
    apellido:string;
    peso:number;

    asignar(nombrePersona:string, aoellidoPersona:string){
        this.nombre = nombrePersona;
        this.apellido = aoellidoPersona;
    }
    mostrarMensaje(): void
    {
        console.log("Hola ", this.nombre);
    }
}
// Fin de la clase

var alumno1: Alumno = new Alumno();
alumno1.asignar("Jhonatan", "Balanta")
alumno1.mostrarMensaje();

var alumno2: Alumno = new Alumno();
alumno2.asignar("David", "Balanta")
alumno2.mostrarMensaje();