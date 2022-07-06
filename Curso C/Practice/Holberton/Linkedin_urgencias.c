#include <stdio.h>
#include <stdlib.h>

int main()
{   
    int consultaLibres, numAvisos = 0;
    int *OrdenesConsultasLibres = (int *)malloc(numAvisos * sizeof(int));
    puts("Unidad de Urgencias..");
    puts("_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*");
    while (1)
    {    
        printf("Introduce la consulta que se ha quedado libre: ");
        scanf("%d", &consultaLibres);
        numAvisos++;
        OrdenesConsultasLibres = (int *) realloc(OrdenesConsultasLibres, numAvisos * sizeof(int));
        OrdenesConsultasLibres[numAvisos - 1] = consultaLibres;
    }
    
    return 0;
}