#include <stdio.h>
#include <stdlib.h>

/*Malloc*/


int main(void)
{
    void *p1 = NULL;
//Se creo un puntero void que no tiene formato  
    p1 = malloc(sizeof(int));
    /*Le asigonamos a p1 un espacio en la memoria*/

    int *p1_coonvertido = (int *)p1;

    *p1_coonvertido = 3;
    printf("%d", *p1_coonvertido);
    return 0;
}
