#include <stdlib.h>
#include <stdio.h>

int main(void)
{
    int *a, *b;

    a = (int *)calloc(5,sizeof(int));
    int t = sizeof(a);
    for (int i = 0; i <= t; i++)
    {
        a[i] = i;
        printf("%d \n", a[i] );
        
    }

    b = (int *)calloc(5, sizeof(int));

    for ( int i = 0; i <=t; i++)
    {
        b[i] = a[i];
    }
    

    free(a);

    a = (int *)calloc(10, sizeof(int));
    for (int i = 0; i <= t; i++)
    {
        a[i] = b[i];
    }
       free(b);
    int t2 = sizeof(a);
    for (int i = 0; i <= t2; i++)
    {
        a[i];
        printf("%d \n", a[i]);
    }
    
    free(a);
 
return(0);
}