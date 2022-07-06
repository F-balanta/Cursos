#include <stdio.h>

typedef int entero;
typedef int array[10];

int main(void)
{
    array a;
    entero i;

    for (i = 0; i < 10; i++)
    {
        a[i] = i;
        printf("%d ", a[i]);
    }
           printf("\n----------------------------------------------------------\n");
    array  x[10];
    int j, y;

    for ( j= 0; j < 10; j++)
    {
        
        for (y = 0; y < 10; y++)
        {
            x[j][y] = j;
            printf("%d ", x[j][y]);
        }
        putchar(10);
    }
    

    return(0);
}