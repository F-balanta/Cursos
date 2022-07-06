#include <stdio.h>

typedef struct Punto Punto;
struct Punto
{
    float x, y;
};

void punto_muestra(const Punto *p);

int main(void)
{
    Punto coordenadas[5] = 
    {
   {25.5f, 45.5f}, {12.5f, 45.5f}, {78.1, 45.5f}, {123.54, 45.5f}, {8795.45, 45.5f}};

    /*coordenadas[0].x = 0.0f;
    coordenadas[0].y = 5.0f;

    coordenadas[1].x = 4.5f;
    coordenadas[1].x = 3.45f;

    coordenadas[1].x = 5.55;
    coordenadas[1].x = -709.987f;
*/
    int t= sizeof(coordenadas) / sizeof(float) / 2;
    for (int i = 0; i < t ; i++)
    {
        punto_muestra(&coordenadas[i]);    
    }
    
    
}

void punto_muestra(const Punto *p)
{
    printf("(%f %f)\n", p->x, p->y);
}