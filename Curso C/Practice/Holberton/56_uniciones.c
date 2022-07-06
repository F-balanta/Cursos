#include <stdlib.h>
#include <stdio.h>

typedef union Persona Persona;

union Persona
{
    char nombre[50];
    char inicial;
};

int main(void)
{

    Persona Juan = {"Felipe"};

    printf("Nombre %s\n%s Inicial: ", Juan.nombre, Juan.inicial);
    return (0);
}