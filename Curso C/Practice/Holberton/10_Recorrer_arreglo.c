#include <stdio.h>

int main(void)
{
    int a[10];
    int tam = sizeof(a) / sizeof(int);
    int i = 0;

         while (i < tam)
    {   
        a[i] = i;
        printf("%d ",a[i] );
        i++;
    }
    
}