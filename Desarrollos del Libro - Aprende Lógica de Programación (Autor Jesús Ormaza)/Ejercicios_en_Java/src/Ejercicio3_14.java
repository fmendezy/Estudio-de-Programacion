import java.util.Scanner;// Importacion de libreria Scanner para recibir parametros desde teclado
public class Ejercicio3_14 {
    public static void main(String[] args) {
        /*
            Ejercicio 3.14 
            Escribe un programa que pida dos números por
            teclado, uno va a ser el dividendo y otro el divisor, comprobar si el
            divisor es diferente de 0 para realizar la división entre los dos e
            imprimir el resultado en pantalla.
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
        }
        System.out.println("El resultado de dividiro "+dividendo+"/"+divisor+" es = "+resultado);
    }
}
