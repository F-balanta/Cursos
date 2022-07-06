#include <stdio.h>

int main(void)
{
    int n;
    
    for (n = 0; n <= 99; n++)
    {
        printf("%d ", n);

        if (n == 25)
        {
            break;
        }
        
    }
    

    return(0);
}