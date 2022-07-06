#include <stdio.h>

void suma(int matriz1[2][3], int matriz2[2][3])
{
	int i, j, suma[2][3];

	for(i = 0; i < 2; i++)
	{
		for (j = 0; j < 3; j++)
		{
			suma[i][j] = matriz1[i][j] + matriz2[i][j];
		}
	}
	for(i = 0; i < 2; i++)
        {
                for (j = 0; j < 3; j++)
                {
			printf("[%d]", suma[i][j]);
                }
		putchar(10);
        }
}
int main()
{
	int matriz1[2][3] = {{1,2,3},{4,5,6}};
	int matriz2[2][3] = {{7,8,9},{9,8,7}};

	printf("*_*____________________________________________*_*\n\n");
	printf("Este programa realiza una suma entre 2 matrices\n");
	printf("*_*____________________________________________*_*\n");

	suma(matriz1,matriz2);
	return (0);
}
