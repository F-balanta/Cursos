#include <stdio.h>

int main()
{
	float matriz[2][3];
	char  matriz2[2][3];
	int i, j;

	for (i = 0; i < 2; i++)
	{
		for (j = 0; j < 3; j++)
		{
			printf("Escribe un numero matriz [%i][%i]: ",i + 1, j + 1);
			scanf("%f", &matriz[i][j]);
		}
		putchar(10);
	}

	fflush(stdin);

	for ( i = 0; i < 2; i++)
	{
		for ( j = 0; j < 3; j++)
		{
			printf("%.2f ", matriz[i][j]);
		}
		putchar(10);
	}
	printf("Ahora vamos a llenar una Matriz de Caracteres\n");
	for( i = 0; i < 2; i++)
	{
		for ( j = 0; j < 3; j++)
		{
			printf("Escribe un Caracter para la matriz[%i][%i]: ", i + 1, j + 1);
			scanf("%c", &matriz2[i][j]);
		}
		putchar(10);
	}
	fflush(stdin);
	for (i = 0; i < 2; i++)
	{
		for ( j = 0; j < 3; j++)
		{
			printf("[%i]", matriz[i][j]);
		}
		putchar(10);
	}
	return (0);
}
