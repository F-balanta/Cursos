#include <stdio.h>
#include <math.h>

typedef struct SegundoGrado
{
    float x1, x2, a, b, c, d;
    int hay_sol;

}SegundoGrado;

int main()
{
    SegundoGrado ec;

    printf("Digite el valor de a: \n");
        scanf("%f", &ec.a);
    
    printf("Digite el valor de b: \n");
        scanf("%f", &ec.b);
    
    printf("Digite el valor de c: \n");
        scanf("%f", &ec.c);

    ec.d = ec.b * ec.b -4.0 * ec.a * ec.c;


    if (ec.d < 0)
    {
        ec.hay_sol = 0;
    }
    else
    {
        ec.hay_sol = 1;
        ec.x1 = (-ec.b + sqrt(ec.d)) / (2.0 * ec.a);
        ec.x2 = (-ec.b - sqrt(ec.d)) / (2.0 * ec.a);
    }
    if (ec.hay_sol)
    {
        printf("x1 : %f\n",ec.x1);
        printf("x2 : %f\n",ec.x2);
    }
    else
    {
        printf("No hay solucion");
    }

    return(0);
}