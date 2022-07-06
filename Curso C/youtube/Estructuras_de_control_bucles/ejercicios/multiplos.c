#include <stdio.h>

int main()
{
	int n,i;

	printf("Digite hasta que numero mostrar los multiplos de 5:");
	scanf("%i", &n);
	for(i = 1; i <= n; i++)
	{
		if (i % 5 == 0)
		{
			printf("%i ", i);
		}
	}
	putchar(10);
	return (0);
}
