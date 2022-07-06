#include <stdio.h>
void muestra(int p[], int tama);

int main(void)
{   //Declaro un arreglo
    int arreglo[] = {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000};
    // De esta forma se puede sacar el tamaño de un arreglo
    int tama = sizeof(arreglo) / sizeof(int);
    muestra(arreglo, tama); //llamo la funcion y le asigno 2 parametros ( el Arreglo y el tamaño del arreglo)
    printf("%d ", tama);// Muestro en pantalla el tamaño del arreglo
   return(0);
}
/*
Esta funcio me recibe 2 parametros el arreglo en si t el tamaño de larreglo.
*/
void muestra(int p[], int tama)
{
    int i;

    for ( i = 0; i < tama; i++)
    {
        printf("%d ",p[i]); //creo un bucle que me rrecorra el arreglo con la posicion de i
    }
    
}