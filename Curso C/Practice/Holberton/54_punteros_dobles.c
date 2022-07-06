#include <stdlib.h>
#include <stdio.h>

int main(void)
{
    int x, y, *p, *q, **t;
    x = 5;
    y = 6;

    p =&x;
    q = &y;

    t = &p;
    printf("%d\n", **t);
    printf("%d\n %d\n", *p, *q);
    return(0);
}