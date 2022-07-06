#include <stdio.h>
#include <stdlib.h>

/*Malloc*/


int main(void)
{
    void *p1 = NULL;
    int *p1_convertido = NULL;
    p1 = malloc(4*sizeof(int));
    
    if(p1 == NULL)
        printf("No se pudo asignar memoria");

    p1_convertido = (int *)p1;

    p1_convertido[0] = 1;
    p1_convertido[1] = 2;
    p1_convertido[2] = 3;
    p1_convertido[3] = 4;


    void * p2 = realloc(p1, 6*sizeof(int));
    /* realloc  reasignar memoria 
    */
   int *x = (int *)p2;

   //printf("Nuevo vector %d ", x[3]);

   p1_convertido[4] = 5;
   p1_convertido[5] = 6;
   printf("%d", p1_convertido[4]);
   printf("%d", p1_convertido[5]);
    return 0;
}
