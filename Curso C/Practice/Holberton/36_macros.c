#include <stdio.h>
#define M(a, b ,c) a;  b; c; //a las macros se les pueden asignar parametros como instrucciones.
#define Suma printf("%d \n", a + b);
// las macros son directivas del microprocesador que sirven para sustituir codigo

int main(void)
{

    int a = 5, b = 5, result;
    Suma
    
    printf("%d \n", result);
    printf("----------------------------------\n");

    int x;
    
    M(printf("Hola \n"), printf("Adios \n"), x = 7);
    printf("%d ", x);
    return(0);
}