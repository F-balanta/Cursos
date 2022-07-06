#include <stdio.h>
int factorial(int n)
{   
    if(n == 1)
        return 1;
    return n *factorial(n - 1);
}
int main()
{
    int n;
    n = 5;
    printf("El factorial de %d es %d\n",n ,factorial(n));
    

    return(0);
}