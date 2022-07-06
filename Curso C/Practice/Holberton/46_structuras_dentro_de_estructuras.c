#include <stdio.h>
    
    typedef struct Punto 
    {
        float x, y;
    }Punto;
    
    typedef struct Persona
    {
        char *nombre;
        int edad;
        Punto p;
    }Persona;

int main(void)
{
    
    Persona Juan;
    Juan.nombre = "Juan";
    Juan.edad = 21;
    Juan.p.x = -5.4f;
    Juan.p.y = 10.0f;
    printf("Nombre %s \n", Juan.nombre);
    printf("%d \n", Juan.edad);

    printf("%f \n", Juan.p.x);
    printf("%f \n", Juan.p.y);
    return(0);
}