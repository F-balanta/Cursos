#include <stdio.h>
int suma1(int x);

int main(void)
{
    int n;
    n = suma1(5);
    printf("%d \n", n);

    return(0);
}

int suma1(int x)
{
    return(x + 1);
}