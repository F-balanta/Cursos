#include <stdio.h>

int main()
{
	int array[8],i,total = 0,tama;
	float promedio;

	tama = sizeof(array) / sizeof(int);


	for (i = 0; i < tama; i++)
	{
		printf("Digita el valor[%i] == ",i);scanf("%i", &array[i]);
		total = total + array[i];
	}
	promedio = total / tama;
	printf("El promedio es: %.2f",promedio);
	return (0);
}
