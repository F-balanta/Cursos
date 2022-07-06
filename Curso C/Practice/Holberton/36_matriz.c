#include <stdio.h>

int main(void)
{
    int array[3][3] ={
        {1, 2, 3},
        {5, 6, 7},
        {4, 5, 6}};

    int i, j;

    for ( i = 0; i < 3; i++)
    {
        for ( j = 0; j < 3; j++) 
        {
            printf("%d ", array[i][j]);
        }
        printf("\n");
    }
    return(0);
}