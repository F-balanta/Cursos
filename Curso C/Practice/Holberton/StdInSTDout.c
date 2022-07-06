#include <stdio.h>

int main()
{   
    int x;
    printf("Digite un numero: ");
    FILE *archivo;
    archivo = stdin;
    fscanf(archivo, "%d", &x);

    printf("El valor ingresado es: %d", x);
    

    /*
    FILE *archivo;

    archivo = stdout;
    fprintf(archivo, "Texto nuevo");*/

    return(0);
}