#include <stdio.h>

long factorial(int n);

int main()
{
	int n;

	printf("Excribe un nuemro para sacar su factorial:  ");
	scanf("%i", &n);

	printf("El factorial del numero es %li\n", factorial(n));
	return (0);
}

long factorial(int n)
{
	if (n <= 1)
	{
		return (1);
	}
	else
	{
		return(n * factorial(n-1));
	}
}
