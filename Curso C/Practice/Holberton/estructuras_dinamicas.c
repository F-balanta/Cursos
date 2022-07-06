#include <stdlib.h>
#include <stdio.h>

typedef struct contacto
{
    int edad;
    int tel;
}contacto;


int main(void)
{
    contacto *contacto1 = malloc(sizeof(contacto));

    contacto1->edad = 5;
    contacto1->tel = 6638954;

    printf("Edad: %d \n", contacto1->edad);
    printf("Telefono: %d \n", contacto1->tel);
    free(contacto1);
    return(0);
}