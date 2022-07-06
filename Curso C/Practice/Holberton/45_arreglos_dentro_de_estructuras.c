#include <stdio.h>

typedef struct Persona Persona;


struct Persona{

    char *nombre;
    int edad;
    float calificaciones[5];

};

int main(void)
{
    Persona datos;

    datos.nombre = "Juan Felipe Balanta Renteria";
    printf("Digite su edad: \n");
    scanf("%d", &datos.edad);

    int t = sizeof(datos.calificaciones) / sizeof(float);
    float x = 0;
    for (int i = 0; i < t; i++)
    {   
        
        printf("Digite su calificacion %d\n", i);
        scanf("%f", &x);
        datos.calificaciones[i] = x;

        
    }

    printf("Nombre: %s \n", datos.nombre);
    printf("Tiene %d  años\n", datos.edad);
    for (int j = 0; j < t; j++)
    {
        printf("Y sus notas son %f \n", datos.calificaciones[j]);
    }
    

    
    return(0);
}