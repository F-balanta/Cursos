#include <stdio.h>

void funcion(int (*p)(int, int));
int suma(int a, int b);
int resta(int a, int b);
int multiplicacion( int a, int b);
int  division(int a, int b);
int modulo( int a, int b);

int main(void)
{
    funcion(suma);
    funcion(resta);
    funcion(multiplicacion);
    funcion(division);
    funcion(modulo);
    return(0);
}
int suma(int a, int b)
{
    printf("Suma de A + B: ");
    return(a + b);
}

void funcion(int (*p)(int, int))
{
    int x;

    x = p(5 , 4);

    printf("%d \n", x);
}

int resta(int a, int b)
{
    printf("Resta de A + B: ");
    return(a - b);
}
int multiplicacion( int a, int b)
{
    printf("A Multiplicado B: ");
    return(a * b);
}
int  division(int a, int b)
{
    printf("A Dividido B: ");
    return(a / b);
}
int modulo( int a, int b)
{
    printf("A Modulo de B: ");
    return (a % b);
}