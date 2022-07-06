#include <stdio.h>

int main(void)
{
int i, suma = 0;

    for ( i = 0; i <= 10; i++)
    {
        suma += i;
        suma = suma + i;//Funciona igual a la  instruccion anterior.
    }
    printf("La sumatoria es %d", suma);
    
    return(0);
}