#include <stdio.h>
#include <math.h>
#define M_PI 3.14159265358979323846


float a_radianes(float x);
float a_grados(float x);

int main()
{
    float x, a, b;

    x = sin(a_radianes(30.0f));
    a = a_grados(asin(0.5f));
    b = cos(a_radianes(0));

    printf("%f\n ", x);
    printf("%f\n ", a);
    printf("%f\n ", b);

    return(0);
}
// PI rad 0 180°
float a_radianes(float x)
{
     return (x * M_PI / 180.0f);
}
float a_grados(float x)
{
    return( x * 180.0f / M_PI);
}