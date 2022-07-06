#include <stdio.h>

struct persona{
	char nombre[20];
	int edad;
}persona1 = {"jorge", 19},
persona2 = {"Ricardo",18};
int main()
{
	printf("Su nombre es: %s\n",persona1.nombre);
	printf("Su edad es: %d\n", persona1.edad);

	printf("Su nombre es: %s\n", persona2.nombre);
	printf("Su edad es: %d\n",persona2.edad);


	return (0);
}
