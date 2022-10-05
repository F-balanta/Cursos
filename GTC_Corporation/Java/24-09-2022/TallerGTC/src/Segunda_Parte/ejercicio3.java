package Segunda_Parte;

public class ejercicio3 {

    public static void main(String[] args) {

        TotalFactura();
    }

    public static void TotalFactura(){
        String articulo = "PC GAMER";
        double precio = 2300000, porcentaje = 0.19, total = 0, iva = (precio * porcentaje);
        System.out.println("Articulo Comprado: " + articulo);
        System.out.println("Valor del producto(sin iva): " + precio);
        System.out.println("Valor del producto (con iva incluido) =  " + (precio + iva));
    }
}
