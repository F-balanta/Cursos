#include <stdio.h>

void agregar(int a)
{
	a += 10;
}
int main()
{
	int numero;
	printf("Escribe un numero\n");
	scanf("%d", &numero);
	printf(" \n valor antes de la funcion: %d", numero);
	agregar(numero);
	printf("\nValor despues  de la funcion %d", numero);
	return(0);
}
