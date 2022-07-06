#include <stdlib.h>
#include <stdio.h>


int main(void)
{

    int *a;
    a = (int *) calloc(5, sizeof(int));

    a[0] = 6;
    a[1] = 10;
    a[2] = 1999;
    a[3] = 654;
    a[4] = 7894;
    
    int x = sizeof(a);

    for (size_t i = 0; i <= x ; i++)
    {
        a[i];
        printf("%d \n", a[i]);
    }
    free(a);
    return 0;
}