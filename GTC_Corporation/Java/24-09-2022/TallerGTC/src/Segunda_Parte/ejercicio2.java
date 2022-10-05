package Segunda_Parte;

public class ejercicio2 {

    public static void main(String[] args) {
        Conversor();
    }

    public static void Conversor(){
        double valor = 100, euro = 4300, result = (valor * euro);;

        System.out.println("Valor Euro: " + euro);
        System.out.println("Cantidad a convertir: " + valor);
        System.out.println("Resultado de la conversion " + result);
    }
}
