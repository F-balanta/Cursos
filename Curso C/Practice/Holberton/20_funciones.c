#include <stdio.h>
//prototipos
void hola(void);
void adios(void);
int suma(int a, int b);




//Funciones
void hola(void)
{
    printf("Hola Mundo \n");
}

int main(void)
{
    int r;
    hola();
    adios();
    r = suma(5, 5);
    printf("Suma: %d", r);
    return(0);
}

void adios(void)
{
    printf("Adios xd\n");
}

int suma(int a, int b)
{
   return(a + b);
}