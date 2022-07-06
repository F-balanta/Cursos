#include <stdio.h>

struct persona{
	char nombre;
	int edad;

}persona1,persona2;

int main()
{

	printf("Digite su nombre: ");
	scanf("%s", &persona1.nombre);
	printf("Digite su edad: ");
	scanf("%d", &persona1.edad);

	printf("\n\nAhora la Segunda persona\n\n");
	fflush(stdin);
	printf("Digite su nombre: ");
	scanf("%s", &persona2.nombre);
	printf("Digite su edad: ");
	scanf("%d", &persona2.edad);

	printf("\n\nPrimer sujeto:\n");
	printf("Su nombre es: %s\n", &persona1.nombre);
	printf("Su edad es: %d\n", persona1.edad);

	printf("\nSegundo Sujeto\n");
        printf("Su nombre es: %s\n", &persona2.nombre);
        printf("Su edad es: %d\n", persona2.edad);
	return (0);
}
