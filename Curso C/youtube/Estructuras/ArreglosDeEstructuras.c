#include<stdio.h>

struct persona{
	char nombre[30];
	int edad;
}personas[5];//arreglo de estrucututa persona1, persona2, persona3...

int main()
{
	int i;

	for (i = 0; i < 5; i++)
	{
		//Pedimos los datos y los almacenamos en sus variables
		fflush(stdin);
		printf("Digite su nombre, Usuario [%d]: ", i + 1);
		scanf("%s", personas[i].nombre);
		printf("Digite su edad, usuario [%d]: ",i + 1);
		scanf("%d", &personas[i].edad);
	}
	for (i = 0; i < 5; i++)
	{
		printf("------Usuario [%d]-----\n\n", i + 1);
		printf("Nombre: %s\n",personas[i].nombre);
		printf("Edad: %d\n\n----------------------", personas[i].edad);
	}

}
