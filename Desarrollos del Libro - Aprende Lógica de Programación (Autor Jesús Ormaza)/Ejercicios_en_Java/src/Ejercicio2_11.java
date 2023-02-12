import java.util.Scanner;// Importacion de libreria Scanner para recibir parametros desde teclado
public class Ejercicio2_11 {
/*
 Ejercicio 2.11 
 Repetir el ejercicio 2.6 con cadenas ingresadas por
teclado y el ejercicio 2.10 con números ingresados por teclado
*/
    public static void main(String[] args) {
        // Codigos del 2_11
        Scanner ingreso = new Scanner(System.in);
        System.out.println("> Ingrese una letra");
        String letra = ingreso.nextLine();
        System.out.println("> Bien, ahora ingrese 3 numeros (pueden tener decimales)\n 1) Ingrese el primer numero:");
        String valor1  = ingreso.nextLine();
        System.out.println(" 2) Ingrese el segundo numero:");
        String valor2  = ingreso.nextLine();
        System.out.println(" 3) Ingrese el tercer numero:");
        String valor3  = ingreso.nextLine();

        /*
        Ejercicio 2.6 Escribir un programa que reemplace las letras
        indicadas.
        ➢ “Lorem ipsum dolor sit amet”, reemplaza ‘o’ por ‘n’
        ➢ “Sed ut perspiciatis unde omnis” eliminar ‘u’ (ESTE NO SE HARÁ EN 2.11)
        */
        String Ejer2_6_a = "Lorem ipsum dolor sit amet";
       // String Ejer2_6_b = "Sed ut perspiciatis unde omnis";// Lo desabilito ya que se entiende el ejercicio solo con la "a" del 2.6
        System.out.println("-- Ejercicio 2.6");
        System.out.println("a) Reemplaza 'o' por '"+letra+"'");
        System.out.println("Original: '"+Ejer2_6_a+"' - Resultado: '"+Ejer2_6_a.replace("o",letra));
        //System.out.println("\nb)  eliminar 'u'");
        //System.out.println("Original: '"+Ejer2_6_b+"' - Resultado: '"+Ejer2_6_b.replace("u",""));


        /*
        Ejercicio 2.10 Escribir un programa que convierta los siguientes
        datos a números, realice la operación indicada, transforme el
        resultado a una cadena e imprima dicha cadena.
        ➢ a) “67.0”
        ➢ b) “56.5”
        ➢ c) ”39.34”
        ➢ Operación: a[(a-b)^2-^3√c]
        */
        String a = valor1;// Iniciado como string
        String b = valor2;
        String c = valor3;
        double aConv = Double.parseDouble(a);// Conversion a double
        double bConv = Double.parseDouble(b);
        double cConv = Double.parseDouble(c);
        double operacion = aConv * (Math.pow((aConv-bConv),2) - Math.cbrt(cConv));// Calculos
        String resultadoString = String.valueOf(operacion);// Conversion a string de la operación
        System.out.println("\n-- Ejercicio 2.10");
        System.out.println("El resultado es de "+a+"[("+a+"-"+b+")^2-^3√"+c+"]: "+resultadoString);// Presentación del resultado como string.
    }
}
