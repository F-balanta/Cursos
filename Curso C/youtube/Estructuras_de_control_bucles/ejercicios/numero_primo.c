#include <stdio.h>

int main()
{
	int i, n, cont = 0;

	printf("Digita un numero para validar si es primo o no: ");
	scanf("%i", &n);

	for (i = 1; i < n; i++)
	{
		if(n % i == 0)
		{
			cont++;
		}
	}
	if (cont > 2)
	{
		printf("El numero %i no es primo\n", n);
	}
	else
	{
		printf("El numero ingresado es primo :)\n");
	}
	return (0);
}
