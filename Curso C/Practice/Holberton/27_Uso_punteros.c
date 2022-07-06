#include <stdio.h>
void modificar(int *y);
/*Comentarios*/
/*Comentarios*/
/*Comentarios*/
/*Comentarios*/

int main(void)
{
    int x, *p;
    x = 9;
    p = &x;
    modificar(p);

    printf("%d \n", x);

    return(0);
}
void modificar(int *y)
{
    *y  = 10;
}