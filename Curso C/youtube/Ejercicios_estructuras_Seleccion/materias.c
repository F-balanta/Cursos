#include <stdio.h>

int main()
{
	int materias = 0;

	printf("Cuantas materias reprobaste?\n");
	scanf("%i", &materias);

	(materias > 3) ? printf("Reprobaste\n"): printf("Aprobaste\n");
	return (0);
}
