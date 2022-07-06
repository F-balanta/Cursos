#include <stdio.h>

int posicion(int n, int a[], int tam);
int main()
{
    int numeros[] = {1, 10, 20, 500, 4000, 2, 23, 4, 4, 4, 11, 11, 2};

    int t = sizeof(numeros) / sizeof(int);
    int pos = posicion(4, numeros, t);
    printf("Posicion %d\n", pos);
}

int posicion(int n, int a[], int tam)
{
    for (int i = 0; i < tam; i++)
        if (a[i] == n)
        return(i);
    return(-1);
    
}