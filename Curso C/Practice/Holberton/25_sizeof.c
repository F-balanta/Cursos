#include <stdio.h>

int main(void)
{
    int entero, flotante, doble, shor, longg, longlong_int;
    char caracter;
//Tamaño tipo de dato
    entero = sizeof(int);
    flotante = sizeof(float);
    doble = sizeof(double);
    caracter = sizeof(char);
    shor = sizeof(short);
    longg = sizeof(long);
    longlong_int = sizeof(long long int);

    printf("Entero %d\n", entero);
    printf("Flotante %d\n",flotante);
    printf("Doble %d\n", doble);
    printf("Short %d\n", shor);
    printf("Long %d\n" ,longg);
    printf("Long Long Int %d\n", longlong_int);
    
    printf("-----------------------------------------\n");
    //Tamaño de un puntero
    int x, *puntero;
    x = sizeof(puntero);
    printf("%d", x);
    printf("-----------------------------------------\n");

    int arreglo[10];
    int wa;
//Tamaño de un arreglo en bytes
    wa = sizeof(arreglo) / sizeof(int);
    printf("%d \n", wa);

    wa = sizeof(arreglo);
    printf("%d", wa);
    return(0);
}