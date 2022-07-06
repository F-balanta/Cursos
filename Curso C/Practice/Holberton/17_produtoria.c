#include <stdio.h>

int main(void)
{
int i, producto = 1;

    for ( i = 1; i <= 10; i++)
    {
        producto *= i;
    }
    printf("%d\n", producto);
    
    return(0);
}