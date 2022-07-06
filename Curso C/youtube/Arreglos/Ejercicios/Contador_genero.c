#include <stdio.h>
#include <string.h>

int main()
{
	int numero,i,varon = 0,mujer = 0;
	char alumnos[30];

	printf("Escribe el total de alumnos: ");
	scanf("%i", &numero);

	for(i = 1; i <= numero; i++)
	{
		fflush(stdin);
		printf("\n %i) Digite el sexo del alumn@: ", i);
		fgets(alumnos,30,stdin);

		if (strcmp(alumnos,"masculino") == 0)
		{
			varon++;
		}
		else if (strcmp(alumnos,"femenino") == 0)
		{
			mujer++;
		}
	}
	printf("Total Hombres: %i\n", varon);
	printf("Total mujeres: %i\n", mujer);


	return (0);
}
