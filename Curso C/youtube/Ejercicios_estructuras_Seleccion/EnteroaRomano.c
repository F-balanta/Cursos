#include <stdio.h>

int main()
{
	int numero, millar, centenas, decenas, unidades;
	printf("Digite un numero\n");scanf("%i", &numero);

	unidades = numero % 10; numero /=10;
	decenas =  numero % 10; numero /=10;
	centenas =  numero % 10; numero /=10;
	millar =  numero % 10; numero /=10;

	switch(millar)
	{
	case 1: printf("M");
		break;
	case 2: printf("MM");
		break;
	case 3: printf("MMM");
		break;
	}
	switch(centenas)
	{
        case 1: printf("C");
                break;
        case 2: printf("CC");
                break;
        case 3: printf("CCC");
                break;
        case 4: printf("CD");
                break;
        case 5: printf("D");
                break;
        case 6: printf("DC");
                break;
        case 7: printf("DCC");
                break;
        case 8: printf("DCCC");
                break;
        case 9: printf("CM");
                break;
	}
        switch(decenas)
        {
        case 1: printf("X");
                break;
        case 2: printf("XX");
                break;
        case 3: printf("XXX");
                break;
        case 4: printf("XL");
                break;
        case 5: printf("L");
                break;
        case 6: printf("LX");
                break;
        case 7: printf("LXX");
                break;
        case 8: printf("LXXX");
                break;
        case 9: printf("XC");
                break;
        }
        switch(unidades)
        {
        case 1: printf("IX");
                break;
        case 2: printf("VIII");
                break;
        case 3: printf("VII");
                break;
        case 4: printf("VI");
                break;
        case 5: printf("V");
                break;
        case 6: printf("IV");
                break;
        case 7: printf("III\n");
                break;
        case 8: printf("II\n");
                break;
        case 9: printf("I\n");
                break;
        }
	putchar(10);
	return(0);
}
