#include <stdio.h>

int main(void)
{   
    int numeros[10];
    int i = 1, menor, mayor = 0;
    
    for( i = 1; i <= 10; i++)
    {
        numeros[i] = i;
        if (menor > numeros[i])
        {
            menor = numeros[i];
        }
        if (mayor  < numeros[i])
        {
            mayor = numeros[i];
        }
    }
    printf("el numero Mayor es %d\n", mayor);
    printf("el numero menor es %d\n", menor);
   return(0);
}


    //----------------------------------------------Recorrer un arreglo---------------------------------------------
    /*
    while (i <= 10)
    {
        numeros[i] = i;
        printf("%d ", numeros[i]);
        i++;
    }
    */
    //--------------------------------------------------------------------------------------------------------------