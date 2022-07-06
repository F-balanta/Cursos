#include <stdio.h>

int main(){
    //puntero para abrir un archivo 
    FILE *archivo = fopen("C:/Users/Balanti-K/Desktop/trabajo.txt", "r");

    if (archivo == NULL)
    {
        printf("EL archivo no se pudo abrir");
         return 1;
    }
       
        int x = 5;
        //escribe dentro del archivo
        fprintf(archivo, "Archivo Modificado %d", x);
        //Limpia el flujo de datos
        fflush(archivo);
        //Cierra el archivo
        fclose(archivo);
    
    /* Formas de abir el archivo
        write : r - escritura
        Read : r  Lectura
        Append : a  Escribir al final del archivo
        Binary : b  Binario
    */
   return(0);
}