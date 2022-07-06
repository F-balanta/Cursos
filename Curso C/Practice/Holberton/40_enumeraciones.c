#include <stdio.h>

enum DiaDeLaSemana
{
    Dom,
    Lun,
    Mar,
    Mie,
    Jue,
    Vie,
    Sab
};
int main(void)
{   
    int x;
    x = 5;
    switch (x)
    {
    case Dom:
        print("Dom\n");
        break;
    case Lun:
        print("Lun\n");
        break;
    case Mar:
        print("Mar\n");
        break;
    case Mie:
        print("Mie\n");
       break;
    case Jue:
        print("Jue\n");
        break;
    case Vie:
        print("Vie\n");
        break;
    case Sab:
        print("Sab\n");
        break;

    default:
        print("Error \n");
        break;
    }

    return(0);
}