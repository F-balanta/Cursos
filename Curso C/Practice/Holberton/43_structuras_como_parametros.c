#include <stdio.h>
typedef struct Persona Persona;

struct Persona
{
    char *nombre;
    int edad;
    float salario;
};

void persona_muestra(Persona *p);

int main(void)
{
    Persona pedro = {"Pedro", 25, 1000.0f};
    Persona David = {"David Balanta", 21, 5000.0f};

    persona_muestra(&pedro);
    persona_muestra(&David);
    /* Al enviar el contenido de la estructura a nuestra funcion envia una copia  de todas las viarables como parametros
    la variable que recibe estos datos queda sobrecargada.
    Para evitar que eso pase  utilzamos un puntero.
    */
    return(0);
}

void persona_muestra(Persona *p)
//Si no se quiere modificar el valor de las variables  podemos agregarle el const para  indicarle al programa que no  permita cambios en estas.
//ejemplo void persona_muestra(CONST Persona *p).

{/*Para poder utilizar ese puntero utilizamos  -> en vez del . ejemplo = printf("Nombre %s\n", p ->nombre);
 ESTO SOLO APLICA CUANDO UTILIZAMOS PUNTEROS EN ESTRUCTURAS.*/
    printf("Nombre %s\n", p->nombre);
    printf("Edad %d \n", p->edad);
    printf("Salario %f \n\n", p->salario);
}