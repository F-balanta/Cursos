#include <stdio.h>

int main()
{
	int sump = 0,sumim = 0, i, n,neg, sumagral = 0;

	printf("Hasta que numero quieres realizar la suma: ");
	scanf("%i", &n);

	for(i = 1; i <= n; i++)
	{
		if(i % 2 == 0)
		{
			neg= i *(-1);
			sump +=neg;
		}
		else
		{
			sumim += i;
		}
	}
	sumagral = sump + sumim;
	printf("La suma de todo es de: %i\n", sumagral);
	return (0);
}
