package OperadorAritmetico;

public class Operador_aritmetico {
    public static void main(String[] args) {
        int val1, val2, val3, val4, r;
        val1 = 135;
        val2 = 325;
        val3 = 420;
        val4 = 21;

        //Operacion de suma
        r = val1 + val4;
        System.out.println("Operacion de Suma \n");
        System.out.println("La sumatoria del os valores es de: " + r);
        //Operacion de resta
        r = val2 - val3;
        System.out.println("Operacion de resta \n");
        System.out.println("La resta del los valores es de: " + r);
        //Operacion de multiplicacion
        r = val1 * val3;
        System.out.println("Operacion de Multiplicacion \n");
        System.out.println("El resultado de la operacion es de: " + r);
        //Operacion de división
        r = val2 / val4;
        System.out.println("Division\n");
        System.out.println("El resultado de la division es de: " + r);
    }
}
