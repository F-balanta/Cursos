#include <stdio.h>

int main(void)
{
    int h = 0, m = 0, s = 0;

    while (h < 24)
    {
        h++;
        while (m < 60)
        {
            m++;
            while (s < 60)
            {
                printf("%d \n", h);
                printf("%d \n", m);
                printf("%d \n", s);
                s++;
            }
            
        }
       
    }
    putchar(10);
    
   /* for (h = 0; h < 24; h++)
    {
        for (m = 0; m < 60 ;m++) 

            for (s = 0; s < 60; s++)
            {
                printf("%d: %d: %d: \n", h, m, s);
            }
            
    }*/
    
}