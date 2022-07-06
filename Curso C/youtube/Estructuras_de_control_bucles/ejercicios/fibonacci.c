#include <stdio.h>

int main()
{
	int i, n,x = 0, y = 1, z = 1;

	printf("\n\n\nLa serie fibonacci indica que  tenemos que ir sumando un numero con el anterior\n Y para sacar el tercer elemento  hay que sumar los anteriores\n");
	printf("Digite digitre el numero de elementos: ");
	scanf("%i", &n);

	printf("1 + ");

	for (i = 1; i < n; i++)
	{
		z = x + y;
		x = y;
		y = z;
		printf("%i + ", z);
	}
	putchar(10);
	return (0);
}
