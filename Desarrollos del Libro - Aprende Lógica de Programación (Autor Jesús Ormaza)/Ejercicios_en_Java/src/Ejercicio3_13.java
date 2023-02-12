import java.util.Scanner;// Importacion de libreria Scanner para recibir parametros desde teclado
public class Ejercicio3_13 {
    public static void main(String[] args) {
        /*
        Ejercicio 3.13 Escribe un programa que pida un número entero
        por teclado, determinar si dicho número está en los siguientes
        rangos mediante expresiones lógicas, guardar el resultado de las
        expresiones en variables booleanas e imprimirlas en pantalla.
        (numEntero hace referencia a la variable donde debes guardar el
        dato pedido por teclado)
        ➢ numEntero sea positivo y menor o igual a 50
        ➢ numEntero sea negativo o mayor a 20
        ➢ numEntero menor a -6 o positivo
        ➢ numEntero sea negativo o igual a 34
        */
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingresa un número entero:");
        int numEntero = sc.nextInt();
        if(sc != null) { sc.close();}// sc.close para evitar advertencias en el codigo.
        boolean a = (numEntero >= 1 && numEntero <= 50);// numEntero sea positivo y menor o igual a 50
        boolean b = (numEntero < 0 || numEntero > 20);// numEntero sea negativo o mayor a 20
        boolean c = (numEntero < -6 || numEntero >= 1);// numEntero menor a -6 o positivo
        boolean d = (numEntero < 0 || numEntero == 34);// numEntero sea negativo o igual a 34
        System.out.println("-- El valor de numEntero es: "+numEntero);
        System.out.println("numEntero es positivo y menor o igual a 50: "+a);
        System.out.println("numEntero es negativo o mayor a 20: "+b);
        System.out.println("numEntero es menor a -6 o positivo: "+c);
        System.out.println("numEntero es negativo o igual a 34: "+d);
    }
}
