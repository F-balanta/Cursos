#include <stdio.h>

int main(void)
{
    int a;

    void *puntero;
    a = 5;
    puntero = &a;

    printf("%d ", *(int *) puntero);

 printf("- - - - - - - - - - - - - - - - - - -- - -- - - - - - - - - - - - -\n");
    int x = 10;
    float y = 15.2f;

    void *p;
    void *q;
    
    p = &x;
    q = &y;

    printf("%d ", *(int *) p);

    printf("%f ", *(float *) q);

    return(0);
}