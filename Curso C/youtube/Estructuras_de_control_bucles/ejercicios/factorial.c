#include <stdio.h>

int main()
{
	int i,n,fact = 1;

	printf("\t\t Sacar el factorial de un numero\n");
	printf("Digite un numero al cual desea sacar su factorial: ");
	scanf("%i", &n);
	for (i = 1; i <= n; i++)
	{
		fact *= i;
	}
	printf("El factorial de %i es: %i\n", n, fact);

	return (0);
}
