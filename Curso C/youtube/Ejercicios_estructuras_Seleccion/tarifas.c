#include <stdio.h>
#define tarifa1 "Basica"
#define tarifa2 "Intermedia"
#define tarifa3 "premium"
int main()
{
	float precio;

	printf("Digite el monto a pagar por el plan:\n");
	scanf("%f", &precio);

	if(precio < 500 && precio >= 100)
		printf("El plan es %s\n", tarifa1);

	if ((precio > 500) && ( precio <= 1000))
		printf("El plan es %s\n", tarifa2);

	if (precio >= 1000 && precio <= 1500)
		printf("El plan es %s\n", tarifa3);

	return (0);
}
