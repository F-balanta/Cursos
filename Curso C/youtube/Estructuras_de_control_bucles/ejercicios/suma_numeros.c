#include <stdio.h>

int main()
{
	int numero, suma = 0, i = 0;
	printf("Digite la cantidad de numeros a sumar: \n");
	scanf("%i", &numero);
	while(i <= numero)
	{
		suma +=i;
		printf("Suma vale %i\n", suma);
		i++;
	}
	return (0);
}
