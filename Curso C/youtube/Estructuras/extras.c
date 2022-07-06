#include <stdio.h>

int main()
{
	typedef int MiTipoDeDato;

	//Ahora podemos crear variables enteras con el  tipo "MiTipoDeDato"

	MiTipoDeDato numero1 = 10, numero2 = 90, suma = 0;

	suma = numero1 + numero2;

	printf("El resultado es: %d", suma);

	return (0);
}
