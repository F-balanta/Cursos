#include <stdio.h>

int main(void)
{   
    int x, y, z, u, v;
    x = 10;
    y = 20;
    z = 30;
    u = 40;
    v = 50;
    int *arreglo[10];

    arreglo[0] = &x;
    arreglo[1] = &y;
    arreglo[2] = &z;
    arreglo[3] = &u;
    arreglo[4] = &v;
    for (int i = 0; i < 10; i++)
    {
        arreglo[i];
        printf("Arreglo %d \n", *arreglo[i]);
    }
    
    printf("---------------------------");
    *arreglo[0] = 584;
    *arreglo[1] = 123;
    *arreglo[2] = 187;
    *arreglo[3] = 032;
    *arreglo[4] = 179;
    return(0);
}