#include <stdio.h>

int main(void)
{
    int numero = 400, arreglo[100];
    int m = numero;
    int i = 0, j = 0;

    while(numero > 0)
    {
      arreglo[i] = numero %2;
      numero /= 2;
      i++;
    }

    for (j = i; j >= 0; j--)
    {
        printf("%d", arreglo[j]);
    }
    
    return(0);
}