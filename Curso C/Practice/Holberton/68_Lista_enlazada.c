#include <stdio.h>
#include <stdlib.h>

typedef struct nodo
{
     int dato;
     struct nodo *siguiente;
}NODO;


NODO *crearNodo(int dato);

int main()
{
    return(0);
}


NODO *crearNodo(int dato)
{
    NODO *nuevo = NULL;

    nuevo = (NODO *)malloc(sizeof(NODO));
    if(nuevo != NULL){
        nuevo->dato =dato;
        nuevo->siguiente = NULL;
    }
}