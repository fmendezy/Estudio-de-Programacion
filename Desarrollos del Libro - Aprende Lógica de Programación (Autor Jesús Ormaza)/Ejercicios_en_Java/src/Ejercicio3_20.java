import java.util.Scanner;// Importacion de libreria Scanner para recibir parametros desde teclado
public class Ejercicio3_20 {
    public static void main(String[] args) {
    /*
    Ejercicio 3.20 
    Escribe un programa que pida un número por
    teclado, si el número es negativo volver a pedirlo y así
    sucesivamente hasta que el usuario ingrese un número positivo.
    Por último con el número ingresado correctamente calcular su raíz cuadrada.
  */
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingresa un número:");
        int numero = sc.nextInt();
        while(numero < 0){
            System.out.println("Lo sentimos, el valor no puede ser negativo.\nIngresa el numero nuevamente:");
            numero = sc.nextInt();
        }
        if(sc != null) { sc.close();}// sc.close para evitar advertencias en el codigo.
        System.out.println("La raiz cuadrada de '"+numero+"' es: "+Math.sqrt(numero));
    }
}
