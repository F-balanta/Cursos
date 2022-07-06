#include <stdio.h>

int main()
{
	int i, suma = 0;

	for (i = 1; i <= 20; i++)
	{
		if (i % 2 == 0)
		{
			printf("El valor de suma es %i\n", suma);
			suma +=i;
		}
	}
	return (0);
}
