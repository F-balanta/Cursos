#include <stdio.h>

int main()
{
	int i,d,j, array[2][2][3] = {
		{0,1,2},
		{3,4,5}
	},
	{
		{5,6,7},
		{8,9,0}
	};

	for(i = 0; i < 2; i++)
	{
		for (d = 0; d < 2; d++)
		{
			for (j = 0; j < 3; j++)
			{
				printf("%d", array[i][d][j]);
			}
			putchar(10);

		}
		putchar(10);
	}

	return(0);
}
