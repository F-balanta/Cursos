#include <stdio.h>

int main()
{
	int opcion;
	float agregar, retirar, saldo = 3000;
	printf("\t*****************************************\n");
	printf("\t Simulador de Tiendao Cajero\n");
	printf("\t*****************************************\n");

	printf("\t Selecciona un opcion\n");
	printf("\n1) Depositar Dinero\n");
	printf("\n2) Retirar Saldo\n");
	printf("\n3) Salir del Cajero\n");
	printf("\t\nOpcion seleccionada: ");
	scanf("%i", &opcion);
	switch(opcion)
	{
	case 1:
		printf("Cuanto dirnero quiere depositar?\n");
		scanf("%f", &agregar);
		saldo += agregar;
		printf("Tu saldo es de %f\n", saldo);
		break;
	case 2:
		printf("Cuanto dinero quiere retirar?\n");
		scanf("%f", &retirar);
		if (retirar > saldo)
		{
			printf("Tu saldo disponible es solo de %f\n", saldo);
		}
		else
		{
			saldo -= retirar;
			printf("Tu saldo es de %f\n", saldo);
		}
		break;
	case 3:
		printf("Gracias por utilizar nuestro servicio");
		break;
	}

	return (0);
}
