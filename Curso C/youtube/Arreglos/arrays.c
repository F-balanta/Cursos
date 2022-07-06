#include <stdio.h>

int main()
{

	int array[5], i, a;

	printf("Arrays Unidimensionales\n");
	for (i = 0; i < 5; i++)
	{
		printf("Digite numero %i:  ", i);
		scanf("%d", &array[i]);
	}
	for (a = 0; a < 5; a++)
	{
		printf("%d ",array[a]);
	}
	putchar(10);
	return (0);
}
