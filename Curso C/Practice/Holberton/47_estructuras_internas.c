#include <stdio.h>

typedef struct Persona
{
    char *nombre;
    int edad;

    struct Punto
    {
        float x, y;
    }Q;
    
}Persona;


int main(void)
{
    Persona datos;

    datos.nombre = "Juan datos";
    datos.edad = 21;
    datos.Q.x = 54.5f;
    datos.Q.y = -17.4f;

    printf("Nombre: %s\n", datos.nombre);
    printf("Edad: %d\n", datos.edad);
    
    printf("Punto X: %f\n", datos.Q.x);
    printf("Punto Y: %f\n", datos.Q.y);
    return(0);
}