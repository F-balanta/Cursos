#include <stdlib.h>
#include <stdio.h>

int main(void)
{
    int x, y, *p, *q;
    x = 5;
    y = 6;

    p =&x;
    q = &y;

    printf("%d %d", *p, *q);
    return(0);
}