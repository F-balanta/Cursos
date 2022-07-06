#include <stdio.h>
//Inline es solo para funciones de una sola funcion.
inline int suma(int a, int b)
{
    
    return(a + b);
}
int main(void)
{
    int x =suma(3, 4);
    printf("%d ", x);
    return(0);
}