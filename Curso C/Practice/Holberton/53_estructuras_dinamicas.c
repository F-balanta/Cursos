#include <stdio.h>
#include <stdlib.h>


typedef struct Persona
{
    char *nombre;
    int edad;
    float salario;

}Persona;


void imprime(const Persona *p);


int main(void)
{
    Persona *Juan, *Pedro, *Maria;

    Juan = (Persona *)malloc(sizeof(Persona));
    Pedro =(Persona *)malloc(sizeof(Persona));
    Maria = (Persona *)malloc(sizeof(Persona));

    Juan->nombre = "Juan Felipe";
    Juan->edad = 21;
    Juan->salario = 5000.0f;

    Pedro->nombre = "Pedro Mauricio";
    Pedro->edad = 45;
    Pedro->salario = 1000.0f;

    Maria->nombre = "Maria Alejandra";
    Maria->edad = 52;
    Maria->salario = 3000.0f;

    imprime(Juan);
    imprime(Maria);
    imprime(Pedro);
    free(Juan);
    free(Pedro);
    free(Maria);

    return(0);
}

void imprime(const Persona *p)
{
    printf("Nombre %s \n", p->nombre);
    printf("Edad %d \n", p->edad);
    printf("Salario %f \n", p->salario);
    putchar(10);
}