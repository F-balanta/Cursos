#include <stdio.h>

int fibonacci(int n)
{
    if (n == 0 ||n == 1)
        return(1);

        return(fibonacci(n - 1) + fibonacci(n - 2));

}

int main()
{
    int m, n;
    for (n = 0; n < 10; n++)
    {
    m = fibonacci(n);

     printf("%d ", m);

    }
    

    return(0);
}