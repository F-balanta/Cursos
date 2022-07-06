#include <stdio.h>

int main(void)
{

    char *palabra = "Hola";
    char otra[] = "Adios";

    printf("%s \n", palabra);
    printf("%s \n", otra);
 //arreglo de caracteres
     char *palabras[] = {"Hola", "Adios", "Como estas?"};

     int t =sizeof(palabras) / sizeof(char *);

     for( int i = 0; i < t; i++)
        printf(("%s", palabras[i]));
    return(0);
}