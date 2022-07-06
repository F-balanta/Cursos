#include <stdio.h>

int main()
{
	int a = 0, b = 0;
	printf("NUMERO MAYOR");
	printf ("*_*_*_*_*_**_*__*_*_*_*_*\n");

	printf("Digite el Primer Numero:\n");
	scanf("%d",&a);

	printf("Digite el segundo numero:\n");
	scanf("%d",&b);
	(a > b) ? printf("El numero mayor es %d\n", a) : printf("El numero mayor es %d\n", b);

	return(0);
}
