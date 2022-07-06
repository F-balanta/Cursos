#include <stdio.h>
#include <assert.h>

int main(void)
{   

    int x , y, z;
    
    x = 1;
    y = 2;

    z = x + y;

    assert(z == 3);
    printf("%d \n", z);
    return(0);
}