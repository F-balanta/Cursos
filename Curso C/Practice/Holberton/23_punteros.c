#include <stdio.h>

int main(void)
{
    int x = 5;

    int *p = &x;
    printf("%d\n", x);
    printf("%p\n", p);
return(0);
}