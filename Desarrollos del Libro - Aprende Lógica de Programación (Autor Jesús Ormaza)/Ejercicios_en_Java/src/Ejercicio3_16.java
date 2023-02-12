import java.util.Scanner;// Importacion de libreria Scanner para recibir parametros desde teclado
public class Ejercicio3_16 {
    public static void main(String[] args) {
    /*
    Ejercicio 3.16 
    Añade la operación multiplicar en la estructura
    “SWITCH” del código 3.24
    */
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingrese el primer número");
        int num1 = sc.nextInt();
        System.out.println("Ingrese el segundo número");
        int num2 = sc.nextInt();
        System.out.println("Ingrese el nombre de la operación");
        String operacion = sc.next();
        if(sc != null) { sc.close();}// sc.close para evitar advertencias en el codigo.
        int resultado;
        switch (operacion) {
        case "sumar":
            resultado = num1 + num2;
            System.out.println("La suma es = " + resultado);
            break;
        case "restar":
            resultado = num1 - num2;
            System.out.println("La resta es = " + resultado);
            break;
        case "multiplicar":
            resultado = num1 * num2;
            System.out.println("La multiplicación es = "+resultado);
            break;
        default:
            System.out.println("La operación ingresada no es válida");
            break;
        }
    }
}
