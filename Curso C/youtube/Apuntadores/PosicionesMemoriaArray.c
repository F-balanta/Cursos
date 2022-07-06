#include <stdio.h>

int main() {

	int i,n[] = {1,2,3,4,4,7,8,9,5,4};
	int *pn;

	pn = n;

	for (i = 0; i < 10; i++){
		printf("Posicion-----[%p]----valor[%d]: %d", pn, i,*pn);
		printf("\n\n");
		pn++;
	}
	return 0;
}
