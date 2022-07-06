#include <stdio.h>

int main(void)
{
    int i = 0, n = 5;
    int j;

    for (; i <= 10; i++)
    {
        for (j = 1; j <= 10; j++)
        {
            printf("%d * %d = %d\n", i, j, i * j);
        }
        
    }
    putchar(10);
}