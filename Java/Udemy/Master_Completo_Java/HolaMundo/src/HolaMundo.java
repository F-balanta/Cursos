public class HolaMundo {

    public static void main(String[] args) {
        String saludar = "Hola Mundo desde Java";
        System.out.println(saludar);
        System.out.println("Saludar to UPPERCASE() = " + saludar.toUpperCase());

        int numero = 10;

        boolean valor = true;
        int numero2=5;
        if(valor){
            System.out.println("numeero = " + numero);
            numero2 = 10;
        }
        System.out.println("numeero2 = " + numero2);

        var numero3 = "15";

        String nombre;
        nombre = "Andres";

        if(numero > 10){
            nombre = "Juan";
        }

        System.out.println("nombre = " + nombre);
    }
}