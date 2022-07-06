#include<stdio.h>

int vocal_A(char *s);
int vocal_E(char *s);
int vocal_I(char *s);
int vocal_O(char *s);
int vocal_U(char *s);


int main()

{
	char palabra[20],a,e,i,o,u;

	printf("Digite una palabra:\n");
	scanf("%s", palabra);

	a = vocal_A(palabra);
	e = vocal_E(palabra);
	i = vocal_I(palabra);
	o = vocal_O(palabra);
	u = vocal_U(palabra);

	printf("La vocal A aparece [%d] veces", a);
	printf("La vocal I aparece [%d] veces", e);
	printf("La vocal I aparece [%d] veces", i);
	printf("La vocal O aparece [%d] veces", o);
	printf("La vocal U aparece [%d] veces", u);

	return (0);
}
int vocal_A(char *s)
{
	int cont = 0;
	while (*s)
	{
		switch (*s)
		{
		case 'a': cont++;
		}
		s++;
	}
	return(cont);
}
int vocal_E(char *s)
{
	int cont = 0;
	while (*s)
	{
		switch (*s)
		{
		case 'e': cont++;
		}
		s++;
	}
	return(cont);

}
int vocal_I(char *s)
{
	int cont = 0;
	while (*s)
	{
		switch (*s)
		{
		case 'i': cont++;
		}
		s++;
	}
	return(cont);
}
int vocal_O(char *s)
{
	int cont = 0;
	while (*s)
	{
		switch (*s)
		{
		case 'o': cont++;
		}
	}
}
int vocal_U(char *s)
{
	int cont = 0;
	while (*s)
	{
		switch (*s)
		{
		case 'u': cont++;
		}
		s++;
	}
	return(cont);
}
