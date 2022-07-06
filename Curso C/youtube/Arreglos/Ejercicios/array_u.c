#include <stdio.h>

int main()
{
	int i = 0,j,d,c, array[2][3][5];

	printf("\t\tLlenar Arreglo Tridimensional\n");
	for(j = 0; j < 2; j++)
	{
		for(d = 0; d < 3; d++)
		{
			for(c = 0; c < 5; c++)
			{
				array[j][d][c] = i;
				i++;
			}
		}
	}
	for(j = 0; j < 2; j++)
	{
		printf("Dimension %d : \n", j);
		for (d = 0; d < 3; d++)
		{
			for (c = 0; c < 5; c++)
			{
				printf("[%d]", array[j][d][c]);
			}
			putchar(10);
		}
		putchar(10);
	}
	return (0);
}
