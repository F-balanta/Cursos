#include <stdio.h>

int main()
{

	int j,d, arraybi[5][4] = {{0,1,2,3},
				  {3,4,5,6},
				  {6,7,8,9},
				  {9,0,1,2},
				  {2,3,4,5}};

	printf(" Arrays Bidimensionales\n");
	for (j = 0; j < 5; j++)
	{
		for (d = 0; d < 4; d++)
		{
			printf("%d ", arraybi[j][d]);
		}
		putchar(10);
	}
	putchar(10);
	return (0);
}
