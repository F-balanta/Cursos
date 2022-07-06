#include <stdlib.h>
#include <stdio.h>

int* funcion(void);

int main(void)
{
    int *p;
    p=funcion();
    *p = 5;

    printf("%d", *p);
    free(p);
    return(0);
}
int* funcion(void)
{
    int *x;

    x = (int *) malloc(sizeof(int));

    return(x);
}