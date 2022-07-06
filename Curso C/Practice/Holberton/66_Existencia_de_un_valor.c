#include <stdio.h>

int existe(int n, int a[], int tam);
int main()
{
    int numeros[] = {1, 10, 20, 500, 4000, 2, 23, 4, 4, 4, 11, 11, 2};

    int t = sizeof(numeros) / sizeof(int);
    if(existe(4, numeros, t))
        printf("Si existe.");
    else
        printf("No existe");
    return(0);
}

int existe(int n, int a[], int tam)
{
    for (int i = 0; i < tam; i++)
        if (a[i] = n)
        return(1);
    return(0);
    
}