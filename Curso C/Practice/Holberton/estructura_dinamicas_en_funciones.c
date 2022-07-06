#include <stdlib.h>
#include <stdio.h>


typedef struct fecha
{
    int dia;
    int mes;
    int anio;
}fecha;
fecha * crear_fecha(void);

int main(void)
{
    fecha *fecha1 = crear_fecha();
   
    return(0);
}

fecha * crear_fecha(void)
{
    fecha * nueva_fecha = malloc(sizeof (fecha));

    if(nueva_fecha == NULL)
        printf("Error");
}

/**PENDIENTE**/