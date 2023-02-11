public class Ejercicio2_4 {
/*
Ejercicio 2.4 Realizar un programa para resolver las siguientes
operaciones e imprimir el resultado truncado y redondeado a dos
decimales.
➢ 789/62
➢ √963
➢ √632
 */
    public static void main(String[] args) {
        // Valores a desarrollar.
        double a = 789/62;// 789/62
        double b = Math.sqrt(963);;// √963
        double c = Math.sqrt(632);// √632

        // Caso a:
        double a_redondeado = Math.round(a);
        int a_truncado = (int)a;
        System.out.println("En el caso de "+a+", su valor redondeado es '"+a_redondeado+"' y truncado es '"+a_truncado+"'.");
        // Caso b:
        double b_redondeado = Math.round(b);
        int b_truncado = (int)b;
        System.out.println("En el caso de "+b+", su valor redondeado es '"+b_redondeado+"' y truncado es '"+b_truncado+"'.");
        // Caso c:
        double c_redondeado = Math.round(c);
        int c_truncado = (int)c;
        System.out.println("En el caso de "+c+", su valor redondeado es '"+c_redondeado+"' y truncado es '"+c_truncado+"'.");
    }
}
