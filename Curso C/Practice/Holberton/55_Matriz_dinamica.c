#include <stdlib.h>
#include <stdio.h>


int main(void)
{
    //Declarto variables
    int **matriz, i, nfilas, ncolumnas;
    //Asigno memoria dinamica a la matriz
    matriz = (int **)calloc(5,sizeof(int *));

    nfilas = 5;
    ncolumnas = 5;

    for (int i = 0; i < nfilas; i++)
    {
        matriz[i] = (int *)calloc(ncolumnas, sizeof(int));
    }
//Asignacion de valores
    for (int  i = 0; i < nfilas; i++)
    {
        for (int j  = 0; j < ncolumnas; j++)
        {
            matriz[i][j] = i+j;
        }
        
    }

//Muestro por pantalla
    for (int i = 0; i < nfilas; i++)
    {
        for (int j = 0; j < ncolumnas; j++)
        {
            printf("%d ", matriz[i][j]);
        }
        putchar(10);
    }   
    // Libero la memoria
    for (int i = 0; i < nfilas; i++)
    {
        free(matriz[i]);
        free(matriz);
    }
       
    
    return(0);
}