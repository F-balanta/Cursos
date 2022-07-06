#include <stdio.h>

int main()
{
	int a[10] = {2,4,6,8,1,3,5,7,9};
	int i, dato;
	char band = 'F';

	printf("\n************************__********************\n");
	printf("Este programa realiza una busqueda de un numero e indica en que posicion se encuentra dicho numero.\n\n");
	printf("\n************************__********************\n\n");

	printf("Escribe un numero: ");scanf("%i", &dato);

	i=0;
	while ((band == 'F') && (i < 10)){
		if (a[i] == dato){
			band = 'V';
		}
		i++;
	}

	if (band == 'F'){
		printf("El numero no existe en la lista\n");
	}else if (band == 'V'){
		printf("El numero existe, en la posicion %i\n",i);
	}

	return (0);
}
