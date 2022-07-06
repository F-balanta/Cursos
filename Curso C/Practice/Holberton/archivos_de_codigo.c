#include <stdio.h>
#include "otro.h"

int main(void)
{
    float a,b,c,d;

    a = suma(1,2);
    b = resta(1,2);
    c = multiplicar(1,2);
    d = divide(1,2);

    printf("%f \n", a);
    printf("%f \n", b);
    printf("%f \n", c);
    printf("%f \n", d);
    return(0);
}
