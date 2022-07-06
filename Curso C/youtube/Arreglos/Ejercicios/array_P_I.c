#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define TAM 1000

int main()
{
	int i, numero[TAM], pares[TAM], impares[TAM];
	int n;

	srand(time(NULL));

	for ( i = 0; i < TAM; i++)
	{
		numero[i] = rand()% + (1000 +1);
	}

	printf("Pares:\n\n");

	for (i = i; i < TAM;i++)
	{
		if (numero[i] % 2 == 0)
		{
			printf("%i,\n", numero[i]);
		}
	}

	printf("Impares:\n\n");
	for (i = 0; i < TAM; i++)
	{
		if (numero[i] % 2 != 0)
		{
			printf("%i,\n", numero[i]);
		}
	}

	return (0);
}
