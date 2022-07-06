int empleado(){
    
        typedef struct {
        int identificador;
        char *nombre;
        char *apellido;
        float sueldoAnual;
    }  Empleado;

    Empleado profesor;
    profesor.identificador = 1151970347;
    profesor.nombre = "Juan Felipe";
    profesor.apellido = "Balanta Renteria";
    profesor.sueldoAnual = 30580656;

    printf("%s ", profesor.nombre);
    
    //profesor.sueldoAnual = profesor.sueldoAnual + 500000;
    profesor.sueldoAnual += 500000;
    printf(" Se gana anualmente: %1.f", profesor.sueldoAnual);

}