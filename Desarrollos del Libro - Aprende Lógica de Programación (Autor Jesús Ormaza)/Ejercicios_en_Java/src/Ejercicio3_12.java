public class Ejercicio3_12 {
    public static void main(String[] args) {
        /*
        Ejercicio 3.12 
        Determinar si las expresiones resultantes de los
        literales del ejercicio 3.11 son verdaderas o falsas tomando que
        numEntero es igual a 105.
        */
        int numEntero = 105;
        boolean expresion1 = (numEntero > 76);
        boolean expresion2 = (numEntero <= 58);
        boolean expresion3 = (numEntero != 4);
        boolean expresion4 = (numEntero == 9);
        System.out.println("\n-- Ejercicio 3.12");
        System.out.println("Valor de numEntero es: "+numEntero);
        System.out.println("El resultado de numEntero > 76 es: "+expresion1);
        System.out.println("El resultado de numEntero <= 58 es: "+expresion2);
        System.out.println("El resultado de numEntero != 4 es: "+expresion3);
        System.out.println("El resultado de numEntero == 9 es: "+expresion4);

    }
}
