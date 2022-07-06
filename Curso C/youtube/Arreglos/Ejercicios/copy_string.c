#include <stdio.h>
#include <string.h>

int main()
{
	char arrayO[30];
	char arrayD[30];

	printf("Este programa genera una copia de una Cadena de 30 elementos\n");
	printf("Empezaremos llenando esa cadena\n");
	printf("Digite su nombre completo\n");
	fgets(arrayO, sizeof(arrayO), stdin);
	printf("*****************************************\n");
	printf("****************RESULTADO****************\n");
	printf("*****************************************\n");
	strcpy(arrayD,arrayO);
	printf("Arreglo origen: %s\nArreglo Destino: %s",arrayO,arrayD);
	return (0);
}
