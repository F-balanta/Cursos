package seccion_2;

public class Ejercicios {
    public static void main(String[] args) {
        System.out.println("Ejercicio 1:");
        int x = 144, y = 999;
        System.out.println("Suma: " + x +" + " + y + " = " + (x + y));
        System.out.println("Resta: " + x +" - " + y + " = " + (x - y));
        System.out.println("Multiplicación: " + x +" * " + y + " = " + (x * y));
        System.out.println("División: " + x +" / " + y + " = " + (x / y));


        System.out.println("\n\n\nEjercicio 4:");
        double valorAConvertir = 100, valorEuro = 4367.89;
        double resultado = (valorAConvertir * valorEuro);
        System.out.println("Valor del Eur: " + valorEuro);
        System.out.println("Cantidad a convertir: " + valorAConvertir);
        System.out.println("Resultado: " + resultado);


        System.out.println("\n\n\nEjercicio 6:");
        String Articulo = "Vasos de Porcelana";
        double precio = 25000, porcentaje = 0.19, total = 0, iva = (precio * porcentaje);
        System.out.println("Articulo Comprado: " + Articulo);
        System.out.println("Valor del producto(sin iva): " + precio);
        System.out.println("Valor del producto (con iva incluido) =  " + (precio + iva));
        
    }
}
