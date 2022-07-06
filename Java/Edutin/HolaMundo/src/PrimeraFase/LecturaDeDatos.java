package PrimeraFase;

import java.util.Scanner;

public class LecturaDeDatos {
    public static void main(String[] args) {
        // Variable de tipo Scanner llamada Lector inicializada como scanner
        // Hace parte de3 la libreria java.util.Scanner
        // Recibe como parametro Systema de entrada (System.in) Para darle datos a nuestro programa.
        Scanner lector = new Scanner(System.in);
        // De esta forma declaramos una variable de tipo string
        String nombre;
        String espacio = " ";
        /* Para poder guardar los datos que ingresen por consola a nuestro programa
            utilizaremos la instancia que creamos a partir de la libreria Scanner
            En este caso (Lector)
         */
        nombre = lector.next();
        /* lector es una variable de tipo scanner que nos permite acceder a todas las funcionalidades
            que esta libreria contiene*/

        System.out.println("Hola " + nombre + espacio + "Bienvenido a Java");
    }
}
