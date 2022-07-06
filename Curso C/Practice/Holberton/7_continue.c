#include <stdio.h>

int main(void)
{  
    int i;

    for ( i = 0; i <= 99; i++)
    {
       if (i == 50)
       {
          continue;
        }
       
        printf("%d ", i );
    }
    

    return(0);
}