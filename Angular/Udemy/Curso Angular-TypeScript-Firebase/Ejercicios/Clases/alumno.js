// Inicio de la clase
var Alumno = /** @class */ (function () {
    // Método constructor
    function Alumno() {
        this.mostrarMensaje;
    }
    Alumno.prototype.asignar = function (nombrePersona, aoellidoPersona) {
        this.nombre = nombrePersona;
        this.apellido = aoellidoPersona;
    };
    Alumno.prototype.mostrarMensaje = function () {
        console.log("Hola ", this.nombre);
    };
    return Alumno;
}());
// Fin de la clase
var alumno1 = new Alumno();
alumno1.asignar("Jhonatan", "Balanta");
alumno1.mostrarMensaje();
var alumno2 = new Alumno();
alumno2.asignar("David", "Balanta");
alumno2.mostrarMensaje();
