public class Ejercicio4_1 {
    public static void main(String[] args) {
        /*
         Ejercicio 4.1 
         Declara un vector de números enteros con 100
        posiciones y rellena cada una de esas posiciones con los
        siguientes valores: 100,99,98, … , 3,2,1 . Los valores deben estar
        en orden descendente, es decir, la primera posición debe tener el
        valor 100, la segunda el 99 y así sucesivamente.
         */
        int[] array = new int[100];// 100 Posiciones
        for (int i = 0; i <= 100; i++) {
           array[i] = 100-i;
            System.out.println(array[i]);
        }
    }
}
