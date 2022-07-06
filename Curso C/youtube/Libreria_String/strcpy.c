#include <stdio.h>
#include <string.h>
/*
Strcpy es una funcion de la libreria string.h que permite copiar una cadena en otra.
hay que tener en cuenta que el tamaño del array de destino debe ser considerable o mayor
al array de origen.

STRCPY sobrescribe el contenido de el lugar de destino.
 */
int main()
{
	char origen[] = "Programacion";
	// teniendo en cuenta el tamaño del array origen son 12 caracteres.
	// el tamaño del lugar de destino debe ser igual o mayor
	char destino[12];
	// ahora hacemos uso de la funcion
	strcpy(destino,origen);
	// Y mostraqmos el contenido del array a continuacion.
	printf("%s\n", destino);
	return (0);
}
