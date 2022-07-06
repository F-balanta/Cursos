#include <stdio.h>

void copy(int a[],int t);

int main()
{
	int origen[10],i;
	int tama = sizeof(origen) / sizeof(int);

	for(i = 0; i < tama; i++)
	{
		printf("Digite el valor %i: ",i);
		scanf("%i", &origen[i]);
	}
	printf("Copiando Array\n...\n...\n");

	copy(origen,tama);
	return (0);
}

void copy(int a[], int t)
{
	int i;
	int destino[10];
	if(a == NULL || t < 0)
		printf("El array esta vacio");
	else
	{
		for(i = 0; i < t; i++)
		{
			destino[i] = a[i];
		}
		for(i = 0;i <t; i++)
		{
			printf("El contenido del array destino es: %i \n", destino[i]);
		}
		putchar(10);
		for(i = 0;i <t; i++)
                {
                        printf("El contenido del array origen es: %i \n", a[i]);
                }
	}
}
