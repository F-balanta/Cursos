#include <stdio.h>
#include <stdarg.h>
double suma(int n, ...);

int main()
{
    double x;
    x = suma(5, 1.0f, 2.0f, 3.0f, 4.0f, 5.0f);
    
    printf("%lf", x);
    return(0);
}

double suma(int n, ...)
{
    double valor, s;
    va_list parametros;
    va_start(parametros, n);
    s = 0.0f;
    for (int i = 0; i < n; i++)
    {
        valor = va_arg(parametros, double);
        s += valor;
    }
    
    va_end(parametros);
    return(s);
}