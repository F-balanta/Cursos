#include <stdlib.h>
#include <stdio.h>
#include <time.h>

int azar(void);

int main(void)
{

    int n, a[10], i;
    srand(time(NULL)); // INVESTIGAR MAS

    for (i = 0; i < 10; i++)
    {
        n = azar(); 
        a[i] = n;
        printf("%d ", a[i]);
    }

    
    return(0);
}

int azar(void)
{
    return(rand() % 10 + 1);
}