#include <stdio.h>

typedef struct Persona
{
    char *nombre;
    int edad;
    float salario;
}Persona;


int main(void)
{
     Persona Juan, Pedro, David;
    Juan.nombre = "JUan Felipe Balanta Renteria";
    Juan.edad = 21;
    Juan.salario = 778.585;

    Pedro.nombre = "Pedro  minia";
    Pedro.edad = 56;
    Pedro.salario = 789;

    David.nombre = "Juan David Balanta Renteria";
    David.edad = 21;
    David.salario =156.804;
    return(0);
}