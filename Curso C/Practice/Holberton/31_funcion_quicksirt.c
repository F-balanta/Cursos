#include <stdio.h>
#include <stdlib.h>
//PENDIENTE
int compara_enteros(const void *p, const void *q);
int compara_flotantes(const void *p, const void *q);

int main(void)
{
    int a[] = {10, 6, -23, 48, 1, 2, 3, 7, 6, 5,}, i, j;

    float b[] = {1.87f, -7.45f, 90.56f, 3.456};

    int t1 = sizeof(a) / sizeof(int);
    int t2 = sizeof(b) / sizeof(float);

    qsort(a, t1, sizeof(int), &compara_enteros);
    qsort(b, t2, sizeof(float), &compara_flotantes);

    for (i = 0; i < t1; i++)
    {
        printf("%d ", a[i]);
    }
    putchar(10);
    for (j = 0; j < t2; j++)
    {
        printf("%f ", b[j]);
    }

    return(0);
}

int compara_enteros(const void *p, const void *q)
{
    int x, y;
    x = *(int *)p;
    y = *(int *)q;

    if (x > y)
        return(-1);
    if (x == y)
        return (0);
    return(1);
}

int compara_flotantes(const void *p, const void *q)
{
    float x, y;
    x = *(float *)p;
    y = *(float *)q;

    if (x > y)
        return(-1);
    if (x == y)
        return (0);
    return(1);
}