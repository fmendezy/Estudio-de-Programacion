public class Ejercicio2_3 {
/* 
Ejercicio 2.3 Escribir un programa que realice las siguientes
operaciones e imprima el resultado en pantalla:
➢ 6 * (-3)^3-4
➢ -4-(-3)^2+√9
➢ (10+12)-(4+6-8)-(4*2)^4
➢ 4{3-[5*6-4(12/(4-5*2))-24/3]}
 */
    public static void main(String[] args) {
        double a = 6 * Math.pow(-3,3) - 4;// 6 * (-3)^3-4
        double b = -4 - Math.pow(-3,2) + Math.sqrt(9);// -4 - (-3)^2 + √9
        double c = (10+12) - (4+6-8) - Math.pow((4*2),4);// (10+12)-(4+6-8)-(4*2)^4
        double d = 4 *( 3- ((5*6)-4*(12/(4-(5*2)))-24/3));// 4{3-[5*6-4(12/(4-5*2))-24/3]} <- Considera un * en -4'AQUI'(12/(....
        System.out.println("El resultado de: '6 * (-3)^3-4' es "+a);
        System.out.println("El resultado de: '-4-(-3)^2 + √9' es "+b);
        System.out.println("El resultado de: '(10+12)-(4+6-8)-(4*2)^4' es "+c);
        System.out.println("El resultado de: '4{3-[5*6-4(12/(4-5*2))-24/3]}' es "+d);
    }
}
