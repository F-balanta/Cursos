#include <stdio.h>
void BinarioPuro(int array[], int l);
void Puntofijo(int array[]);
void Complemento2(int array[]);
int main()
{
	int array[10], i, l = 0, opcion = 0;
	l = sizeof(array) / sizeof(int);
	printf("\n\n*******************__BIENVENIDO__*****************\n\n\n");
	printf("Este programa es un conversor de Numero Binario\n\n\n");
	printf("Empecemos llenado un arreglo de 10 Elementos con numeros entre 0 y 1\n\n");

	for(i = 0; i < l; i++)
	{
		printf("Digita el valor de la P[%i] == ", i);
		scanf("%i", &array[i]);
	}
	printf("Escoge una opcion\n\n");
	printf("*1). Binario Puro\n");
	printf("*2). Punto fijo *6 bit entero y 4 bit decimal*\n");
	printf("*3). Complemento");
	scanf("%i", &opcion);

	switch(opcion)
	{
	case 1:
		printf("*******************************************************\n");
		printf("************Seleccionaste _-Binario Puro-_*************\n");
		printf("*******************************************************\n");
		BinarioPuro(array, l);
		break;
	case 2:
		printf("Seleccionaste _-Punto Fijo-_\n");

                break;
	case 3:
		printf("Seleccionaste _-Complemento a 2-_\n");

                break;
	}
	return (0);
}

void BinarioPuro(int array[], int l)
{
	int valor = 512, suma = 0,i;

	for(i = 0; i < l; i++)
	{
		if (array[i] == 1)
		{
			suma += valor;
		}
		valor /= 2;
	}
	printf("El valor  en decimal es: %i\n", suma);

}
