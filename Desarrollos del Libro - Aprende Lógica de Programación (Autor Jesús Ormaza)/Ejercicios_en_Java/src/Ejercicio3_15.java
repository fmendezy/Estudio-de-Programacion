import java.util.Scanner;// Importacion de libreria Scanner para recibir parametros desde teclado
public class Ejercicio3_15 {
    public static void main(String[] args) {
        /*
        Ejercicio 3.15
         Repite el ejercicio 3.14, y si el número ingresado es
        0 notificar que dicho valor no es válido.
         */
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingresa un numero entero, este será el dividendo:");
        int dividendo = sc.nextInt();
        System.out.println("Ingresa otro numero, este será el divisor:");
        int divisor = sc.nextInt();
        if(sc != null) { sc.close();}// sc.close para evitar advertencias en el codigo.
        int resultado = 0;
        if(divisor != 0){
            resultado = dividendo/divisor;
            System.out.println("El resultado de dividiro "+dividendo+"/"+divisor+" es = "+resultado);
        } else {
            System.out.println("No se puede dividir entre cero, el número no es valido");// <- 3.15
        }
    }
}
