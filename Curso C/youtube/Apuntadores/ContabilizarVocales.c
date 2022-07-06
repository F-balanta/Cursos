#include <stdio.h>

int main()
{
	int c, count = 0;

	printf("Digite su nombre y luego presione Ctrl + z\n");
	/*
	  Por qué presionar esa combinacion? para romper el ciclo while y pasar
	  directamente a la impresion.
	 */
	while (EOF != (c = getchar()))
	{
		switch (c)
		{
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':count++;
		}
	}
	printf("El numero de vocales es: %d", count);
	return (0);
}
