#include <stdio.h>


int main()
{
    FILE *archivo = fopen("prueba.txt", "at");

    if (archivo == NULL)
    {
        printf("No se ha podido abrir el archivo");
    }
    else
    {
        putc('J', archivo);
    }

    fclose(archivo);

    return (0);
}