#include <stdio.h>

int main(void)
{
    float arreglo[10] = {1.0f, 5.0f, 34.6f, 6.8f, 8.94f, 6.5f, 3.2f, 1.0, 2.0, 3.0f,};
    float suma= 0.0;
    int i;
    float r;
    for ( i = 0; i < 10; i++)
        suma = suma + arreglo[i];
    r= suma /10;
    printf("%.3f", r);

    
    return(0);

}