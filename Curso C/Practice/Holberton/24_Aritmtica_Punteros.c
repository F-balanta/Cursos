#include <stdio.h>

int main(void)
{
    int arreglo[10], i;
    int a = 4545;

    
    for ( i = 0; i < 10; i++)
    {
        arreglo[i] = i;
        printf(" %d->  %p\n" , arreglo[i], &arreglo[i]);
    }
    
    
    int *p, *q, x;

    x = 10;
    p = &x;
    q = p;

    
    printf("%p %p %p \n ", &x, q, p);
    return(0);
}