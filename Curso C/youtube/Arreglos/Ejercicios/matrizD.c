#include <stdio.h>

int main()
{
	int matriz[50][50], filas, columnas, i,j;

	printf("Digita el numero de Filas: ");scanf("%i", &filas);
	printf("Digita el numero de Columnas: ");scanf("%i", &columnas);

	putchar(10);
	putchar(10);

	for (i = 0; i < filas; i++)
	{
		for (j = 0; j < columnas; j++)
		{
		printf("Escribe el valor de la posicion[%i][%i] == ", i, j);
		scanf("%i", &matriz[i][j]);
		}
	}

	for (i = 0; i < filas; i++)
	{
		for (j = 0; j < columnas; j++)
		{
			printf("[%i] ", matriz[i][j]);
		}
		putchar(10);
	}
	return (0);
}
