#include <stdio.h>

int muestra(Colores);

enum Colores
{
    ROJO = 1, AMARILLO = 2, AZUL = 4, VERDE = 8, NARANJA = 16, NEGRO = 32,

    TODOS = ROJO | AMARILLO  | AMARILLO | AZUL | VERDE | NARANJA | NEGRO
};

int muestra(Colores)
{
    if(Colores & ROJO)
        printf("Rojo");
    if(Colores & AZUL)
        printf("Azul");
    
    if(Colores & VERDE)
        printf("Verde");
    if (Colores & NARANJA)
        printf("Naranja");

    if(Colores & NEGRO)
        printf("Negro");
}
int main(void)
{

    muestra(TODOS);
    return(0);
}