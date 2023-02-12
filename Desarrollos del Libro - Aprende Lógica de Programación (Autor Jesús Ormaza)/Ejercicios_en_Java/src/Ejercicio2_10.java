public class Ejercicio2_10 {
/*
Ejercicio 2.10 Escribir un programa que convierta los siguientes
datos a números, realice la operación indicada, transforme el
resultado a una cadena e imprima dicha cadena.
➢ a) “67.0”
➢ b) “56.5”
➢ c) ”39.34”
➢ Operación: a[(a-b)^2-^3√c]
 */
    public static void main(String[] args) {
       String a = "67.0";// Iniciado como string
       String b = "56.5";
       String c = "39.34";
       double aConv = Double.parseDouble(a);// Conversion a double
       double bConv = Double.parseDouble(b);
       double cConv = Double.parseDouble(c);
       double operacion = aConv * (Math.pow((aConv-bConv),2) - Math.cbrt(cConv));// Calculos
       String resultadoString = String.valueOf(operacion);// Conversion a string de la operación
       System.out.println("El resultado es: "+resultadoString);// Presentación del resultado como string.
    }
}
