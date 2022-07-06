#include<stdio.h>

struct infoDireccion{
	char direccion[30];
	char ciudad[30];
	char provincia[30];
};
struct empleado{
	char nombre[30];
	struct infoDireccion dirEmpleado;
	int edad;
	double salario;
}empleados[2];

int main()
{
	//Empezaremos pidiendo los datos
	int i;
	for (i = 0; i < 2; i++)
	{
		fflush(stdin);
		printf("-----_Empleado [%d]_-----\n\n", i+1);
		printf("Digite su nombre: ");
		scanf("%s", empleados[i].nombre);
		printf("Ingrese su direccion: ");
		scanf("%s", empleados[i].dirEmpleado.direccion);
		printf("Ciudad: ");
		scanf("%s", empleados[i].dirEmpleado.ciudad);
		printf("Provincia: ");
		scanf("%s", empleados[i].dirEmpleado.provincia);
		printf("Digite su edad: ");
		scanf("%d", &empleados[i].edad);
		printf("Digite su salario: ");
		scanf("%lf", &empleados[i].salario);
	}
	// Y terminamos mostrando los datos obtenidos
	for (i = 0; i < 2; i++)
	{
		printf("-----------------------------\n\n");
		printf("EMPLEADO [%d]\n\n", i + 1);
		printf("NOMBRE: %s\n", empleados[i].nombre);
		printf("DIRECCION: \n%s",empleados[i].dirEmpleado.direccion);
		printf("CIUDAD: %s\n", empleados[i].dirEmpleado.ciudad);
		printf("PROVINCIA: %s\n", empleados[i].dirEmpleado.provincia);
		printf("EDAD: %d\n", empleados[i].edad);
		printf("SALARIO: %f\n", empleados[i].salario);
	}

}
