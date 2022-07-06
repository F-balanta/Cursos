#include <stdio.h>
struct Punto 
{
    float x;
    float y;
};

int main(void)
{
    struct Punto P;
    struct Punto Q;
    struct Punto R;
//Punto P  X y Y
    P.x = 0.0f;
    P.y = -12.5f;
    printf("Punto P  X = %f\nPunto P  Y = %f\n", P.x, P.y);
//Punto Q  X y y
    Q.x = 5.0f;
    Q.y = 3.0f;
    printf("Punto Q  X = %f\nPunto Q  Y = %f\n", Q.x, Q.y);
//Punto R  X y Y
    R.x = -1.0f;
    R.y = 3.0f;
    printf("Punto R  X = %f\nPunto R  Y = %f\n", R.x, R.y);
    

    return(0);
}