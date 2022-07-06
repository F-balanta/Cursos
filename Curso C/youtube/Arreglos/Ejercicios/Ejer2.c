#include <stdio.h>

void opcion1(int *array, int l);
void opcion2(int *array, int l);
void opcion3(int *array, int l);
void opcion4(int *array, int l);
int main()
{
	int i,p,c_array,valor,l,ciclo = 1,opcion,array[10];

	putchar(10);
	printf("**********************************************************\n");
	printf("**********************_Bienvenido_************************\n");
	putchar(10);
	for (i = 0; i < 10; i++)
	{
		printf("Digite el %d elemento del array: ", i);
		scanf("%d", &array[i]);
	}
	while(ciclo)
	{

		printf("\n\n");
		printf("*__________________________________________________*\n");
        	printf("Que operacion desea realizar?.\n");
		printf("*0). Mostrar Datos\n");
		printf("*1). Modificar/editar arreglo.\n");
		printf("*2). Sumar todos los elementos.\n");
		printf("*3). Multiplicar todos los elementos.\n");
		printf("*4). Suma de elementos divisibles entre 3.\n");
		printf("*5). Multiplicar por 3 cada elemento del arreglo.\n");
		printf("*6). Salir.\n");
		printf("*__________________________________________________*\n");
		putchar(10);
		printf("Opcion: ");scanf("%i", &opcion);
		l = sizeof(array)/sizeof(int);
		switch(opcion)
		{
		case 0:
			for (i = 0; i < l; i++)
			{
				printf("Posicion [%i] == -%i-\n", i, array[i]);
			}
		case 1:
			printf("*1). Modificar una posicion del arreglo\n");
			printf("*2). Modificar todo el arreglo\n");
			printf("Opcion: ");scanf("%i", &c_array);
			switch(c_array)
			{
			case 1:

				for(i = 0; i < l; i++)
				{
					printf("Posicion[%i] == -%i-\n", i, array[i]);
				}
				printf("Que posicion desea modificar?: ");
				scanf("%i", &p);
				printf("Esta modificando la Posicion [%d]\n",p);
				printf("Ingrese un valor: ");
				scanf("%i", &valor);
				array[p] = valor;
				for(i = 0;i < l; i++)
					printf("array[%i] == %i\n", i, array[i]);
				break;
			case 2:
				for(i = 0; i < l ;i++)
				{
					printf("posicion[%i] == %i\n", i, array[i]);
				}
				for(i = 0;i < l; i++)
				{
					printf("Digite el valor para el array[%d] == ", i);
					scanf("%i", &array[i]);
				}
				for(i = 0; i < l; i++)
				{
					printf("Nuevo array p[%i] == %i\n", i,array[i]);
				}
				break;
			}
			break;
		case 2:
			opcion1(array, l);
			break;
		case 3:
			opcion2(array, l);
			break;
		case 4:
			opcion3(array, l);
			break;
		case 5:
			opcion4(array, l);
		case 6:
			printf("Gracias por utilizar nuestros servicios\n Good Bye :)\n");
			ciclo = 0;
			break;
		};
	}
	putchar(10);
	return (0);
}
void opcion1(int *array, int l)
{
	int i,opecn;

	for(i = 0; i < l; i++)
	{
		opecn += array[i];
	}
	printf("Resultado:  %d\n", opecn);
}
void opcion2(int *array, int l)
{
        int i,opecn;

	opecn = 1;
	for (i = 0; i < l; i++)
	{
		opecn *= array[i];
	}
	printf("Resultado:  %d\n", opecn);
}
void opcion3(int *array, int l)
{
        int i,opecn;

	for (i = 0; i < l; i++)
	{
		if (array[i] % 3 == 0)
		{
			opecn +=array[i];
		}
	}
	printf("Resultado:  %d\n", opecn);
}
void opcion4(int *array, int l)
{
        int i,opecn;

	for(i = 0; i < l; i++)
	{
		opecn = array[i] * 3;
		printf("Resultado:  %d\n", opecn);
	}
}
