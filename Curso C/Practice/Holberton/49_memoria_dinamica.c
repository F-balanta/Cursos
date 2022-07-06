#include <stdio.h>
#include <stdlib.h>



int main(void)
{
    //las variables se almacenan en una seccion llamada Stack = Pila

    // Mermoria Dinamica se almacena en el Heap al asignarle memoria de la Ram
        int *p;
        p = (int *)malloc(sizeof(int));
    // Mi puntero va a tomar memoria alojada 0
    
        *p = 5;
        
        printf("%d\n", *p);
        free(p);
    //Free libera el espacio asignado de memoria al puntero despues de haberse utilizado


    return(0);
}