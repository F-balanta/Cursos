#include <stdio.h>
#include <string.h>
#define TAM 20

int main()
{
	char aux[TAM],nombre1[TAM],nombre2[TAM];

	printf("Digita el nombre 1: ");
	fgets(nombre1,TAM,stdin);

	printf("Digita el nombre 2: ");
	fgets(nombre2,TAM,stdin);

	strcpy(aux,nombre1);
	strcpy(nombre1,nombre2);
	strcpy(nombre2,aux);

	printf("El primer nombre es: %s",nombre2);
	printf("El segundo nombre es : %s", nombre1);

	return (0);
}
